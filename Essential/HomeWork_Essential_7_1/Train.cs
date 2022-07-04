using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_7_1
{
	struct Train
	{
		string _city;
		DateTime _date;

		public int Number { get; set; }

		public Train (string city, int number, DateTime date) {
			_city = city;
			Number = number;
			_date = date;
		}

		public void Print() {
			Console.WriteLine($"Пункт назначения - {_city}, номер поезда - {Number}, время отправки: {_date}");
		}
	}
}
