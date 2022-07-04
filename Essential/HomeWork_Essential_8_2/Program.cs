using System;

namespace Task3
{
	class Program
	{
		static void Main(string[] args) {

			Console.WriteLine("Введите кол-во проработанных часов сотрудником:");
			var hours = int.Parse(Console.ReadLine());
			var accountant = new Accountant();
			accountant.AskForBonus(Position.Assistant, hours);
			accountant.AskForBonus(Position.Trainer, hours);
			accountant.AskForBonus(Position.Engener, hours);
		}
	}
}
