using System;

namespace HomeWork_Essential_9_2
{
	class Program
	{
		delegate int ArifmeticAction(int a, int b);
		delegate int ArifmeticActions(ArifmeticAction[] actions);
		static void Main(string[] args) {
			ArifmeticAction add = (int a, int b) => {
				Console.WriteLine($"Результат сложения числа {a} с числом {b} равен { a + b }");
				return a * b;
			};
			ArifmeticAction sub = (int a, int b) => {
				Console.WriteLine($"Результат вычитания из числа {a} числа {b} равен { a - b }");
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

			var arifmeticActions = new ArifmeticAction[] {
				add,
				sub,
				mul,
				div
			};

			Console.WriteLine("Введите первое число:");
			var a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите второе число:");
			var b = int.Parse(Console.ReadLine());

			ArifmeticActions arifmeticActionDelegate = delegate (ArifmeticAction[] actions) {
				int accum = 0;
				foreach (var action in actions) {
					accum += action(a, b);
				}
				return accum / actions.Length;
			};
			try {
				var rezult = arifmeticActionDelegate(arifmeticActions);
				Console.WriteLine($"Среднее арифметическое: {rezult}");
			} catch(DivideByZeroException e) {
				Console.WriteLine("На ноль делить нельзя!");
			}

		}
	}
}
