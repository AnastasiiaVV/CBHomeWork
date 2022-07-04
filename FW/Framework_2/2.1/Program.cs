using System;

namespace _2._1
{
	class Program
	{
		static void Main(string[] args) {
			using (ContextApp db = new ContextApp()) {
				Account account1 = new Account() {Name = "Account1" };
				Account account2 = new Account() {Name = "Account2" };
				db.Accounts.Add(account1);
				db.Accounts.Add(account2);
				Customer customer1 = new Customer() { Name = "Customer1" };
				Customer customer2 = new Customer() { Name = "Customer2" };

				db.Customers.Add(customer1);
				db.Customers.Add(customer2);
				Product product1 = new Product() { Name = "Product1"};
				Product product2 = new Product() { Name = "Product2" };
				db.Products.Add(product1);
				db.Products.Add(product2);
				db.SaveChanges();

				account1.Customers.Add(customer1);
				customer2.Accounts.Add(account2);

				account1.Products.Add(product2);
				account1.Products.Add(product1);

				db.SaveChanges();

				foreach (Account item in db.Accounts) {
					Console.WriteLine(item.Id + "\t" + item.Name);
				}
				Console.WriteLine();
				Console.WriteLine(new string('*', 50));

				foreach (Customer item in db.Customers) {
					Console.WriteLine(item.Id + "\t" + item.Name);
				}
				Console.WriteLine();
				Console.WriteLine(new string('*', 50));

				foreach (Product item in db.Products) {
					Console.WriteLine(item.Id + "\t" + item.Name);
				}
			}

			Console.ReadKey();
		}
	}
}
