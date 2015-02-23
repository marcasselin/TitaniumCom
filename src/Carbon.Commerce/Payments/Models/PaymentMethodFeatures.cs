namespace Carbon.Commerce
{
	using System;

	[Flags]
	public enum PaymentMethodFeatures
	{
		Unknown = 0,

		/// <summary>
		/// One time payment (i.e. Check)
		/// </summary>
		SingleUse = 1,

		/// <summary>
		/// On demand (i.e. a billing aggreement or credit card)
		/// </summary>
		MultiUse = 2,

		/// <summary>
		/// Automatic
		/// </summary>
		Recurring = 4

		// Unrestricted
	}
}