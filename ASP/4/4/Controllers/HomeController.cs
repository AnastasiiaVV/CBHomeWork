using _4.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4.Controllers
{
	public class HomeController : Controller
	{
		ReturnDataTime Model;
		public IActionResult Index() {
			return View();
		}

		public IActionResult Page1() {
			return View(Model);
		}

		public IActionResult Page2() {
			return View();
		}

		public HomeController() {
			Model = new ReturnDataTime() {
				ReturnData = DateTime.Now
			};
			

		}
		public IActionResult GetTime() {
			return PartialView("_GetTime", Model);
		}

	}
}
