using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_5_2
{
	class Article
	{
        private string _name;
        private string _magazine;
        private int _price;
        public string Name {
            get { return _name; }
        }

        public Article(string name, string magazine, int price) {
            _name = name;
            _magazine = magazine;
            _price = price;
        }

        public void Print() {
            Console.WriteLine($"Название товара - {_name}, магазин - {_magazine}, цена: {_price}, грн");
        }

    }
}
