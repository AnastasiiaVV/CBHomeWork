using System;
using System.Collections.Generic;

namespace HomeWork_Essential_6_1
{
	class Program
	{
		static void Main(string[] args) {
			var list = new List<string>() {
				"Хорошая сегодня погода",
				"На выходных поедем на рыбалку",
				"Сегодня мы будем печь пирог",
				"Будем праздновать День рождения на выходных"
			};
			foreach (var i in list) {
				Console.WriteLine(i);
			}

			Console.WriteLine("");
			Book book = new Book(list);
			Console.WriteLine("Введите слово по которому будет выполняться поиск:");
			string word = Console.ReadLine();
			Console.WriteLine("Результат:");

			var listRezult = book.FindNext(word);
			if (listRezult.Count == 0) {
				Console.WriteLine("Такого слова нет в тексте!");
			} else {
				foreach (var j in listRezult) {
					Console.WriteLine(j);
				}
			}

			Console.WriteLine("Оставьте свой комментарий");
			var comment = Console.ReadLine();
			book.MyNotes.AddNotes(comment);
			Console.WriteLine("Комментарий сохранен:");
			foreach (var k in book.MyNotes.BookNotes) {
				Console.WriteLine(k);
			}
		}
	}
}
