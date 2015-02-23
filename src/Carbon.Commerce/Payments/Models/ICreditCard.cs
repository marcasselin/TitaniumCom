namespace Carbon.Commerce
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public interface ICreditCard : IPaymentMethod
	{
		string Number { get; }

		/// <summary>
		/// Card verification value
		/// 3 or 4 chars
		/// </summary>
		string Cvv { get; }

		DateTime Expires { get; } 

		/// <summary>
		/// The credit card holders billing info
		/// Name, Phone Number, Address [where the statement is sent]
		/// </summary>
		BillingInfo BillingDetails { get; }
	}
}