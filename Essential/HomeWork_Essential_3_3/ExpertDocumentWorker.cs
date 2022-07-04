using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_3
{
	class ExpertDocumentWorker:ProDocumentWorker
	{
		public override void SaveDocument() {
			Console.WriteLine("Документ сохранен в новом формате");
		}
	}
}
