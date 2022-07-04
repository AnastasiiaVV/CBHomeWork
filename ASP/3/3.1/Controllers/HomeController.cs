using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAParser;

namespace _3._1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() {
			ViewBag.Ip = HttpContext.Connection.RemoteIpAddress;
			var userAgent = HttpContext.Request.Headers["User-Agent"];
			var uaParser = Parser.GetDefault();
			ClientInfo c = uaParser.Parse(userAgent);
			ViewBag.browserName = c.UA.Family;

			return View("~/Views/Home/Index.cshtml");
		}


	}
}
