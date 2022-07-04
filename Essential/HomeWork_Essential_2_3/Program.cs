using System;

namespace HomeWork_Essential_2_3
{
	class Program
	{
		static void Main(string[] args) {

			Product product1 = new Product("product1", 20);
			Product product2 = new Product("product2", 30);
			Product product3 = new Product("product3", 40);

			Position position1 = new Position(product1, 5);
			Position position2 = new Position(product2, 2);
			Position position3 = new Position(product3, 7);

			Order order = new Order(position1);
			order.AddPosition(position2);
			order.AddPosition(position3);

			Invoice invoice = new Invoice(123, "Nemo", "Nemo2");
			double bill = invoice.Bill(order);
			double billVAT = invoice.BillFromVAT(order);

			Console.WriteLine($"Номер заказа: {invoice.Account}, клиент: {invoice.Customer}, поставщик: {invoice.Provader}");
			order.PrintPositions();
			Console.WriteLine($"Сумма заказа без НДС = {bill}");
			Console.WriteLine($"Сумма заказа с НДС = {billVAT}");

		}
	}
}
