using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_2_2
{
	class Employee
	{

		private string _firstName;
		private string _lastName;
		private int _experience;
		private Position _position;


		public int Experience { get { return _experience; } }
		public Position Position { get { return _position; } }

		public string FirstName { get { return _firstName; } }
		public string LastName { get { return _lastName; } }
		public Employee(string firstName, string lastName) {
			_firstName = firstName;
			_lastName = lastName;
		}

		public Employee(string firstName, string lastName, int experience, Position position): this(firstName, lastName) {
			_experience = experience;
			_position = position;
		}

	}
}
