namespace Carbon.Commerce
{
	public enum CreditCardDeclineReason
	{
		Unknown = 0,
		None = 1,
		AccountClosed = 2,
		AccountFrozen = 3,
		AvsFailure = 4,
		AvsMismatch = 5,
		CvvMismatch = 6,
		ExpiredCard = 7,
		FraudDetected = 8,
		InsufficientFunds = 9,
		PickUpCard = 10,
		StolenOrLostCard = 11,
		InvalidCreditCardInfo = 15,
		Error = 50
	}
}
