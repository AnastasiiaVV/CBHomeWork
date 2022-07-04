using System;

namespace HomeWork_Essential_11_3
{
	class Program
	{
		static void Main(string[] args) {
			var arrayList = new ArrayList();
			arrayList.Add("Зима");
			arrayList.Add("Весна");
			arrayList.Add("Лето");
			arrayList.Add("Осень");

			for (int i = 0; i < arrayList.Count; i++) {
				Console.WriteLine(arrayList[i]);
			}

			arrayList.Crear();
			Console.WriteLine("Список пуст!");

		}
	}
}
