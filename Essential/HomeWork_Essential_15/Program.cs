using System;

namespace HomeWork_Essential_15
{
	class Program
	{
		static void Main(string[] args) {
			Console.Write("Введите первое число: ");
			double oper1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите второе число: ");
			double oper2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите операцию: ");
			string operation = Console.ReadLine();
			double result = 0;
			Calculator calculator = new Calculator();
			if (operation == "+") {
				result = calculator.Add(oper1, oper2);
				Console.WriteLine($"{oper1} + {oper2} = {result}");
			} else if (operation == "-") {
				result = calculator.Sub(oper1, oper2);
				Console.WriteLine($"{oper1} - {oper2} = {result}");
			} else if (operation == "*") {
				result = calculator.Mul(oper1, oper2);
				Console.WriteLine($"{oper1} * {oper2} = {result}");
			} else if (operation == "/") {
				result = calculator.Div(oper1, oper2);
				Console.WriteLine($"{oper1} / {oper2} = {result}");
			} else {
				throw new Exception();
			}

		}
	}
}
