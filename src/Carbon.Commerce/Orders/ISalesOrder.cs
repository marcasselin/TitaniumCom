namespace Carbon.Commerce
{
	public interface ISalesOrder : IOrder
	{
		// One or more line items. 
		// - Ajustment Line (Discount, credits, etc)
		// - Goods (Product or service)
	}
}