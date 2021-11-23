using RetroLogger5000.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetroLogger5000.Web.Controllers
{
    public class GamesController : Controller
    {
		private readonly IGameData db;

		public GamesController(IGameData db)
		{
			this.db = db;
		}
        // GET: Games
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
		{
            var model = db.Get(id);
            if(model == null)
			{
                return View("NotFound");
			}
            return View(model);
		}

        public ActionResult Create()
		{
            return View();
		}
    }
}