using System;

namespace HomeWork_Essential_16_1
{
	class Program
	{
		static void Main(string[] args) {
			Block a = new Block(5, 6, 7, 8);
			Block b = new Block(5, 6, 7, 8);

			Console.WriteLine($"Блок {a}");
			Console.WriteLine($"Блок {b}");
			var result = a.Equals(b);
			if (result) {
				Console.WriteLine("Блоки равны");
			} else {
				Console.WriteLine("Блоки не равны");
			}
		}

	}
}
