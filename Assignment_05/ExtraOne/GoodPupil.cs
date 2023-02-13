namespace Assignment_05.ExtraOne;

public class GoodPupil : Pupil
{
	public GoodPupil()
	{

	}
	public override void Study()
	{
		Console.WriteLine("good pupil study");
	}

	public override void Read()
	{
		Console.WriteLine("good pupil read");
	}

	public override void Write()
	{
		Console.WriteLine("good pupil write");
	}

	public override void Relax()
	{
		Console.WriteLine("good pupil relax");
	}
}