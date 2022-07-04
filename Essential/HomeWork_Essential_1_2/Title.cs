using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_1_2
{
	public class Title
	{
		private string _title;
		public Title(string title) {
			_title = title;
		}

		public void Show() {
			var colorOld = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(_title);
			Console.ForegroundColor = colorOld;
		}
	}
}
