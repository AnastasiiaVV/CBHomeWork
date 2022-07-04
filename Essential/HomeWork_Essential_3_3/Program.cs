using System;

namespace HomeWork_Essential_3_3
{
	class Program
	{
		static void Main(string[] args) {
			Console.WriteLine("Введите номер ключа:");
			Console.WriteLine("Подсказка: 1 - про, 2 - єксперт, иначе пробный");
			int key = Convert.ToInt32(Console.ReadLine());
			DocumentWorkerFactory documentWorkerFactory = new DocumentWorkerFactory();
			var documetWorker = documentWorkerFactory.GetDocumentWorker(key);
			documetWorker.OpenDocument();
			documetWorker.EditDocument();
			documetWorker.SaveDocument();
			}
	}
}
