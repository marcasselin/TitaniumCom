namespace Carbon.Commerce.Services
{
	using System.Threading.Tasks;

	public interface IShippingService
	{
		Task<ShippingQuote[]> GetQuotes(IPackage package); 
	}
}