namespace Carbon.Commerce
{
	public class ShippingQuote
	{
		public IShippingMethod ShippingMethod { get; set; }
		
		// BasePrice + Surcharge
		public decimal Price { get; set; }

		public DateRange DeliveryWindow { get; set; }
	}
}