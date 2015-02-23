namespace Cadmium.Commerce.Helpers.Tests
{
	using System;

	using NUnit.Framework;

	[TestFixture]
	public class CreditCardHelperTest
	{
		[Test]
		public void AreCorrectBrands()
		{
			// AMEX: 342955624318368
			// Discover: 6011624665174125
			// MasterCard: 5120939736834980
			// Visa: 4116509050569147

			Assert.AreEqual(CreditCardBrand.AmericanExpress,	CreditCardHelper.GetBrand("342955624318368"));
			Assert.AreEqual(CreditCardBrand.Discover,			CreditCardHelper.GetBrand("6011624665174125"));
			Assert.AreEqual(CreditCardBrand.MasterCard,			CreditCardHelper.GetBrand("5120939736834980"));
			Assert.AreEqual(CreditCardBrand.Visa,				CreditCardHelper.GetBrand("4116509050569147"));

			// Some made up invalid credit card numbers
			Assert.AreEqual(CreditCardBrand.Unknown,			CreditCardHelper.GetBrand("9116509050569147"));
		}
	}
}