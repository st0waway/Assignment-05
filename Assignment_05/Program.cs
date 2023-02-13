using Assignment_05.ExtraOne;

namespace Assignment_05
{
	internal class Program
	{
		static void Main(string[] args)
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

			var classRoom = new ClassRoom(new Pupil(), new ExcellentPupil(), new GoodPupil(), new BadPupil());

			classRoom.PupilOne.Read();
			classRoom.PupilOne.Relax();
			classRoom.PupilOne.Study();
			classRoom.PupilOne.Write();
			classRoom.PupilTwo.Read();
			classRoom.PupilTwo.Relax();
			classRoom.PupilTwo.Study();
			classRoom.PupilTwo.Write();
			classRoom.PupilThree.Read();
			classRoom.PupilThree.Relax();
			classRoom.PupilThree.Study();
			classRoom.PupilThree.Write();
			classRoom.PupilFour.Read();
			classRoom.PupilFour.Relax();
			classRoom.PupilFour.Study();
			classRoom.PupilFour.Write();
		}
	}
}