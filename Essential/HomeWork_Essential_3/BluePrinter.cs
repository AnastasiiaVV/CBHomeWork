using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3
{
	class BluePrinter : GreenPrinter
	{
		public override ConsoleColor Color { get; protected set; } = ConsoleColor.Blue;

		public override void Print(string value) {
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(value);
		}

		public override void PrintA(string value) {
			base.PrintA(value);
		}
	}
}
