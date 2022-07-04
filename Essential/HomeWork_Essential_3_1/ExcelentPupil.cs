using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_3_1
{
	class ExcelentPupil : Pupil 
	{
		public ExcelentPupil(string lastName, string firstName) : base(lastName, firstName) { }

		public override void Study() {
			Console.WriteLine($"Я - {LastName} {FirstName}, учусь отлично.");
		}
		public override void Read() {
			Console.WriteLine($"Я - {LastName} {FirstName}, читаю отлично.");
		}
		public override void Write() {
			Console.WriteLine($"Я - {LastName} {FirstName}, пишу отлично.");
		}
		public override void Relax() {
			Console.WriteLine($"Я - {LastName} {FirstName}, отдыхаю мало.");
		}
	}
}
