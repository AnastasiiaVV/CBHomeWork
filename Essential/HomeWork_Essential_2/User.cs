using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_2
{
	class User
	{

		private string _login;
		private string _firstname;
		private string _lastname;
		private int _age;
		private DateTime _date;

		public User(string login, string firstname, string lastname, int age, DateTime date) {
			_login = login;
			_firstname = firstname;
			_lastname = lastname;
			_age = age;
			_date = date;
		}

		public void PrintUser() {
			Console.WriteLine($"Логин пользователя: {_login}");
			Console.WriteLine($"Имя: {_firstname}");
			Console.WriteLine($"Фамилия: {_lastname}");
			Console.WriteLine($"Возраст: {_age}");
			Console.WriteLine($"Дата заполнения анкеты: {_date}");
		}

	}
}
