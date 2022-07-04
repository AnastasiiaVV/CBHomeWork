using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork_Essential_2_3
{
	class Order
	{
		private List<Position> _positions = new List<Position>();

		public void PrintPositions() {
			foreach (var position in _positions) {
				Console.WriteLine($"Продукт: {position.Product.Article}, количество: {position.Quantity}");
			}
		}
	
		public Order(Position position) {
			_positions.Add(position);
		}

		public void AddPosition(Position position) {
			var position1 = _positions.FirstOrDefault(x => x.Product.Article == position.Product.Article);
			if (position1 != null) {
				position1.AddQuantity(position.Quantity);

			} else {
				_positions.Add(position);
			}
		
		}

		public double CalculateAmount() {
			double amount = 0;
			foreach (var position in _positions) {
				amount += position.Product.Price * position.Quantity;
			}
			return amount;
		}

	}
}
