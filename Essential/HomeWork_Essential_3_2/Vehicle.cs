using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_2
{
	class Vehicle {
		protected string Сoordinates;
		protected double Price;
		protected int Speed;
		protected int Year;
		protected int NumberPassengers;

		protected Vehicle(string coordinates, double price, int speed, int year, int numberPassengers) {
			Сoordinates = coordinates;
			Price = price;
			Speed = speed;
			Year = year;
			NumberPassengers = numberPassengers;		
		}

		public virtual void Print() {
			Console.Write($"Местоположение - {Сoordinates}, цена - {Price}$, скорость - {Speed} км/ч," +
			$" год выпуска - {Year} г., кол-во пассажиров - {NumberPassengers}, ");
		
		}
	}
}
