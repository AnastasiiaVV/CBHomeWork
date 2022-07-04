using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace HW_Professional_2_3
{
	class Program
	{
		static void Main(string[] args) {
			OrderedDictionaryComparer Comparer = new OrderedDictionaryComparer();
			OrderedDictionary myDictionary = new OrderedDictionary(Comparer);
			myDictionary.Add(111, "один");
			myDictionary.Add(222, "два");
			myDictionary.Add(333, "три");
			myDictionary.Add(444, "четыре");
			myDictionary.Add(555, "пять");

			OrderedDictionary myDictionary2 = new OrderedDictionary(Comparer);
			myDictionary2.Add(111, "один");
			myDictionary2.Add(555, "пять");
			myDictionary2.Add(666, "шесть");

			foreach (var item in myDictionary) {
				foreach (var item1 in myDictionary2) {
					Console.WriteLine(item.Equals(item1).ToString());
				}

			}
		}
	}
}
