using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_1_2
{
	public class Content
	{
		private string _content;
		public Content(string content) {
			_content = content;
		}

		public void Show() {
			var colorOld = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(_content);
			Console.ForegroundColor = colorOld;
		}

	}
}
