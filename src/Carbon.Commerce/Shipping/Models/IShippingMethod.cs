namespace Carbon.Commerce
{
	using System;
	using System.Collections.Generic;

	public interface IShippingMethod
	{
		ShippingCarrier Carrier { get; }

		string Name { get; }

		string Description { get; }

		IList<IShippingRestriction> Restrictions { get; }

		DateRange TransitWindow { get; }
	}
}

// - UPS ------------------------ 
// - Express Critical
// - Next Day Air Early A.M.
// - 2nd Day Air
// - 3 Day Select
// - Ground

// - USPS -----------------------
// - Priority Mail
// - First-Class Mail
// - Parcel Post