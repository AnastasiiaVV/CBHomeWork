using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_12_2
{
	class Model
	{
		public string Result( object oper1, string oper2, string operation) {
			if (operation == "+") {
				return Convert.ToString(Convert.ToDouble(oper1) + Convert.ToDouble(oper2));
			} else if (operation == "-") {
				return Convert.ToString(Convert.ToDouble(oper1) - Convert.ToDouble(oper2));
			} else if (operation == "*") {
				return Convert.ToString(Convert.ToDouble(oper1) * Convert.ToDouble(oper2));
			} else if (operation == "/") {
				return Convert.ToString(Convert.ToDouble(oper1) / Convert.ToDouble(oper2));
			} else return "";

		}
	}
}
