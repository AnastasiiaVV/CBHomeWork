using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_2
{
	class Plane : Vehicle
	{
		private int _hight;
		public Plane(string coordinates, double price, int speed, int year, int numberPassengers, int hight) 
			: base(coordinates, price, speed, year, numberPassengers) {
			_hight = hight;
		}

		public override void Print() {
			Console.WriteLine("Самолет:");
			base.Print();
			Console.WriteLine($"высота - {_hight} м.");
		}

	}
}
