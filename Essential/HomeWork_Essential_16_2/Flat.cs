using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_16_2
{
	class Flat
	{
		public int Number { get; set; }
		public int RoomCount { get; set; }
		public int Floor { get; set; }

		public Flat(int number, int roomCount, int floor) {
			Number = number;
			RoomCount = roomCount;
			Floor = floor;
		}
	}
}
