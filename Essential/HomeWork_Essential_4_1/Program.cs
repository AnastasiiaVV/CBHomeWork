using System;

namespace HomeWork_Essential_4_1
{
	class Program
	{
		static void Main(string[] args) {

			Console.WriteLine("Выберите формат файла:");
			Console.WriteLine("Подсказка DOC - 1, TXT - 2, XML - 3");
			int type = Convert.ToInt32(Console.ReadLine());
			try {
				var document = DocumentFactory.GetDocument(type);
				document.Create();
				document.Open();
				document.Chenge();
				document.Save();
			} catch(Exception e){
				Console.WriteLine(e.Message);
			}

		}
	}
}
