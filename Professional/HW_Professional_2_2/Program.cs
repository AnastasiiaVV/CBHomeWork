using System;
using System.Collections.Generic;


namespace HW_Professional_2_2
{
	class Program
	{
		static void Main(string[] args) {
			Dictionary<int, double> method1 = new Dictionary<int, double>();

			method1.Add(123, 1234.123);
			method1.Add(234, 234.123);
			method1.Add(1234, 6545.123);
			Console.WriteLine("Метод 1:");
			foreach (var item in method1) {
				Console.WriteLine($"Номер счета: {item.Key}, доступная сумма: {item.Value}");
			}

			SortedDictionary<int, double> method2 = new SortedDictionary<int, double>();
			method2.Add(123, 1234.123);
			method2.Add(234, 234.123);
			method2.Add(1234, 6545.123);
			Console.WriteLine("Метод 2:");
			foreach (var item in method1) {
				Console.WriteLine($"Номер счета: {item.Key}, доступная сумма: {item.Value}");
			}

		}
	}
}
