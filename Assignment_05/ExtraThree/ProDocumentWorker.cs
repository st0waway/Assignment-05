namespace Assignment_05.ExtraThree
{
	public class ProDocumentWorker : DocumentWorker
	{
		private string Key { get; set; }

		public ProDocumentWorker(string key)
		{
			Key = key;
		}

		public override void EditDocument()
		{
			Console.WriteLine("Document was edited");
		}

		public override void SaveDocument()
		{
			Console.WriteLine("The document was saved in an old format. Get the expert version to save in other formats");
		}
	}
}
