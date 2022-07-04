using System;

namespace HomeWork_Essential_3_2
{
	class Program
	{
		static void Main(string[] args) {
			var car = new Car("Киев",5000, 200, 2009, 5, 1.9);
			var plane = new Plane("Киев", 15000, 300, 2015, 10, 5);
			var ship = new Ship("Одесса", 10000, 150, 2020, 10, "Vesta");

			car.Print();
			plane.Print();
			ship.Print();
		}
	}
}
