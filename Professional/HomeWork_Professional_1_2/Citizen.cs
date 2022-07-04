using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Professional_1_2
{
	class Citizen
	{
		public string Name;
		public int Age;
		public int Passport;
		public int Category;


		public Citizen(string name, int age, int passport, int category) {
			Name = name;
			Age = age;
			Passport = passport;
			Category = category;

		}

		public override bool Equals(object obj) {
			Citizen citizen = obj as Citizen;
			if (citizen.Passport == this.Passport) {
				return true;
			} else {
				return false;
			}

		}

	}
}
