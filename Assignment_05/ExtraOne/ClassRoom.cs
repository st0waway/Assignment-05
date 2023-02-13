namespace Assignment_05.ExtraOne
{
	public class ClassRoom
	{
		public Pupil PupilOne { get; set; }
		public Pupil PupilTwo { get; set; }
		public Pupil? PupilThree { get; set; }
		public Pupil? PupilFour { get; set; }
		public ClassRoom(Pupil pupilOne, Pupil pupilTwo, Pupil pupilThree, Pupil pupilFour)
		{
			this.PupilOne = pupilOne;
			this.PupilTwo = pupilTwo;
			this.PupilThree = pupilThree;
			this.PupilFour = pupilFour;
		}

		public ClassRoom(Pupil pupilOne, Pupil pupilTwo, Pupil pupilThree)
		{
			this.PupilOne = pupilOne;
			this.PupilTwo = pupilTwo;
			this.PupilThree = pupilThree;
		}

		public ClassRoom(Pupil pupilOne, Pupil pupilTwo)
		{
			this.PupilOne = pupilOne;
			this.PupilTwo = pupilTwo;
		}
	}
}
