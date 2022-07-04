using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_2_3
{
	class Invoice {
		private readonly int _account;
		private readonly string _customer;
		private readonly string _provader;

		public int Account { get { return _account; } }
		public string Customer { get { return _customer; } }
		public string Provader { get { return _provader; } }

		public Invoice(int account, string customer, string provader) {
			_account = account;
			_customer = customer;
			_provader = provader;
		}

		public double Bill(Order order) {

			return order.CalculateAmount();
		}

		public double BillFromVAT(Order order) {
			return order.CalculateAmount() * 1.2;
		}

	}
}
