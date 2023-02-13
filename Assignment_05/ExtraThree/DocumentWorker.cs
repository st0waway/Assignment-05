namespace Assignment_05.ExtraThree
{
	public class DocumentWorker
	{
		public DocumentWorker()
		{

		}
		public void OpenDocument()
		{
			Console.WriteLine("The document is open");
		}

		public virtual void EditDocument()
		{
			Console.WriteLine("Editing is available in Pro version");
		}

		public virtual void SaveDocument()
		{
			Console.WriteLine("Savinf is available in Pro version");
		}
	}
}
