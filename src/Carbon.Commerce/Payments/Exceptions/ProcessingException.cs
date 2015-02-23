namespace Carbon.Commerce
{
	using System;

	public class ProcessingException : Exception
	{
		public ProcessingException(string message)
			: base(message) { }
	}
}
