using System;
using System.Linq;

namespace HomeWork_9
{
	class Program
	{
		static void Main(string[] args) {

			int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			for (int i = 9; i >= 0; i--){

				Console.Write(array[i]+ " ");
			}
			Console.ReadKey();
		}
	}
}
