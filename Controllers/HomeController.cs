using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Passengers.Models;
using System.Data.Entity;

namespace Passengers.Controllers
{
    public class HomeController : Controller
    {

        //We add new Passengers Individually in Passengers Table
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
            return View("Index");
        }
        public ActionResult Index()
        {
            return View();
        }


        //We display the table items as a list in the About Page
        [HttpGet]
        public ActionResult About()
        {
            using (PassengerContext ntx = new PassengerContext())
            {
                try
                {
                    return View(ntx.Passengers.ToList());
                }
                catch
                {
                    return View();
                }
            }
        }

        //Clear Passenger Table
        [HttpGet]
        public ActionResult Clear()
        {
            using (PassengerContext ntx = new PassengerContext())
            {
                //Fast Way
                ntx.Database.ExecuteSqlCommand("TRUNCATE TABLE [Passengers]");

                //Slow way
                //var rows = from o in ntx.Passengers
                //           select o;
                //foreach (var row in rows)
                //{
                //    ntx.Passengers.Remove(row);
                //}
                ntx.SaveChanges();
                return Redirect("About");
            }
        }
    }
}
