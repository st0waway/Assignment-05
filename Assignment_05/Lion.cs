namespace Assignment_05
{
	internal class Lion : BigCat
	{
		private double ManeLength { get; set; }
		public Lion(double weight, double height, string birthday, string roarSound, double maneLength) : base(weight, height, birthday, roarSound)
		{
			ManeLength = maneLength;
		}

		public override void Bite()
		{
			Console.WriteLine("lion bite");
		}
	}
}
