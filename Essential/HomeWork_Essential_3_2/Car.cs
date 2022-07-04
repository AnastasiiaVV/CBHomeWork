using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_2
{
	class Car : Vehicle
	{
		private double _engineVolume;

		public Car(string coordinates, double price, int speed, int year, int numberPassengers, double engineVolume ) 
			: base(coordinates, price, speed, year, numberPassengers) {
			_engineVolume = engineVolume;
		}

		public override void Print() {
			Console.WriteLine("Машина:");
			base.Print();
			Console.WriteLine($"объем двигателя - {_engineVolume} л.");
		}
	}
}
