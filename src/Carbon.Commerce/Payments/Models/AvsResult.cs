namespace Carbon.Commerce
{
	/// <summary>
	/// Address verification service result
	/// </summary>
	public enum AvsResult
	{
		Unknown = 0,

		/// <summary>
		/// No Address Supplied
		/// </summary>
		NoAddressSupplied = 1,

		/// <summary>
		/// Address only (no ZIP) 
		/// </summary>
		A = 2,

		/// <summary>
		/// International “A” Address only (no ZIP) 
		/// </summary>
		B = 3,

		/// <summary>
		/// International “N” None 
		/// </summary>
		C = 4,

		/// <summary>
		/// International “X” Address and Postal Code
		/// </summary>
		D = 5,

		/// <summary>
		/// Not allowed for MOTO (Internet/Phone) transactions Not applicable 
		/// </summary>
		E = 6,

		/// <summary>
		/// UK-specific “X” Address and Postal Code 
		/// </summary>
		F = 7,

		/// <summary>
		/// Global Unavailable or Not applicable 
		/// </summary>
		G = 8,

		/// <summary>
		/// International Unavailable or Not applicable 
		/// </summary>
		I = 9,

		/// <summary>
		/// No None 
		/// NOTE:Most merchants decline the transaction if there is no match
		/// </summary>
		NoMatch = 10,

		/// <summary>
		/// Name only
		/// </summary>
		NameOnly = 11,

		/// <summary>
		/// Postal (International “Z”) Postal Code only (no Address) 
		/// </summary>
		P = 12,

		/// <summary>
		/// Retry Not applicable 
		/// </summary>
		R = 13,

		/// <summary>
		/// Service not Supported Not applicable 
		/// </summary>
		ServiceNotSupported = 14,

		/// <summary>
		/// Unavailable Not applicable
		/// </summary>
		Unavailable = 15,

		/// <summary>
		/// Whole ZIP Nine-digit ZIP code (no Address) 
		/// </summary>
		W = 16,

		/// <summary>
		/// Exact match Address and nine-digit ZIP code 
		/// </summary>
		ExactMatch = 17,

		/// <summary>
		/// Yes Address and five-digit ZIP
		/// </summary>
		Y = 18,

		/// <summary>
		/// ZIP Five-digit ZIP code (no Address) 
		/// </summary>
		Z = 19,

		IncorrectNameBillingMatch = 20,

		NotPerformed = 21,
		
		Error = 30
	}
}
