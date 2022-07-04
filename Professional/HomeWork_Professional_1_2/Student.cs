using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Professional_1_2
{
	class Student : Citizen
	{
		public Student(string name, int age, int passport, int category)
			: base(name, age, passport, category) { }
	}
}
