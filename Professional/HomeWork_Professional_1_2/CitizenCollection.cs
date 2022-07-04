using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Professional_1_2
{
	class CitizenCollection : IEnumerable
	{
		public List<Citizen> collection = new List<Citizen>();

		public int Add(Citizen citizen) {

			int index1 = collection.FindIndex(x => x.Equals(citizen));
			if (index1 == -1) {
				if (citizen.Category != 3) {
					collection.Add(citizen);
					return collection.Count - 1;
				} else {
					int index = collection.FindLastIndex(x => x.Category == 3);
					if (index == -1) {
						collection.Insert(0, citizen);
						return 0;
					} else {
						collection.Insert(index + 1, citizen);
						return index + 1;
					}
				}

			} else {
				Console.WriteLine("Гражданин с таким номером паспорта уже есть!");
				return index1;
			}

		}

		public void Delete() {
			collection.RemoveAt(0);
		}

		public void Delete(Citizen citizen) {
			collection.Remove(citizen);
		}

		public bool Contains(Citizen citizen, out int index) {
			index = collection.FindIndex(x => x.Equals(citizen));
			if (index == -1) {
				return false;
			} else {
				return true;
			}
		}

		public Citizen ReturnLast() {
			return collection.Last();
		}

		public void Clear() {
			collection.Clear();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			//В System.Array уже есть реализация IEnumerable! Делегируем вызов массиву.
			return collection.GetEnumerator();
		}

	}
}
