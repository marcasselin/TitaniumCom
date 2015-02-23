namespace Carbon.Commerce
{
	using System;

	public interface IPaymentMethod 
	{
		int Id { get; }

		DateTime? Verified { get; }

		// Replace with PaymentMethodFeatures
		bool IsChargable { get; }
	}
}