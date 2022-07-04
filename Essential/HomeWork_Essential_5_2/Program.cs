using System;

namespace HomeWork_Essential_5_2
{
	class Program
	{
		static void Main(string[] args) {
			var articles = new Article[] {
				new Article("книга", "Книжный", 100),
				new Article("ручка", "Концелярия", 2),
				new Article("лампа", "Эпицентр", 800),
				new Article("стул", "Эпицентр", 1999),
				new Article("стол", "Эпицентр", 2999),
				new Article("комод", "Икея", 999),
				new Article("кровать", "Икея", 5999),
				new Article("часы", "Икея", 199),
				new Article("коврик прикроватный", "Икея", 299),
				new Article("тетрадь", "Концелярия", 5),
				new Article("картина", "Эпицентр", 600)
			};

			Console.WriteLine("Введите название товара:");
			var name = Console.ReadLine();
			var store = new Store(articles);
			var result = store[name];
			if (result != null) {
				result.Print();
			}

			Console.WriteLine($"Введите порядковый номер товара(не более {articles.Length}): "); 
			var index = Convert.ToInt32(Console.ReadLine());
			result = store[index];
			if (result != null) {
				result.Print();
			}

		}
	}
}
