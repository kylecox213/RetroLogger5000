using RetroLogger5000.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetroLogger5000.Web.Controllers
{
	public class HomeController : Controller
	{
		IGameData db;

		public HomeController(IGameData db)
		{
			this.db = db;
		}

		public ActionResult Index()
		{
			var model = db.GetAll();
			return View(model);
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
	}
}