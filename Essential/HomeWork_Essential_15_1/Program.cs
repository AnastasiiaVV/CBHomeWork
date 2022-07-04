using System;

namespace HomeWork_Essential_15_1
{
	class Program
	{
		static void Main(string[] args) {

			Worker[] workers = new Worker[5] {
				new Worker("Ivanov Ivan", "engineer", 2010),
				new Worker("Petrov Petro", "designer", 1900),
				new Worker("Sidorov Stepan", "hr", 2015),
				new Worker("Ivanova Lena", "designer", 2025),
				new Worker("Petrova Maria", "ingener", 2020),
			};
			//Worker[] workers = new Worker[5];
			//for (int i = 0; i < 5; ++i) {
			//	string name, position;
			//	int year;
			//	Console.WriteLine("Введите ФИО сотрудника:");
			//	name = Console.ReadLine();
			//	Console.WriteLine("Введите год поступления на работу:");
			//	year = Convert.ToInt32(Console.ReadLine());
			//	Console.WriteLine("Введите название занимаемой должности:");
			//	position = Console.ReadLine();
			//	workers[i] = new Worker(name, position, year);
			//}
			Array.Sort(workers, (x,y) => {
				return x.Name.CompareTo(y.Name);
			});

			Console.Write("Введите необходимый стаж: ");
			int experience = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Сотрудники с необходимым стажем: ");
			foreach (var worker in workers) {
				try {
					if (worker.GetExperience() >= experience) {
//						Console.WriteLine(worker.GetExperience());
						Console.WriteLine(worker.Name);
					}
				} catch (FormatException e) {
					Console.WriteLine(e.Message);
				}
			}
		}

	}
}
