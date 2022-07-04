using System;

namespace HomeWork_Essential_3_1
{
	class Program
	{
		static void Main(string[] args) {
			var badPupil = new BadPupil("Иванов", "Иван");
			var goodPupil = new GoodPupil("Петров", "Петр");
			var excelentPupil = new ExcelentPupil("Сидоров", "Вася");
			var goodPupil2 = new GoodPupil("Васичкина","Лена");

			var classroom = new Classroom(badPupil, goodPupil2, excelentPupil);

			classroom.AddPupil(goodPupil);
			Console.WriteLine("Класс учись:");
			classroom.Study();
			Console.WriteLine("Класс читай:");
			classroom.Read();
			Console.WriteLine("Класс пиши:");
			classroom.Write();
			Console.WriteLine("Класс отдыхай:");
			classroom.Relax();
		}
	}
}
