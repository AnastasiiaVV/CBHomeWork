using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_2_2
{
	class Position
	{

		private string _name;
		private double _salary;

		public string Name { get { return _name; } }
		public double Salary { get { return _salary; } }


		public Position(string name, double salary) {
			_name = name;
			_salary = salary;		
		}
	}
}
