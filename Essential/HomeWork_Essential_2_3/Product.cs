using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_2_3
{
	class Product
	{
		private string _article;
		private double _price;

		public string Article { get { return _article; } }
		public double Price { get { return _price; } }

		public Product(string article, double price) {
			_article = article;
			_price = price;
		}

	}
}
