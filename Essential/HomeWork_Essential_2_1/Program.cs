using System;

namespace HomeWork_Essential_2_1
{
	class Program
	{
		static void Main(string[] args) {
			try {
				Converter convert = new Converter(28, 30, 0.3);
				Console.WriteLine("Введите сумму: ");
				int sum = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("В какой валюте сумма (0 - USD; 1 - EUR; 2 - RUB; 3 - UAN)");
				string currencyIn = Console.ReadLine();
				Console.WriteLine("В какую валюту конвертируем (0 - USD; 1 - EUR; 2 - RUB; 3 - UAN)");
				string currencyOut = Console.ReadLine();

				Enum.TryParse(currencyIn, out Currency enumCurrencyIn);
				Enum.TryParse(currencyOut, out Currency enumCurrencyOut);
				
				var result = convert.CurrencyExchange(sum, enumCurrencyIn, enumCurrencyOut);
				Console.WriteLine($"Converted {sum} {enumCurrencyIn} to {result} {enumCurrencyOut}");

			} catch (ArgumentException e) {
				Console.WriteLine(e.Message);
			}

		}
	}
}
