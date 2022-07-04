using _3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index() {

			return View(Create());
		}

		public IActionResult Index1() {
			ViewBag.Text = Create();
			return View();
		}

		public List<Product> Create() {
			List<Product> products = new List<Product>();
			products.Add(new Product(1, "Product1", 11.11));
			products.Add(new Product(2, "Product2", 12.11));
			products.Add(new Product(3, "Product3", 13.11));
			products.Add(new Product(4, "Product4", 14.11));
			products.Add(new Product(5, "Product5", 15.11));
			return products;

		}
	}
}
