using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3
{
	class GreenPrinter : Printer
	{
		public override ConsoleColor Color { get; protected set; } = ConsoleColor.Green;

		public override void Print(string value) {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(value);
		}

		public override void PrintA(string value) {
			base.PrintA(value);
		}

	}
}
