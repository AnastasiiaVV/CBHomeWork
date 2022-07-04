using System;

namespace HomeWork_Essential_14_3
{
	class Program
	{
		static void Main(string[] args) {
			var myList = new MyList<int>();
			myList.Add(2);
			myList.Add(4);
			myList.Add(8);
			myList.Add(16);
			myList.Add(32);
			myList.Add(64);

			Console.WriteLine($"Количество элементов в списке: { myList.Count}");

			Console.WriteLine($"Третий элемент списка {myList[2]}");
			Console.WriteLine($"Массив из списка:");
			var array = myList.GetArray();
			foreach (var item in array) {
				Console.Write($"{item} ");
			}

		}
	}
}
