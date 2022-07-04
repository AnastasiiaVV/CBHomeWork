using System;

namespace HomeWork_Essential_15_2
{
	class Program
	{
		static void Main(string[] args) {
			Price[] prices = new Price[5] {
				new Price("товар1", "АТБ", 20.3),
				new Price("товар2", "Мега", 19),
				new Price("товар3", "АТБ", 20.5),
				new Price("товар4", "Мега", 25),
				new Price("товар5", "АТБ", 100),
			};
			//Price[] prices = new Price[2];
			//for (int i = 0; i < 2; ++i) {
			//	string name, shop;
			//	double price;
			//	Console.WriteLine("Введите название товара:");
			//	name = Console.ReadLine();
			//	Console.WriteLine("Введите название магазина:");
			//	shop = Convert.ToInt32(Console.ReadLine());
			//	Console.WriteLine("Введите цену товара:");
			//	price = Console.ReadLine();
			//	prices[i] = new Price(name, shop, price);
			//}
			Array.Sort(prices, (x, y) => {
				return x.Shop.CompareTo(y.Shop);
			});

			Console.WriteLine("Введите название магазина для поиска товаров:");
			string ShopFind = Console.ReadLine();
			bool flag = false;
			foreach (var item in prices) {
				if (item.Shop == ShopFind) {
					Console.WriteLine(item);
					flag = true;
				} 
			}

			if (!flag) {
				throw new Exception("Такого магазина нет!");
			}
		}

	}
}
