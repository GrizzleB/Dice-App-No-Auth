using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dice_App.Models;

namespace Dice_App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Die die)
        {
            ViewBag.Dice = die.Roll();
            return View(die);
        }

    }
}