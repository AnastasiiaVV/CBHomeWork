using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
	class Account
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Customer> Customers { get; set; } = new List<Customer>();
		public List<Product> Products { get; set; } = new List<Product>();

	}
}
