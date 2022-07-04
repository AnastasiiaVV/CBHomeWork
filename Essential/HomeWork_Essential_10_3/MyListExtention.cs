using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_10_3
{
	static class MyListExtention
	{
		public static T[] GetArray<T>(this MyList<T> list) {
			T[] array = new T[list.Count];
			for (int i = 0; i < list.Count; i++) {
				array[i] = list[i];
			}
			return array;

		}

	}
}
