using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
	class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Account> Accounts { get; set; } = new List<Account>();

	}
}
