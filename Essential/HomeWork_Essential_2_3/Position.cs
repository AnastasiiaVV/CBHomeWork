using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_2_3
{
	class Position
	{
		private Product _product;
		private int _quantity;

		public Product Product { get { return _product; } }
		public int Quantity { get { return _quantity; } }

		public Position(Product product, int quantity = 1) {
			_product = product;
			_quantity = quantity;
		}

		public void AddQuantity(int quantity) {
			_quantity += quantity;
		}

	}
}
