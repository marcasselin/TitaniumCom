namespace Carbon.Commerce
{
	using Carbon.Models;

	public interface IPackage
	{
		IAddress Origin { get; }

		IAddress Destination { get; }

		IDimensions Dimensions { get; }

		Weight Weight { get; }
	}

	public interface IDimensions
	{
		IMeasurement<double> Length { get; }

		IMeasurement<double> Height { get; }
		
		IMeasurement<double> Width { get; }
	}
}