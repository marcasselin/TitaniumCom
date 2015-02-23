namespace Carbon.Commerce.Services
{
	using System;
	using System.Linq;

	using Carbon.Helpers;

	public class PaymentProcessorFactory
	{
		private readonly IPaymentProcessor[] processors;

		public PaymentProcessorFactory(IPaymentProcessor[] processors)
		{
			this.processors = processors;
		}

		public IPaymentProcessor[] Processors
		{
			get { return processors; }
		}

		public IPaymentProcessor Get(IPaymentMethod paymentMethod)
		{
			#region Preconditions

			if (paymentMethod == null) throw new ArgumentNullException("paymentMethod");

			#endregion

			var processor = processors.FirstOrDefault(p => p.Accepts(paymentMethod));

			if (processor == null)
			{
				throw new Exception("No registered processors accept '{0}'.".FormatWith(paymentMethod.GetType().ToString()));
			}

			return processor;
		}
	}
}