using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_1_2
{
	public class Author
	{
		private string _author;
		public Author(string author) {
			_author = author;
		}

		public void Show() {
			var colorOld = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(_author);
			Console.ForegroundColor = colorOld;
		}

	}
}
