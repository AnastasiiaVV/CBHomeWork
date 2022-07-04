using System;

namespace HomeWork_Essential_6_2
{
	class Program
	{
		static void Main(string[] args) {
			var array = new int[] { 1, 10, 3, 6, 5, 7, 12, 2};
			Console.WriteLine("Исходный массив:");
			foreach (var item in array) {
				Console.Write($"{item} ");
			}
			Console.WriteLine("\nРезультирующий массив:");
			array.ArraySort();
			foreach (var item in array) {
				Console.Write($"{item} ");
			}
		}
	}
}
