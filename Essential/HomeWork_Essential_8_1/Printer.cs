using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
	static class Printer
	{

		private static ConsoleColor GetConsoleColor(ConsoleTextColor color) {
			return color switch {
				ConsoleTextColor.Blue => ConsoleColor.Blue,
				ConsoleTextColor.Gray => ConsoleColor.Gray,
				ConsoleTextColor.Green => ConsoleColor.Green,
				ConsoleTextColor.Red => ConsoleColor.Red,
				ConsoleTextColor.Yellow => ConsoleColor.Yellow,
				_ => ConsoleColor.White,
			};
		}

		public static void Print(string stroka, ConsoleTextColor color){
			var oldColor = Console.ForegroundColor;
			Console.ForegroundColor = GetConsoleColor(color);
			Console.WriteLine(stroka);
			Console.ForegroundColor = oldColor;
		}

	}
}
