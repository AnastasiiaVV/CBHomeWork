using System;

namespace HomeWork_Essential_11_2
{
	class Program
	{
		static void Main(string[] args) {
			var dictionary = new Dictionary<string, string>();

			dictionary.Add("книга", "book");
			dictionary.Add("кошка", "cat");
			dictionary.Add("собака", "dog");
			dictionary.Add("лето", "summer");
			dictionary.Add("мама", "mother");

			int length = dictionary.Count;
			Console.WriteLine($"Количество элементов: {length}");
			try {
				var key = "мама";
				var value = dictionary[key];
				Console.WriteLine($"Значение для ключа {key}: {value}");
				var value1 = dictionary["папа"];
			} catch (Exception e) {
				Console.WriteLine($"Нет такого значения.");
			}

		}
	}
}
