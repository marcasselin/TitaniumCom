namespace Carbon.Commerce
{
	public interface ISalesLine
	{
		int Id { get; }

		LineItemType Type { get; set; }

		string Description { get; }

		int Quantity { get; set; }

		/// <summary>
		/// e.g. 1 Month, 1 Gram, 1 Unit
		/// </summary>
		// UnitType UnitType { get; }

		decimal UnitPrice { get; }

		/// <summary>
		/// The total of the line (Unit Price * Quantity)
		/// </summary>
		// decimal ExtendedPrice { get; }

		// Reference the invoice?

		// May optionally reference a product
	}
}