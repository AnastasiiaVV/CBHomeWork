using System;

namespace HomeWork_Essential_9
{
	class Program
	{
		delegate int Average(int a, int b, int c);
		static void Main(string[] args) {
			Console.WriteLine("Введите первое число:");
			var a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите второе число:");
			var b = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите третье число:");
			var c = int.Parse(Console.ReadLine());

			Average average = (int a, int b, int c) => (a + b + c) / 3;

			//Average average = delegate (int a, int b, int c) {
			//	return (a + b + c) / 3;
			//};

			var rezult = average(a,b,c);


			Console.WriteLine($"Среднее арифметическое заданных чисел равно: {rezult}");

		}
	}
}
