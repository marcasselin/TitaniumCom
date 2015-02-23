namespace Carbon.Commerce.Services
{
	using System.Threading.Tasks;

	using Carbon.Commerce;

	public interface IPaymentProcessor
    {
		PaymentProcessorType Type { get; }

		bool Accepts(IPaymentMethod paymentMethod);

		/// <summary>
		/// Charges an invoice to the provided payment method.
		/// </summary>
		Task<IMonetaryTransaction> Charge(IPaymentMethod paymentMethod, ISalesDocument order, bool storePaymentMethod);

		/// <summary>
		/// Credits the payment method
		/// </summary>
		Task<IMonetaryTransaction> Credit(IPaymentMethod paymentMethod, decimal amount);

		/// <summary>
		/// Refunds the transaction in full
		/// </summary>
		Task<IMonetaryTransaction> Refund(IMonetaryTransaction transaction);

		/// <summary>
		/// Authorizes a sale for the provided invoice amount.
		/// </summary>
		/// <param name="invoice">The invoice to authorize the funds for</param>
		/// <param name="paymentMethod">The payment method used to capture the funds</param>
		Task<IMonetaryTransaction> Reserve(IPaymentMethod paymentMethod, ISalesDocument order);

		/// <summary>
		/// Marks the full amount of a previously authorized transaction for capture
		/// </summary>
		Task Settle(IMonetaryTransaction transaction);

		/// <summary>
		/// Marks a given amount of a previously authorized transaction for capture
		/// </summary>
		Task Settle(IMonetaryTransaction transaction, decimal amount);

		/// <summary>
		/// Attempts to verify a payment method by authorizing and voiding a charge for 1 dollar
		/// </summary>
		Task<PaymentMethodVerification> Verify(IPaymentMethod paymentMethod, bool storePaymentMethod);

		/// <summary>
		/// Voids a transaction that has not yet been captured
		/// </summary>
		Task Void(IMonetaryTransaction transaction);
	}
}