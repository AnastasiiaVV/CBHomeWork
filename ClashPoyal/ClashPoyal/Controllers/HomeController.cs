using ClashPoyal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClashPoyal.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger) {
			_logger = logger;
		}

		public IActionResult Index() {

			if (Request.Cookies["Player_Name"] != null) {
				AllPlayData initPlayerData = new AllPlayData();
				if (Request.Cookies["Player_Name"] == null) {
					Language Lang = new Language("UA");
					return View("Index", Lang);
				} else {
					Language Lang = new Language(Request.Cookies["Player_Lang"]);
					return View("Index", Lang);
				}
				
				
			} else {
				return View("Register");
			}
					
		}
				

		public IActionResult Setting() {
			Language Lang = new Language("UA");
			return View(Lang);
		}

		[HttpPost]
		public IActionResult Register(IFormCollection fromRegistration) {

			if (fromRegistration["nikname"] != "") {
				Response.Cookies.Append("Player_Name", fromRegistration["nikname"]);
			}
			return RedirectToAction("Index", "Home");
		}

		public IActionResult Setting(IFormCollection fromConfig) {

			if (fromConfig["language"].Count > 0) {
				Response.Cookies.Append("Player_Language", fromConfig["language"]);
			}
			return RedirectToAction("Setting", "Home");
		}


		public IActionResult Play() {
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
