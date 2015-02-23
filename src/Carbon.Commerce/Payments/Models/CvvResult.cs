namespace Carbon.Commerce
{
	public enum CvvResult
	{
		Unknown = 0,

		Match = 1,
		NoMatch = 2,
		NotProcessed = 3,
		ServiceNotSupported = 4,
		Unavailable = 5, // Service unavailable
		NoResponse = 6,
		ShouldHaveBeenPresent = 7,
		Error = 20
	}
}