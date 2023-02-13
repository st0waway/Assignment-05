namespace Assignment_05.ExtraOne;

public class BadPupil : Pupil
{
	public BadPupil()
	{

	}
	public override void Study()
	{
		Console.WriteLine("bad pupil study");
	}

	public override void Read()
	{
		Console.WriteLine("bad pupil read");
	}

	public override void Write()
	{
		Console.WriteLine("bad pupil write");
	}

	public override void Relax()
	{
		Console.WriteLine("bad pupil relax");
	}
}