namespace Carbon.Commerce.Tests
{
	using NUnit.Framework;

	[TestFixture]
	public class CreditCardTests
	{
		[Test]
		public void TestIds()
		{
			Assert.AreEqual(1, (int)CreditCardType.AmericanExpress);
			Assert.AreEqual(2, (int)CreditCardType.Discover);
			Assert.AreEqual(3, (int)CreditCardType.MasterCard);
			Assert.AreEqual(4, (int)CreditCardType.Visa);
		}

		[Test]
		public void GetTypeTests()
		{
			Assert.AreEqual(CreditCardType.AmericanExpress, CreditCardHelper.GetType("378282246310005"));
			Assert.AreEqual(CreditCardType.AmericanExpress, CreditCardHelper.GetType("371449635398431"));
			Assert.AreEqual(CreditCardType.AmericanExpress, CreditCardHelper.GetType("378734493671000"));

			Assert.AreEqual(CreditCardType.Discover, CreditCardHelper.GetType("6011111111111117"));
			Assert.AreEqual(CreditCardType.Discover, CreditCardHelper.GetType("6011000990139424"));

			Assert.AreEqual(CreditCardType.MasterCard, CreditCardHelper.GetType("5555555555554444"));

			Assert.AreEqual(CreditCardType.Visa, CreditCardHelper.GetType("4111111111111111"));
			Assert.AreEqual(CreditCardType.Visa, CreditCardHelper.GetType("4012888888881881"));
			Assert.AreEqual(CreditCardType.Visa, CreditCardHelper.GetType("4222222222222"));
		}
	}
}