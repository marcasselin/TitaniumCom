namespace Carbon.Commerce
{
	public enum OrderState
	{
		Unknown = 0,
		
		Draft = 1,
		
		Open = 2,
		
		Processing = 3, // i.e. picking or packing

		Completed = 4,

		Canceled = 5,
		
		Voided = 6
	}
}