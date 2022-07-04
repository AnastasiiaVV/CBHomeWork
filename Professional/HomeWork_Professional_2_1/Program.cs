using System;
using System.Collections.Generic;

namespace HomeWork_Professional_2_1
{
	class Program
	{
		static void Main(string[] args) {
			Dictionary<Сustomer, List<Category>> myCollection = new Dictionary<Сustomer, List<Category>>();

			myCollection.Add(new Сustomer("Ivanov"), new List<Category> { Category.chemistry, Category.office });
			myCollection.Add(new Сustomer("Petrov"), new List<Category> { Category.other});
			myCollection.Add(new Сustomer("Sidorov"), new List<Category> { Category.chemistry});
			myCollection.Add(new Сustomer("Ivanova"), new List<Category> { Category.office });
			myCollection.Add(new Сustomer("Petrova"), new List<Category> { Category.other });
			myCollection.Add(new Сustomer("Sidorova"), new List<Category> { Category.chemistry, Category.office, Category.other });

			foreach (KeyValuePair<Сustomer, List<Category>> item in myCollection) {
				Console.Write(item.Key.Name + ": ");
				foreach (var category in item.Value) {
					Console.Write($"{category}; ") ;
				}
				Console.WriteLine();
			}

			Console.WriteLine("Выберите категорию товаров: 1 - office, 2 - chemistry, 3 - other");
			int a = Convert.ToInt32(Console.ReadLine());
			var b = Category.other;
			if (a == 1) {
				b = Category.office;
			} else if (a == 2) {
				b = Category.chemistry;
			} else {
				b = Category.other;
			}
			Console.WriteLine($"Покупатели купившие товары категории {b}:");
			var result  = GetEmployyByCategory(myCollection, b);
			foreach (var item in result) {
				Console.WriteLine(item.Name);
			}

			Console.ReadKey();

			static List<Сustomer> GetEmployyByCategory(Dictionary<Сustomer, List<Category>> myCollection, Category category) {
				List<Сustomer> customer = new List<Сustomer>();
				foreach (var item in myCollection) {
					if (item.Value.Contains(category)) {
						customer.Add(item.Key);
					}
				}
				return customer;
			}

		}
	}
}
