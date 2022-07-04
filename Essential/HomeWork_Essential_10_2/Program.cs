using System;

namespace HomeWork_Essential_10_2
{
	class Program
	{
		static void Main(string[] args) {
			var myDictionary = new MyDictionary<string, string>();

			myDictionary.Add("книга", "book");
			myDictionary.Add("кошка","cat");
			myDictionary.Add("собака", "dog");
			myDictionary.Add("лето", "summer");
			myDictionary.Add("мама", "mother");

			int length = myDictionary.Length;
			Console.WriteLine($"Количество элементов: {length}");

			var value = myDictionary[3];
			Console.WriteLine($"Третий элемент: {value}");
		}
	}
}
