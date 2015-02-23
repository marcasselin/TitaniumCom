namespace Carbon.Commerce
{
	/// <summary>
	/// A common base for invoices and orders
	/// </summary>
	public interface ISalesDocument
	{
		string Id { get; }

		bool IsRecurring { get; }

		/// <summary>
		/// Used for a memo or comment
		/// </summary>
		string Description { get; }

		decimal Amount { get; }

		ISalesLine[] Lines { get; }

		IAccount Account { get; }
	}
}