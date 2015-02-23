namespace Carbon.Commerce
{
	using System;

	public class CreditCardTransaction : IMonetaryTransaction
	{
		public PaymentAction Action { get; set; }

		public bool Success { get; set; }

		public string OrderId { get; set; }

		/// <summary>
		/// A unique id assigned to the transaction by the merchant provider
		/// </summary>
		public string ReferenceNumber { get; set; }

		public string AuthorizationCode { get; set; }

		/// <summary>
		/// The id of the batch the transaction will settle in
		/// </summary>
		public string BatchId { get; set; }

		/// <summary>
		/// A memo or description
		/// e.g. Invoice #456 Authorization
		/// </summary>
		public string Description { get; set; }

		public decimal Amount { get; set; }

		/// <summary>
		/// An explination of the response
		/// </summary>
		public string ResponseMessage { get; set; }

		/// <summary>
		/// Address Verification Service Result Code
		/// </summary>
		public AvsResult AvsResult { get; set; }

		/// <summary>
		/// The verification result code of three digit number on the back of the card
		/// </summary>
		public CvvResult CvvResult { get; set; }

		/// <summary>
		/// The reason the card declined, if applicable
		/// </summary>
		public CreditCardDeclineReason DeclineReason { get; set; }

		/// <summary>
		/// The credit card used in the transaction
		/// </summary>
		public IPaymentMethod PaymentMethod { get; set; }

		/// <summary>
		/// The service used to process the transaction
		/// </summary>
		public PaymentProcessorType Processor { get; set; }

		/// <summary>
		/// The date and time the original transaction took place (In UTC)
		/// </summary>
		public DateTime Created { get; set; }

		#region IMonetaryTransaction

		MonetaryTransactionState IMonetaryTransaction.State
		{
			get { return GetMonetaryTransactionState(); }
		}

		public MonetaryTransactionState GetMonetaryTransactionState()
		{
			if (Success)
			{
				switch (Action)
				{
					case PaymentAction.Reserve: return MonetaryTransactionState.Authorized;

					case PaymentAction.Sale:
					case PaymentAction.Credit: return MonetaryTransactionState.Settled;

					default: throw new Exception("Invalid payment action:" + this.Action);
				}
			}

			return MonetaryTransactionState.Failed;
		}

		#endregion
	}
}
