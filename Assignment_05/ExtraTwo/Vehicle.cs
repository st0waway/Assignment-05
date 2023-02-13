namespace Assignment_05.ExtraTwo
{
	class Vehicle
	{
		public decimal Price { get; set; }
		public double TopSpeed { get; set; }
		public int YearManufactured { get; set; }

		public Vehicle(decimal price, double topSpeed, int yearManufactured)
		{
			Price = price;
			TopSpeed = topSpeed;
			YearManufactured = yearManufactured;
		}
	}
}
