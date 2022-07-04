using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_1
{
	class BadPupil : Pupil
	{
		public BadPupil(string lastName, string firstName) : base(lastName, firstName) { }

		public override void Study() {
			Console.WriteLine($"Я - {LastName} {FirstName}, учусь плохо.");
		}
		public override void Read() {
			Console.WriteLine($"Я - {LastName} {FirstName}, читаю плохо.");
		}
		public override void Write() {
			Console.WriteLine($"Я - {LastName} {FirstName}, пишу плохо.");
		}
		public override void Relax() {
			Console.WriteLine($"Я - {LastName} {FirstName}, отдыхаю хорошо.");
		}

	}
}
