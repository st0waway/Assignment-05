using Microsoft.VisualBasic.CompilerServices;

namespace Assignment_05.ExtraTwo;

class Ship : Vehicle
{
	public int MaxPassengers { get; set; }
	public string Dock { get; set; }

	public Ship(decimal price, double topSpeed, int yearManufactured, int maxPassengers, string dock) : base(
		price, topSpeed, yearManufactured)
	{
		MaxPassengers = maxPassengers;
		Dock = dock;
	}
}