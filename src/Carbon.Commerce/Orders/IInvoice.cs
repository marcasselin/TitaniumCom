namespace Carbon.Commerce
{
	using System;

	/// <summary>
	/// A document issued by a seller to a buyer, indicating the products, quantities, and agreed
	/// prices for products or services with which the sellers has already provided to the buyer. 
	/// An invoice indicates that payment is due from the buyer to the seller according to the payment terms. 
	/// From the view point of the sller, an invoice is a sales invoice. From the viewpoint of the buyer,
	/// an invoice is a purchase invoice.
	/// </summary>
	public interface IInvoice : ISalesDocument
	{
		/// <summary>
		/// The date the invoice was issued/ sent to the reciever
		/// </summary>
		DateTime Issued { get; }

		// Payments (A list of payments applied to the invoice [Each having a monentary transaction])
		// An invoice can be paid with mutiple payment methods [e.g. two different credit cards]

		// Transactions (A listing of monentary transactions related to this invoice)
	}
}