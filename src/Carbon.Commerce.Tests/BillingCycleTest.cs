namespace Carbon.Commerce.Tests
{
	using System;

	using NUnit.Framework;

	[TestFixture]
	public class BillingCycleTest
	{
		[Test]
		public void DailyBillingIsCorrect()
		{
			var cycle = BillingCycle.CalculateFirst(
				start: new DateTime(2008, 1, 1),
				interval: Interval.Daily(30)
			);

			Assert.AreEqual(TimeUnit.Day,				cycle.GetTimeUnit());
			Assert.AreEqual(30,							cycle.GetTimeFrequency());
			Assert.AreEqual(30,							cycle.Period.TimeSpan.Days);
			Assert.AreEqual(new DateTime(2008, 1, 31),	cycle.End);

			var nextCycle = cycle.CalculateNext();

			Assert.AreEqual(TimeUnit.Day,				nextCycle.GetTimeUnit());
			Assert.AreEqual(30,							nextCycle.GetTimeFrequency());
			Assert.AreEqual(new DateTime(2008, 1, 31),	nextCycle.Start);
			Assert.AreEqual(new DateTime(2008, 3, 1),	nextCycle.End); // 29 days in Feb 2008
		}

		[Test]
		public void MonthlyBillingIsCorrect()
		{
			var cycle = new BillingCycle(
				interval: Interval.Monthly(1), 
				start: new DateTime(2006, 1, 1), 
				end: new DateTime(2006, 2, 1)
			);

			var nextCycle = cycle.CalculateNext();

			Assert.AreEqual(TimeUnit.Month,				nextCycle.GetTimeUnit());
			Assert.AreEqual(1,							nextCycle.GetTimeFrequency());
			Assert.AreEqual(new DateTime(2006, 2, 1),	nextCycle.Start);
			Assert.AreEqual(new DateTime(2006, 3, 1),	nextCycle.End);

			// Calculate the next billing cycle (using the previous calculated billing cycle)
			nextCycle = nextCycle.CalculateNext();

			Assert.AreEqual(TimeUnit.Month,				nextCycle.GetTimeUnit());
			Assert.AreEqual(1,							nextCycle.GetTimeFrequency());
			Assert.AreEqual(new DateTime(2006, 3, 1),	nextCycle.Start);
			Assert.AreEqual(new DateTime(2006, 4, 1),	nextCycle.End);
		}

		[Test]
		public void YearlyBillingIsCorrect()
		{
			var recurringPayment = new RecurringPaymentInfo {
				Interval = Interval.FromIsoDuration("P1Y"),
				Start = new DateTime(2008, 1, 1)
			};

			Assert.AreEqual(TimeUnit.Year,	recurringPayment.GetTimeUnit());
			Assert.AreEqual(1,				recurringPayment.GetTimeUnitFrequency());

			var cycle = BillingCycle.CalculateFirst(
				start:		recurringPayment.Start,
				interval:	recurringPayment.Interval	
			);

			Assert.AreEqual(TimeUnit.Year,				cycle.GetTimeUnit());
			Assert.AreEqual(new DateTime(2008, 1, 1),	cycle.Start);
			Assert.AreEqual(new DateTime(2009, 1, 1),	cycle.End);

			var nextCycle = cycle.CalculateNext();

			Assert.AreEqual(TimeUnit.Year,				nextCycle.GetTimeUnit());
			Assert.AreEqual(1,							nextCycle.GetTimeFrequency());
			Assert.AreEqual(new DateTime(2009, 1, 1),	nextCycle.Start);
			Assert.AreEqual(new DateTime(2010, 1, 1),	nextCycle.End);

			nextCycle = nextCycle.CalculateNext();

			Assert.AreEqual(TimeUnit.Year,				nextCycle.GetTimeUnit());
			Assert.AreEqual(1,							nextCycle.GetTimeFrequency());
			Assert.AreEqual(new DateTime(2010, 1, 1),	nextCycle.Start);
			Assert.AreEqual(new DateTime(2011, 1, 1),	nextCycle.End);
		}
	}
}