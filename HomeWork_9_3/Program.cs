using System;

namespace HomeWork_9_3
{
	class Program
	{
		static void Main(string[] args) {
			int[] array = new int[] {1, 2, 3, 4, 5, 6 };
			Console.WriteLine("Исходный массив:");
			PrintArray(array);
			int[] arrayMethod1 = Method1(array);
			Console.WriteLine("Результирующий массив по методу 1:");
			PrintArray(arrayMethod1);
			int value = 15;
			int[] arrayMethod2 = Method2(array, value);
			Console.WriteLine("Результирующий массив по методу 2:");
			PrintArray(arrayMethod2);
		}

		static int[] Method1(int[] array) {
			int[] resultArray = new int[array.Length+1];
			for (int i = 0; i < array.Length; i++) {
				resultArray[i] = array[i];
			}
			return resultArray;
		}

		static void PrintArray(int[] array) {
			foreach (int x in array) {
				Console.Write(x + "  ");
			}
			Console.WriteLine();
		}

		static int[] Method2(int[] array, int value) {
			int[] resultArray = new int[array.Length + 1];
			resultArray[0] = value;
			for (int i = 0; i < array.Length; i++) {
				resultArray[i + 1] = array[i];
			}
			return resultArray;
		}

	}
}
