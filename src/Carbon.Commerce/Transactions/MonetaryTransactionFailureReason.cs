namespace Carbon.Commerce
{
	public enum MonetaryTransactionFailureReason 
	{
		Unknown = 0,
		
		AccountClosed = 1,

		InsufficientFunds = 2,

		/// <summary>
		/// The account has a fraud flag on it (e.g. stolen card)
		/// </summary>
		Fraudulant = 3,

		SystemError = 4
	}
/*

2002	Limit Exceeded
2003	Cardholder's Activity Limit Exceeded
2004	Expired Card
2005	Invalid Credit Card Number
2006	Invalid Expiration Date
2007	No Account
2008	Card Account Length Error
2009	No Such Issuer
2010	Card Issuer Declined CVV
2011	Voice Authorization Required
2012	Voice Authorization Required - Possible Lost Card
2013	Voice Authorization Required - Possible Stolen Card
2014	Voice Authorization Required - Fraud Suspected
2015	Transaction Not Allowed
2016	Duplicate Transaction
2017	Cardholder Stopped Billing
2018	Cardholder Stopped All Billing
2019	Invalid Transaction
2020	Violation
2021	Security Violation
2022	Declined - Updated Cardholder Available
2023	Processor Does Not Support This Feature
2024	Card Type Not Enabled
2025	Set Up Error - Merchant
2026	Invalid Merchant ID
2027	Set Up Error - Amount
2028	Set Up Error - Hierarchy
2029	Set Up Error - Card
2030	Set Up Error - Terminal
2031	Encryption Error
2032	Surcharge Not Permitted
2033	Inconsistent Data
2034	No Action Taken
2035	Partial Approval For Amount In Group III Version
2036	Authorization could not be found to reverse
2037	Already Reversed
2038	Processor Declined
2039	Invalid Authorization Code
2040	Invalid Store
2041	Declined - Call For Approval
2043	Error - Do Not Retry, Call Issuer
2044	Declined - Call Issuer
2045	Invalid Merchant Number
2046	Declined
2047	Call Issuer. Pick Up Card.
2048	Invalid Amount
2049	Invalid SKU Number
2050	Invalid Credit Plan
2051	Credit Card Number does not match method of payment
2052	Invalid Level III Purchase
2053	Card reported as lost or stolen
2054	Reversal amount does not match authorization amount
2055	Invalid Transaction Division Number
2056	Transaction amount exceeds the transaction division limit
2057	Issuer or Cardholder has put a restriction on the card
*/

/*
Failure Codes¶

3000 class codes are problems with the back-end processing network, and don’t necessarily mean a problem with the card itself.

Code	Text
3000	Processor network unavailable.Try Again
*/
}