using Assignment_05.ExtraOne;
using Assignment_05.ExtraThree;
using Assignment_05.ExtraTwo;

namespace Assignment_05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Animals();
			//ClassRoom();
			//Vehicles();
			Documents();
		}

		public static void Animals()
		{
			var bigCat = new BigCat(200, 100, "2.3.2009", "roar");
			var tiger = new Tiger(140, 80, "4.3.2015", "tiger roar", "long stripes");
			var lion = new Lion(160, 90, "4.6.2017", "lion roar", 100);

			var cats = new BigCat[3] { bigCat, tiger, lion };
			foreach (var cat in cats)
			{
				cat.Roar();
			}

			bigCat.Roar("special roar");

			foreach (var cat in cats)
			{
				cat.Bite();
			}
		}

		public static void ClassRoom()
		{
			var classRoom = new ClassRoom(new Pupil(), new ExcellentPupil(), new GoodPupil(), new BadPupil());
			var classRoomTwo = new ClassRoom(new Pupil(), new BadPupil());
			var classRoomThree = new ClassRoom(new Pupil(), new ExcellentPupil(), new GoodPupil());

			var students = new Pupil[4] { new(), new ExcellentPupil(), new GoodPupil(), new BadPupil() };
			foreach (var student in students)
			{
				student.Read();
				student.Relax();
				student.Study();
				student.Write();
			}
		}

		public static void Vehicles()
		{
			var car = new Car(30000, 240, 2018);
			var plane = new Plane(100000, 700, 1998, 700, 4);
			var ship = new Ship(500000, 200, 1980, 10, "sunny beach");

			Console.WriteLine($"type: {car.GetType()}, price: {car.Price}, top speed:{car.TopSpeed}, year manufactured:{car.YearManufactured}");
			Console.WriteLine($"type: {plane.GetType()}, price: {plane.Price}, top speed:{plane.TopSpeed}, year manufactured:{plane.YearManufactured}, max height: {plane.MaxHeight}, max passengers: {plane.MaxPassengers}");
			Console.WriteLine($"type: {ship.GetType()}, price: {ship.Price}, top speed:{ship.TopSpeed}, year manufactured:{ship.YearManufactured}, max passengers: {ship.MaxPassengers}, dock: {ship.Dock}" );
		}

		public static void Documents()
		{
			var standart = new DocumentWorker();
			Console.WriteLine("standart");
			standart.OpenDocument();
			standart.EditDocument();
			standart.SaveDocument();

			var pro = new ProDocumentWorker("prokey");
			Console.WriteLine("pro");
			pro.OpenDocument();
			pro.EditDocument();
			pro.SaveDocument();

			var expert = new ExpertDocumentWorker("expertkay");
			Console.WriteLine("expert");
			expert.OpenDocument();
			expert.EditDocument();
			expert.SaveDocument();
		}
	}
}