using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3
{
	class Printer 
	{
		public virtual ConsoleColor Color { get; protected set; } = ConsoleColor.Red;

		public virtual void Print(string value) {
			Console.ForegroundColor = ConsoleColor.Red;
			InternalPrint(value);
		}

		public virtual void PrintA(string value) {
			Console.ForegroundColor = Color;
			InternalPrint(value);
		}

		private void InternalPrint(string value){
			Console.WriteLine(value);
		}
	}
}
