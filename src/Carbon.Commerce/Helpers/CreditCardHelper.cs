namespace Carbon.Commerce
{
	using System;
	using System.Linq;
	using System.Text.RegularExpressions;

	public static class CreditCardHelper
	{
		private readonly static string[] TestNumbers = { 
			"378282246310005", "371449635398431", "378734493671000", "30569309025904", 
			"38520000023237", "6011111111111117", "6011000990139424", "5555555555554444", 
			"5105105105105100", "4111111111111111", "4012888888881881", "4222222222222" 
		};

		public static bool IsTestNumber(string number)
		{
			return TestNumbers.Any(n => n == number);
		}

		public static CreditCardType GetType(string number)
		{
			if (string.IsNullOrEmpty(number))					return CreditCardType.Unknown;

			// American Express (34 or 37 -- 15 length)
			if (Regex.IsMatch(number, "^(34|37)"))				return CreditCardType.AmericanExpress;

			// MasterCard (51 through 55 -- 16 length)
			if (Regex.IsMatch(number, "^(51|52|53|54|55)"))		return CreditCardType.MasterCard;

			// Visa (4 -- 13 and 16 length)
			if (Regex.IsMatch(number, "^(4)")) 					return CreditCardType.Visa;

			// Discover (6011, 16 length)
			if (Regex.IsMatch(number, "^(6011)"))				return CreditCardType.Discover;
		
			return CreditCardType.Unknown;
		}
	}
}
