using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Professional_1_1
{
	class Month
	{
		public string Name { get; set; }
		public int Days { get; set; }

		public int Number { get; set; }

		public Month(string name, int days, int number) {
			Name = name;
			Days = days;
			Number = number;
		}
	}
}
