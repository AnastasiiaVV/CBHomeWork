using System;

namespace HomeWork_Essential_16
{
	class Program
	{
		static void Main(string[] args) {
			Point a = new Point(3, 4, 5);
			Point b = new Point(1, 2, 3);
			var c = a + b;
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
		}
	}
}
