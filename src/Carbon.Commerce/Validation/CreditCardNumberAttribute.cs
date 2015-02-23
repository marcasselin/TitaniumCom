namespace Carbon.Validation
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;

	using Carbon.Commerce;
	using Carbon.Helpers;

	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class CreditCardNumberAttribute : ValidationAttribute
	{
		private readonly CreditCardType[] types;

		public CreditCardNumberAttribute(CreditCardType[] types) 
		{
			this.types = types;
		}

		public override bool IsValid(object value)
		{
			string text = value as string;

			if (String.IsNullOrEmpty(text)) return true;

			if (ValidationHelper.IsValidCreditCardNumber(text))
			{
				var brand = CreditCardHelper.GetType(text);

				return types.Any(b => b == brand);
			}

			return false;
		}
	}
}

// Consider Inherting from CreditCardAttribute