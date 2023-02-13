namespace Assignment_05
{
	internal class BigCat
	{
		private double Weight { get; set; }
		private double Height { get; set; }
		private string Birthday { get; set; }
		private string RoarSound { get; set; }

		public BigCat(double weight, double height, string birthday, string roarSound)
		{
			this.Weight = weight;
			this.Height = height;
			this.Birthday = birthday;
			this.RoarSound = roarSound;
		}

		public void Roar()
		{
			Console.WriteLine(RoarSound);
		}

		public void Roar(string roarSound)
		{
			this.RoarSound = roarSound;
			Console.WriteLine(this.RoarSound);
		}

		public virtual void Bite()
		{
			Console.WriteLine("big cat bite sound");
		}
	}
}
