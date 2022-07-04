using System;
using System.Collections.Generic;

namespace HomeWork_Professional_1_2
{
	class Program
	{
		static void Main(string[] args) {
			Console.WriteLine("Категории граждан: 1 - студент, 2 - рабочий, 3 - пенсионер.");
			CitizenCollection citizenCollection = new CitizenCollection();
			citizenCollection.Add(new Citizen("Ivanov", 20, 12345, 1));
			citizenCollection.Add(new Citizen("Sidorov", 25, 22345, 2));
			citizenCollection.Add(new Citizen("Petrov", 55, 32345, 3));
			citizenCollection.Add(new Citizen("Ivanova", 20, 42345, 1));
			citizenCollection.Add(new Citizen("Sidorova", 25, 52345, 2));
			citizenCollection.Add(new Citizen("Petrova", 55, 23451, 3));

			foreach (Citizen item in citizenCollection) {
				Console.WriteLine($"{item.Name} {item.Age} лет, номер паспорта: {item.Passport}, категория: {item.Category}");
			}

			Console.WriteLine();
			citizenCollection.Add(new Citizen("Petrova", 55, 23451, 3));

			Console.WriteLine("Смотрим кто последний в очереди:");
			var citizen = citizenCollection.ReturnLast();
			Console.WriteLine($"{citizen.Name}, категория: {citizen.Category}");

			Console.WriteLine("Введите данные для поиска:");
			Console.WriteLine("Фамилия:");
			string name = Console.ReadLine();
			Console.WriteLine("Возраст:");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Номер паспорта:");
			int passport = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Номер категории");
			int category = Convert.ToInt32(Console.ReadLine());
			var citizen2 = new Citizen(name, age, passport, category);
			int index = -1;
			bool result = citizenCollection.Contains(citizen2, out index);

			if (result) {
				Console.WriteLine($"Номер в очереди: {index}");
			} else {
				Console.WriteLine("Такого гражданина нет!");
			}

			Console.WriteLine("Удаляем первого из очереди!");
			citizenCollection.Delete();

			Console.WriteLine("Очищаем очередь!");
			citizenCollection.Clear();



		}


	}
}
