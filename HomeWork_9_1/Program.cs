using System;

namespace HomeWork_9_1
{
	class Program
	{
		static void Main(string[] args) {
			Console.Write("Введите размер массива: ");
			int size = Convert.ToInt32(Console.ReadLine());
			double[] array1 = RandArray(size);
			PrintArray(array1);
			double[] array2 = new double[size];
			double max = double.MinValue;
			double min = double.MaxValue;
			double sum = 0;
			double srArifm = 0;
			int k = 0;

			for (int i = 0; i < size; i++) {

				if (array1[i] > max) {
					max = array1[i];
				}
				if (array1[i]< min) {
					min = array1[i];
				}

				sum += array1[i];
				srArifm = sum/size;

				double ost = array1[i] % 2; 
				if (ost == 1) {
					array2[k] = array1[i];
					k++;
				}
			}
			Console.WriteLine($"Максимальный элемент массива равен: {max}");
			Console.WriteLine($"Минимальный элемент массива равен: {min}");
			Console.WriteLine($"Сумма всех элементов массива равна: {sum}");
			Console.WriteLine($"Среднее арифметическое всех чисел массива равно: {srArifm}");
			Console.WriteLine("Массив из нечетных чисел:");
			PrintArray(array2);
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
