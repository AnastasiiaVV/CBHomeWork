
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_15_2
{
	struct Price {
		private string _name;
		private double _price;

		public string Shop { get; set; }

		public Price(string name, string shop, double price) {
			_name = name;
			Shop = shop;
			_price = price;
		}

		public override string ToString() {
			return _name + " " + _price;
		}
	}

}
