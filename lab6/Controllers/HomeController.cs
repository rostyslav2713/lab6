using lab6.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace lab6.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            IEnumerable<Match> matches = db.Matches;
            ViewBag.Matches = matches;
            return View();
        }

        [HttpGet]
        public ActionResult HoldAMatch(int id)
        {
            ViewBag.matchId = id;
            return View();
        }

        [HttpPost]
        public string HoldAMatch(Stadium stadium)
        {
            stadium.Date = DateTime.Now;
            db.Stadiums.Add(stadium);
            db.SaveChanges();
            return stadium.stadiumName + " буде проводити легендарний матч!";
        }
    }
}