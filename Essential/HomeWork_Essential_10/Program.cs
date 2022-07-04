using System;

namespace HomeWork_Essential_10
{
	class Program
	{
		static void Main(string[] args) {

			Console.WriteLine(MyClass<int>.FactoryMethod());
			Console.WriteLine(MyClass<DivideByZeroException>.FactoryMethod());
			Console.WriteLine(MyClass<bool>.FactoryMethod());
		}
	}
}
