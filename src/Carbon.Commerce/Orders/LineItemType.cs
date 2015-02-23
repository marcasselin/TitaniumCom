namespace Carbon.Commerce
{
	public enum LineItemType
	{
		Unknown = 0,

		/// <summary>
		/// Product or Service 
		/// </summary>
		Sale = 1,

		// Line Adjustments
		Discount = 3,
		
		Freight = 4,
		
		Handling = 5,

		Taxes = 9
	}
}