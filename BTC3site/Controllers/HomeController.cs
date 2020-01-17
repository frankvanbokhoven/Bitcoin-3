using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTC3site.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Mining()
		{
			ViewBag.Message = "Mining";
			return View();

		}

		public ActionResult Roadmap()
		{
			ViewBag.Message = "Roadmap";
			return View();

		}

		public ActionResult Security()
		{
			ViewBag.Message = "Security";
			return View();

		}

		public ActionResult Genesis()
		{
			ViewBag.Message = "Genesis";
			return View();

		}

		public ActionResult BlockExplorer()
		{
			ViewBag.Message = "BlockExplorer";
			return View();

		}
	}
}