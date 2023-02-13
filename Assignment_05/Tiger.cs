namespace Assignment_05
{
	internal class Tiger : BigCat
	{
		private string StripePattern { get; set; }
		public Tiger(double weight, double height, string birthday, string roarSound, string stripePattern) : base(weight, height, birthday, roarSound)
		{
			StripePattern = stripePattern;
		}

		public override void Bite()
		{
			Console.WriteLine("tiger bite");
		}
	}
}
