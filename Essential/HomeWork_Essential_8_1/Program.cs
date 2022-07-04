using System;

namespace Task2
{
	class Program
	{

		private static ConsoleTextColor GetConsoleTextColor(string colorChar) {
			return colorChar switch {
				"b" => ConsoleTextColor.Blue,
				"a" => ConsoleTextColor.Gray,
				"g" => ConsoleTextColor.Green,
				"r" => ConsoleTextColor.Red,
				"y" => ConsoleTextColor.Yellow,
				_ => ConsoleTextColor.White
			};
		}

		static void Main(string[] args) {
			Console.WriteLine("Введите текст.");
			var stroka = Console.ReadLine();
			Console.WriteLine("Введите символ для выбора цвета:\n 'b' - синий, 'a' - серый, 'g' - зеленый , 'r' - красный, 'y' - желтый, 'w' - белый.");
			var colorChar = Console.ReadLine();
			Printer.Print(stroka, GetConsoleTextColor(colorChar));
		}

		
	}
}
