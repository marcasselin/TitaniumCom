namespace Carbon.Commerce
{
	using Carbon.Models;

	public class BillingInfo
	{
		public string Name { get; set; }

		public string CompanyName { get; set; }

		public string PhoneNumber { get; set; }

		public string EmailAddress { get; set; }

		public string IpAddress { get; set; }

		public IAddress Address { get; set; }
	}
}