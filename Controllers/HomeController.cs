using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Passengers.Models;

namespace Passengers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Passenger());
        }


        public ActionResult About()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddIndex(Passenger d)
        {
            if (ModelState.IsValid)
            {
                var db = new PassengerContext();
                var pas = new Passenger { FirstName = d.FirstName, LastName = d.LastName };
                db.Passengers.Add(pas);
                db.SaveChanges();
            }
            return View("Index", d);
        }

        //HTTPGET We get the list of passengers from the list in Results page
    }
}
