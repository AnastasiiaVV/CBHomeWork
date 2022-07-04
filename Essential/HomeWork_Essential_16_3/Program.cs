using System;

namespace HomeWork_Essential_16_3
{
	class Program
	{
		static void Main(string[] args) {
			DateTime date = new DateTime(2021, 08, 20);
			Date date1 = new Date(DateTime.Today);
			Date date2 = new Date(date);

			var date3 = date1 + 10;
			var count = date2 - date1;

			Console.WriteLine($"{date1} + 10 = {date3.ToString("d.m.yyyy")}");
			Console.WriteLine($"{date2} - {date1} = {count} дней");

		}
	}
}
