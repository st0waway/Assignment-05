namespace Assignment_05.ExtraTwo;

class Plane : Vehicle
{
	public double MaxHeight { get; set; }
	public int MaxPassengers { get; set; }

	public Plane(decimal price, double topSpeed, int yearManufactured, double maxHeight, int maxPassengers) :base(price, topSpeed, yearManufactured)
	{
		MaxHeight = maxHeight;
		MaxPassengers = maxPassengers;
	}
}