using System;

namespace HomeWork_Essential_5_1
{
	class Program
	{
		static void Main(string[] args) {
			Console.Write("Введите размер массива: ");
			int size = Convert.ToInt32(Console.ReadLine());
			double[] array = RandArray(size);
			PrintArray(array);
			Calculator calculator = new Calculator();
			Console.Write("Максимальный элемент массива равен: ");
			Console.WriteLine(calculator.GetMaxElement(array));
			Console.Write("Минимальный элемент массива равен: ");
			Console.WriteLine(calculator.GetMinElement(array));
			Console.Write("Сумма всех элементов массива равна: ");
			Console.WriteLine(calculator.GetSumElements(array));
			Console.Write("Среднее арифметическое всех чисел массива равно: ");
			Console.WriteLine(calculator.GetSrArifmetical(array));
			Console.WriteLine("Массив из нечетных чисел:");
			PrintArray(calculator.GetNotEvenElements(array));
		}

		static double[] RandArray(int size) {

			double[] array = new double[size];
			Random rand = new Random();
			for (int i = 0; i < size; ++i)
				array[i] = rand.Next(0, 100);
			return array;
		}

		static void PrintArray(double[] array) {
			foreach (double x in array) {
				Console.Write(x + "  ");
			}
			Console.WriteLine();
		}

	}
}
