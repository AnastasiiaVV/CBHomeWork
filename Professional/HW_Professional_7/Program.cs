using System;

namespace HW_Professional_7
{
	class Program
	{
		static void Main(string[] args) {
			Employer[] employer = new Employer[] { new Manager(), new Programmer(), new Director() };
			foreach (var item in employer) {
				GetAccess(item);
			}
		}

		static void GetAccess(Employer employer) {
			Type type = employer.GetType();
			object[] attribute = type.GetCustomAttributes(typeof(AccessLevelAttribute), false);

			if (attribute.Length == 0) {
				return;
			}

			foreach (AccessLevelAttribute item in attribute) {
				Console.WriteLine($"Должность: {type.Name, -12}, уровень доступа: {item.AccessLevel}");
			}
		
		}
	}
}
