namespace Carbon.Commerce.Tests
{
	using NUnit.Framework;

	[TestFixture]
	public class PaymentProcessorTests
	{
		[Test]
		public void IntMappings()
		{
			Assert.AreEqual(30,		(int)PaymentProcessorType.Braintree);
			Assert.AreEqual(100,	(int)PaymentProcessorType.Paymentech);
			Assert.AreEqual(120,	(int)PaymentProcessorType.Paypal);
		}
	}
}