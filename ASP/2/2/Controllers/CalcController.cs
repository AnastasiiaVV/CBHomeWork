using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Controllers
{
	public class CalcController : Controller
	{
	
		public IActionResult Index() {
			return View();
		}

		public IActionResult Add(int x, int y) {
			int result = x + y;
			return View(result);
		}

		public IActionResult Mul(int x, int y) {
			int result = x * y;
			return View(result);
		}

		public IActionResult Div(int x, int y) {
			int result = x / y;
			return View(result);
		}

		public IActionResult Sub(int x, int y) {
			int result = x - y;
			return View(result);
		}


	}
}
