namespace Carbon.Commerce
{
	using System;

	using Carbon;

	public class BillingCycle : IRange<DateTime>
	{
		private readonly DateTime start;
		private readonly DateTime end;
		private readonly Interval interval;

		public BillingCycle(DateTime start, DateTime end, Interval interval)
		{
			#region Preconditions

			if (start > end)
				throw new ArgumentException("Must be before end", paramName: "start");

			if (interval == null)
				throw new ArgumentNullException("interval");

			#endregion

			this.start = start;
			this.end = end;
			this.interval = interval;
		}

		public DateTime Start
		{
			get { return start; }
		}

		public DateTime End
		{
			get { return end; }
		}

		public TimeUnit GetTimeUnit()
		{
			var duration = interval.ToDuration();

			return duration.GetLargestUnit();
		}

		public int GetTimeFrequency()
		{
			var duration = interval.ToDuration();
			var timeUnit = duration.GetLargestUnit();

			switch (timeUnit)
			{
				case TimeUnit.Year:		return duration.Years;
				case TimeUnit.Month:	return duration.Months;
				case TimeUnit.Day:		return duration.Days;
				default:				throw new Exception("Invalid interval unit: " + timeUnit);
			}
		}

		#region Helpers

		public DateRange Period
		{
			get { return new DateRange(Start, End); }
		}

		#endregion

		public static BillingCycle CalculateFirst(DateTime start, Interval interval)
		{
			return new BillingCycle(start, end: interval.CalculateNext(start), interval: interval);
		}

		public BillingCycle CalculateNext()
		{
			return new BillingCycle(
				start:		this.end, 
				end:		interval.CalculateNext(this.End),
				interval:	interval
			);
		}

		public override string ToString()
		{
			return string.Format("({0} - {1})",
				/*0*/ Start.ToString("yyyy/MM/dd"),
				/*1*/ End.ToString("yyyy/MM/dd")
			);
		}
	}
}