using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_15
{
	class Calculator
	{
		public double Add(double oper1, double oper2) {
			return oper1 + oper2;
		}

		public double Sub(double oper1, double oper2) {
			return oper1 - oper2;
		}

		public double Mul(double oper1, double oper2) {
			return oper1 * oper2;
		}

		public double Div(double oper1, double oper2) {
			if (oper2 == 0) {
				throw new DivideByZeroException();
			} else {
				return oper1 / oper2;
			}
		}

	}
}
