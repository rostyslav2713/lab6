using lab6.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using lab6.Models;

namespace lab6.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            IEnumerable<Bank> banks = db.Banks;
            ViewBag.Banks = banks;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.bank_id = id;
            return View();
        }

        [HttpPost]
        public string Buy(Country country)
        {
            country.Date = DateTime.Now;
            db.Countries.Add(country);
            db.SaveChanges();
            return country.country_name + " взяла кредит ЗНОВУ!!!";
        }
    }
}