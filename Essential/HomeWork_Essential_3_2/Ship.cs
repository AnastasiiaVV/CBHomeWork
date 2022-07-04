using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_2
{
	class Ship : Vehicle
	{
		protected string _homePort;
		public Ship(string coordinates, double price, int speed, int year, int numberPassengers, string homePort) 
			: base(coordinates, price, speed, year, numberPassengers) {
			_homePort = homePort;
		}

		public override void Print() {
			Console.WriteLine("Корабль:");
			base.Print();
			Console.WriteLine($"порт приписки - {_homePort}.");
		}

	}
}
