using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace HomeWork_professional_2
{
	class Program
	{
		static void Main(string[] args) {
			SortedList<string, string> myList = new SortedList<string, string>();

			myList.Add("ключ","key");
			myList.Add("собака", "dog");
			myList.Add("кошка", "cat");
			myList.Add("птица", "bird");
			myList.Add("божья коровка", "Ladybug");

			ICollection<string> keys = myList.Keys;

			foreach (string s in keys)
				Console.WriteLine($"Key: {s}, Value: {myList[s]}");

			Console.WriteLine("Обратное: ");
			//var myList1 = myList.Reverse().ToDictionary(x => x.Key, y => y.Value);

			//ICollection<string> keys1 = myList1.Keys;

			//foreach (string s in keys1)
			//	Console.WriteLine($"Key: {s}, Value: {myList[s]}");

			SortedList myList1 = new SortedList(myList, new StringComparer());
			foreach (string s in myList1.Keys)
				Console.WriteLine($"Key: {s}, Value: {myList[s]}");
		}
	}

	public class StringComparer : IComparer
	{
		public int Compare(object x, object y) {
			var first = x as string;
			var second = y as string;
			if (first.CompareTo(second) < 0) {
				return 1;
			} else if (first.CompareTo(second) > 0) {
				return -1;
			} else {
				return 0;
			}

		}
	}
}
