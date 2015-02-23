namespace Carbon.Commerce
{
	using System;

	/// <summary>
	/// A transaction that exchanges money between accounts
	/// Represents a single transaction created by the payment service
	/// </summary>
	public interface IMonetaryTransaction
	{
		/// <summary>
		/// An user defined identifier
		/// </summary>
		string OrderId { get; }

		/// <summary>
		/// The transaction state
		/// e.g. OnHold, Procesing, Completed, Failed (declined)
		/// </summary>
		MonetaryTransactionState State { get; }

		/// <summary>
		/// Identifies the transaction in the system (merchant provider) and can be used  
		/// to submit a modification of this transaction at a later time, such as voiding, 
		/// crediting, or capturing. 
		/// </summary>
		string ReferenceNumber { get; }

		/// <summary>
		/// A memo or note
		/// e.g. Invoice #10 Payment
		/// </summary>
		string Description { get; }

		/// <summary>
		/// The amount of the transaction
		/// Refunds are negitive
		/// </summary>
		decimal Amount { get; }

		/// <summary>
		/// The underlying payment method of the transaction
		/// e.g. Bank Account, Credit Card, Paypal Account, Paypal Subscription
		/// </summary>
		IPaymentMethod PaymentMethod { get; }

		PaymentProcessorType Processor { get; }

		DateTime Created { get; }

		// PendingReason
		// FailureReason
		// Completed
	}
}