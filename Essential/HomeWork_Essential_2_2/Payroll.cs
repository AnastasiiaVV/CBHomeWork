using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_2_2
{
	class Payroll
	{
		public double CalculateSalary(Employee employee) {
			if (employee.Experience <= 5) {
				return employee.Position.Salary * 1.3;
			} else if (employee.Experience <= 10) {
				return employee.Position.Salary * 1.6;
			} else return employee.Position.Salary * 1.8;
		}

		public double CalculateTax(Employee employee) {
			return CalculateSalary(employee) * 0.18;
		}
	}
}
