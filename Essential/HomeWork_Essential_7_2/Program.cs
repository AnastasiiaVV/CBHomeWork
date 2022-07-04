using System;

namespace HomeWork_Essential_7_2
{
	class Program
	{
		static void Main(string[] args) {
			MyClass myClass = new MyClass();
			MyStruct myStruct = new MyStruct();
			myClass.Change = "Не Изменено";
			myStruct.Change = "Не Изменено";
			ClassTaker(myClass);
			StructTaker(myStruct);
			Console.WriteLine($"{myClass.Change}");
			Console.WriteLine($"{myStruct.Change}");
		}

		static void ClassTaker(MyClass myClass) {
			myClass.Change = "Изменено";
		}

		static void StructTaker(MyStruct myStruct) {
			myStruct.Change = "Изменено";
		}

	}
}
