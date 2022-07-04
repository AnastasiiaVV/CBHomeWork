using System;

namespace HomeWork_Essential_3
{
	class Program
	{
		static void Main(string[] args) {
			{
				var printer = new BluePrinter();
				printer.Print("test");
				printer.PrintA("test A");
			}

			{
				var printer = new GreenPrinter();
				printer.Print("test");
				printer.PrintA("test B");
			}

			{
				var printer = new Printer();
				printer.Print("test");
				printer.PrintA("test C");
			} 

		}
	}
}
