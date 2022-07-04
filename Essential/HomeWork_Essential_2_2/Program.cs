using System;

namespace HomeWork_Essential_2_2
{
	class Program
	{
		static void Main(string[] args) {
			Position position = new Position("engineer", 5000);
			Employee employee = new Employee("Ivan", "Ivanov", 6, position);
			Payroll payroll = new Payroll();
			var salary = payroll.CalculateSalary(employee);
			var tax = payroll.CalculateTax(employee);

			Console.WriteLine($"Имя: {employee.FirstName} Фамилия: {employee.LastName}");
			Console.WriteLine($"Должность: {employee.Position.Name} Стаж: {employee.Experience}");
			Console.WriteLine($"Зарплата: {salary} Налоговый сбор: {tax}");
		}
	}
}
