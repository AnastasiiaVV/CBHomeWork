using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_7
{
	struct Notebook
	{
		string _model;
		string _manufacturer;
		double _price;

		public Notebook(string model, string manufacturer, double price) {
			_manufacturer = manufacturer;
			_model = model;
			_price = price;
		}

		public void Print() {
			Console.WriteLine($"Модель - {_model}");
			Console.WriteLine($"Производитель - {_manufacturer}");
			Console.WriteLine($"Цена - {_price}");
		}


	}
}
