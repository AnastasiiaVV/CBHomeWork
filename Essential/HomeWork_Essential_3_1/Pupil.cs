using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_1
{
	class Pupil
	{
		protected string LastName;
		protected string FirstName;

		protected Pupil(string lastName, string firstName) {
			LastName = lastName;
			FirstName = firstName;
		}

		public virtual void Study() { }
		public virtual void Read() { }
		public virtual void Write() { }
		public virtual void Relax() { }

	}
}
