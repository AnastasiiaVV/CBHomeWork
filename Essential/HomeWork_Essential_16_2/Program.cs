using System;
using System.Collections.Generic;

namespace HomeWork_Essential_16_2
{
	class Program
	{
		static void Main(string[] args) {
			Flat flat1 = new Flat(1, 2, 3);
			Flat flat2 = new Flat(2, 3, 3);
			Flat flat3 = new Flat(3, 4, 3);
			Flat flat4 = new Flat(4, 5, 3);
			Flat flat5 = new Flat(5, 6, 3);
			House house = new House("House", 10, new List<Flat> {flat1, flat2, flat3, flat4, flat5});
			var houseClone = house.Clone();
			var houseDeepClone = house.DeepClone();

			if (!Object.ReferenceEquals(house.Storey, houseClone.Storey)) {
				Console.WriteLine("House.Storey(int) & HouseClone.Storey(int) - копирование по значению");
			}
			if (Object.ReferenceEquals(house.Flats, houseClone.Flats)) {
				Console.WriteLine("House.Flats & HouseClone.Flats - Clone");
			}
			if (Object.ReferenceEquals(house.Flats[0], houseClone.Flats[0])) {
				Console.WriteLine("House.Flat[0] & HouseClone.Flat[0] - Clone");
			}



			if (!Object.ReferenceEquals(house.Storey, houseDeepClone.Storey)) {
				Console.WriteLine("House.Storey(int) & HouseDeepClone.Storey(int) - копирование по значению");
			}
			if (!Object.ReferenceEquals(house.Flats, houseDeepClone.Flats)) {
				Console.WriteLine("House.Flats & HouseDeepClone.Flats - DeepClone");
			}
			if (!Object.ReferenceEquals(house.Flats[0], houseDeepClone.Flats[0])) {
				Console.WriteLine("House.Flat[0] & HouseDeepClone.Flat[0] - DeepClone");
			}

		}
	}
}
