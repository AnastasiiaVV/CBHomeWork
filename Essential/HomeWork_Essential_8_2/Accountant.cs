using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	class Accountant
	{
		public bool AskForBonus(Position worker, int hours) {
			var isBonus = hours >= (int)worker;
			Console.WriteLine($"Сотрудник с должностью {worker} {(isBonus ? string.Empty : "не ")}получит премию за {hours} проработанных часов.");
			return isBonus;
		}

	}
}
