namespace Carbon.Commerce
{
	public enum MonetaryTransactionState
	{
		Unknown = 0,

		/// <summary>
		/// Captured/ settled
		/// </summary>
		Settled = 1,

		/// <summary>
		/// Failed 
		/// Delined by processor, Rejected (at gateway), or error while sending the transaction to the processor
		/// </summary>
		Failed = 2,

		/// <summary>
		/// The transaction is in initiated status.
		/// If the payment method used in the transaction is a credit card, the transaction will be completed in five to six seconds.
		/// If the payment method used in the transaction is a bank account (ACH), the transaction will be completed in three to four days.
		/// </summary>
		Initiated = 3,

		/// <summary>
		/// Authorization hold
		/// Ready for capture
		/// Reserved
		/// </summary>
		Authorized = 4,

		/// <summary>
		/// The transaction was voided.
		/// You can void transactions when the status is authorized or submitted for settlement. 
		/// After the transaction has been settled, you will have to refund the transaction instead.
		/// </summary>
		Voided = 5
	}

	// AUTHORIZED, AUTHORIZING, FAILED, GATEWAY_REJECTED, PROCESSOR_DECLINED, 
	// SETTLED, SETTLEMENT_FAILED, SUBMITTED_FOR_SETTLEMENT, UNKNOWN, UNRECOGNIZED, VOIDED
}