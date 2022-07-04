using System;
using System.Text.RegularExpressions;

namespace HW_Professional_4
{
	class Program
	{
		static void Main(string[] args) {
			string petLogin = @"^[A-Za-z]+$";
			string petPassword = @"^[A-Za-z0-9\S]+$";

			Console.Write("Введите логин: ");
			string login = Console.ReadLine();

			if (!Regex.IsMatch(login, petLogin)){
				Console.WriteLine("Логин должен состоять только из букв латинского алфавита!");
				return;
			}

			Console.Write("Введите пароль: ");
			string password = Console.ReadLine();

			if (!Regex.IsMatch(password, petPassword)){
				Console.WriteLine("Пароль должен состоять из цифр и символов!");
				return;
			}

			Console.Write("Регистрация прошла успешно!");
			Console.ReadKey();
		}
	}
}
