using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_11_1
{
	class CarCollection<T> where T: Car
	{
		private List<T> _carCollection;

		public CarCollection() {
			_carCollection = new List<T>();
		}


		public void AddCar(string name, int year) {
			var car = new Car(name, year);
			_carCollection.Add((T)car);
		}

		public int Count { get { return _carCollection.Count; } }

		public T this[int index] {
			get { return _carCollection[index]; }
		}

		public void Delete() {
			_carCollection.Clear();
		}

	}
}
