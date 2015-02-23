namespace Carbon.Commerce
{
	public enum PackageStatus
	{
		Unknown = 0,

		Processing = 1,

		Packed = 2, /* Awaiting pickup */
		
		Shipped = 3,
		
		Delivered = 4,
		
		Exception = 5
	}
}