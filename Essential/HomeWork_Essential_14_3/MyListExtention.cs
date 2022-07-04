
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_14_3
{
	static class MyListExtention
	{
		public static T[] GetArray<T>(this IEnumerable<T> list) {
			//T[] array = new T[list.Count];
			//for (int i = 0; i < list.Count; i++) {
			//	array[i] = list[i];
			//}
			//return array;
			int count = 0;
			foreach (var item in list) {
				count++;
			}

			T[] array = new T[count];
			int i = 0;
			foreach (var item in list) {
				array[i] = item;
				i++;
			}
			return array;
		}

	}
}
