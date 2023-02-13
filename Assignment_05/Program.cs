using Assignment_05.ExtraOne;

namespace Assignment_05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Animals();
			ClassRoom();
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

			var students = new Pupil[4] { new Pupil(), new ExcellentPupil(), new GoodPupil(), new BadPupil() };
			foreach (var student in students)
			{
				student.Read();
				student.Relax();
				student.Study();
				student.Write();
			}


		}
	}
}