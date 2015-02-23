namespace Carbon.Commerce
{
	public interface ICurrency
	{
		decimal Value { get; }

		CurrencyCode Code { get; }
	}
}