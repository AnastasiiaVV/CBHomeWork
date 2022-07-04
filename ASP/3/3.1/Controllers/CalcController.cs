using _3._1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._1.Controllers
{
	[Route("~/")]
	[Route("[controller]")]
	public class CalcController : Controller
	{
		public IActionResult Index() {
			var item = new Calculate();
			return View("~/Views/Calc/Index.cshtml", item);
		}


		[Route("[action]/{x}/{y}")]
		public IActionResult Add(double x, double y) {
			var item = new Calculate();
			item.Oper1 = x;
			item.Oper2 = y;
			item.Operation = "+";
			item.Result = x + y;
			return View("~/Views/Calc/Index.cshtml", item);
		}

		[Route("[action]/{x}/{y}")]
		public IActionResult Mul(double x, double y) {
			var item = new Calculate();
			item.Oper1 = x;
			item.Oper2 = y;
			item.Operation = "*";
			item.Result = x * y;
			return View("~/Views/Calc/Index.cshtml", item);
		}

		[Route("[action]/{x}/{y}")]
		public IActionResult Div(double x, double y) {
			var item = new Calculate();
			item.Oper1 = x;
			item.Oper2 = y;
			item.Operation = "/";
			item.Result = x / y;
			return View("~/Views/Calc/Index.cshtml", item);
		}

		[Route("[action]/{x}/{y}")]
		public IActionResult Sub(double x, double y) {
			var item = new Calculate();
			item.Oper1 = x;
			item.Oper2 = y;
			item.Operation = "-";
			item.Result = x - y;
			return View("~/Views/Calc/Index.cshtml", item);
		
		}
	}
}
