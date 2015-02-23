namespace Carbon.Commerce
{
	public enum InvoiceStatus
	{	
		Open = 0,		// Open invoices are awaiting payment
		Closed = 1,		// Closed invoiced have been fully paid
		Draft = 3,		// A purchase order (or a document used to establish the intent to purchase something)
		Abandoned = 4,	// Adandoned invoices are closed (we give up trying to collect)
		Void = 5		// Void invoices are usually created in error
	}

	// TODO: Shift and add Unknown = 0

	// Unknown = 0
	// Draft = 1
	// Open = 2
	// Closed = 3
	// Abandoned = 4
	// Void = 5
}