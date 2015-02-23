namespace Carbon.Commerce.Tests
{
	using System;

	using NUnit.Framework;

	[TestFixture]
	public class CurrencyTests
	{
		/*
		[Test]
		public void BasicTest()
		{
			var currency = new Currency(5, CurrencyCode.USD);

			Assert.AreEqual(5.0d, currency.Value);
			Assert.AreEqual(CurrencyCode.USD, currency.Code);
		}
		*/

		[Test]
		public void IsoNumberTests()
		{
			Assert.AreEqual(32, (int)CurrencyCode.ARS);
			Assert.AreEqual(752, (int)CurrencyCode.SEK);
			Assert.AreEqual(840, (int)CurrencyCode.USD);
		}
	}
}