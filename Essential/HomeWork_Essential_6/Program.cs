using System;

namespace HomeWork_Essential_6
{
	class Program
	{
		static void Main(string[] args) {
			Console.WriteLine("Введите первое число:");
			int term1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите второе число:");
			int term2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Результаты арифметических операций:");
			double add = Caculator.Add(term1, term2);
			Console.WriteLine($"{term1} + {term2} = {add}");
			double sub = Caculator.Sub(term1, term2);
			Console.WriteLine($"{term1} - {term2} = {sub}");
			double mul = Caculator.Mul(term1, term2);
			Console.WriteLine($"{term1} * {term2} = {mul}");

			try {
				double div = Caculator.Div(term1, term2);
				Console.WriteLine($"{term1} / {term2} = {div}");
			} catch (DivideByZeroException e) {
				Console.WriteLine("На ноль делить нельзя!");
			}
		}
	}
}
