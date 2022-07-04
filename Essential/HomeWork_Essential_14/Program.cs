using System;
using System.Collections.Generic;

namespace HomeWork_Essential_14
{
	class Program
	{
		static void Main(string[] args) {
			int[] massiv = new int[] { 2, 5, 8, 9, 11, 45, 33, 4, 7 };
			var result = GetMassiv(massiv);

			foreach (var item in result) {
				Console.Write($"{item} ");
			}
		}

		private static IEnumerable<int> GetMassiv(int[] massiv) {
			foreach (var item in massiv) {
				if (item % 2 == 0) {
					yield return item;
				}
			}
		}

	}
}
