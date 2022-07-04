using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_1
{
	class GoodPupil : Pupil
	{
		public GoodPupil(string lastName, string firstName) : base(lastName, firstName) { }

		public override void Study() {
			Console.WriteLine($"Я - {LastName} {FirstName}, учусь хорошо.");
		}
		public override void Read() {
			Console.WriteLine($"Я - {LastName} {FirstName}, читаю хорошо.");
		}
		public override void Write() {
			Console.WriteLine($"Я - {LastName} {FirstName}, пишу хорошо.");
		}
		public override void Relax() {
			Console.WriteLine($"Я - {LastName} {FirstName}, отдыхаю нормально.");
		}
	}
}
