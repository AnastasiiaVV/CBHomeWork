using System;

namespace HomeWork_Essential_9_1
{
	class Program
	{
		delegate int ArifmeticAction(int a, int b);
		static void Main(string[] args) {
			ArifmeticAction add = (int a, int b) => {
				Console.WriteLine($"Результат сложения числа {a} с числом {b} равен { a + b }");
				return a * b;
			};
			ArifmeticAction sub = (int a, int b) => {
				Console.WriteLine($"Результат выичтания из числа {a} числа {b} равен { a - b }");
				return a * b;
			};
			ArifmeticAction mul = (int a, int b) => {
				Console.WriteLine($"Результат умножения числа {a} на число {b} равен { a * b }");
				return a * b;
			};
			ArifmeticAction div = (int a, int b) => {
				if (b == 0) {
					throw new DivideByZeroException();
				} else {
					Console.WriteLine($"Результат деления числа {a} на число {b} равен { a / b }");
					return a / b;
				}
			};

			Console.WriteLine("Введите первое число:");
			var a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите второе число:");
			var b = int.Parse(Console.ReadLine());

			add(a, b);
			sub(a, b);
			mul(a, b);
			div(a, b);

		}
	}
}
