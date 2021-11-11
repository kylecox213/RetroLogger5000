using RetroLogger5000.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetroLogger5000.Web.Controllers
{
    public class GameInformationController : Controller
    {
        // GET: GameInformation
        public ActionResult Index(string title)
        {
            var model = new GameInformationViewModel();
            model.Title = title ?? "no name";
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}