namespace Carbon.Commerce
{
	using System;

	public interface IRecurringPayment
	{
		DateTime Start { get; }

		DateTime? End { get; }

		Interval Interval { get; }

		decimal Amount { get; }
	}
}