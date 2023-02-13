using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05.ExtraThree
{
	public class ExpertDocumentWorker : ProDocumentWorker
	{
		public ExpertDocumentWorker(string key) : base(key) { }
		public override void SaveDocument()
		{
			Console.WriteLine("The document was saved in the new format");
		}
	}
}
