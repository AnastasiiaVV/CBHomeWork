using System;

namespace HomeWork_Essential_11_1
{
	class Program
	{
		static void Main(string[] args) {
			var carCollection = new CarCollection<Car>();
			carCollection.AddCar("AUDI", 2010);
			carCollection.AddCar("BMW", 2010);
			carCollection.AddCar("NISSAN", 2010);
			carCollection.AddCar("KIA", 2010);

			var count = carCollection.Count;
			Console.WriteLine($"Машин {count}");
			var item = carCollection[3];
			Console.WriteLine($"Третья машина в парке {item.Name} {item.Year}");

			carCollection.Delete();

			Console.WriteLine("Список машин очищен!");

		}
	}
}
