using System;

namespace HomeWork_Essential_2
{
	class Program
	{
		static void Main(string[] args) {
			User user = new User("test", "Ivan", "Ivanov", 28, DateTime.Now);
			user.PrintUser();
		}
	}
}
