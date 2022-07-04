using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_7_1
{
	static class TrainExtention
	{

		public static void AddTrain(ref Train[] trains, Train train) {
			Array.Resize(ref trains, trains.Length + 1);
			trains[trains.Length - 1] = train;
		}

		public static Train FindTrain(this Train[] trains, int number) {
			return Array.Find(trains, t => t.Number == number);
		}

		public static void SortTrain(this Train[] trains) {
			Array.Sort(trains, (t1, t2) => {
				if (t1.Number > t2.Number) {
					return 1;
				} else if (t1.Number == t2.Number) {
					return 0;
				} 
				return -1;
			});
		}

	}
}
