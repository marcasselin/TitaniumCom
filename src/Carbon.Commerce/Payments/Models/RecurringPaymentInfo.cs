namespace Carbon.Commerce
{
	using System;

	public class RecurringPaymentInfo : IRecurringPayment
	{
		public decimal Amount { get; set; }

		public DateTime Start { get; set; }

		public DateTime? End { get; set; }

		public Interval Interval { get; set; }

		public TimeUnit GetTimeUnit()
		{
			var duration = Interval.ToDuration();

			return duration.GetLargestUnit();
		}

		public int GetTimeUnitFrequency()
		{
			var duration = Interval.ToDuration();

			switch (duration.GetLargestUnit())
			{
				case TimeUnit.Year:		return duration.Years;
				case TimeUnit.Month:	return duration.Months;
				case TimeUnit.Day:		return duration.Days;
				default:				throw new Exception("Invalid billing interval: " + duration.GetLargestUnit());
			}
		}
	}
}