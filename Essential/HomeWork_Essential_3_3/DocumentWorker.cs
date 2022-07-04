using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_3
{
	class DocumentWorker
	{
		public void OpenDocument() {
			Console.WriteLine("Документ открыт");
		}
		public virtual void EditDocument() {
			Console.WriteLine("Редактирование документа доступно в версии Про");
		}
		public virtual void SaveDocument() {
			Console.WriteLine("Сохранение документа доступно в версии Про");
		}

	}
}
