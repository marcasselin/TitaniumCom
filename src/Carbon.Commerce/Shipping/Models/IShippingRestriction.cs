namespace Carbon.Commerce
{
	public interface IShippingRestriction
	{
		string Description { get; }

		bool Check(IPackage package);
	}
}

/* Examples: 
 - Up to 70 pounds (MaxWeight)
 - No more than 108 inches in combined length and girth. (MaxDimensions)
 - Cannot contain advertising. (ContentRestrictions)
*/