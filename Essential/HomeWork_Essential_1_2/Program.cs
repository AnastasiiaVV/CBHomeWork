using System;

namespace HomeWork_Essential_1_2
{
	class Program
	{
		static void Main(string[] args) {

			var book = new Book();
			Console.Write("Введите название книги: ");
			string title = Console.ReadLine();
			book.SetTitle(title);
			Console.Write("Введите автора книги: ");
			string author = Console.ReadLine();
			book.SetAuthor(author);
			Console.Write("Введите содержание книги: ");
			string content = Console.ReadLine();
			book.SetContent(content);

			book.Author.Show();
			book.Title.Show();
			book.Content.Show();
		}
	}
}
