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


        [HttpGet]
        public ActionResult About(Passenger p)
        {
            using (PassengerContext ntx = new PassengerContext())
            {
                List<Passenger> passengers =new List<Passenger>();

                foreach (Passenger pass in passengers)
                {
                    pass.FirstName = p.FirstName;
                    pass.LastName = p.LastName;
                }
                passengers.Add(p);           
                return View(passengers);
            }
        }


        //public ActionResult About()
        //{
        //    using (PassengerContext ntx = new PassengerContext())
        //    {
        //        return View(ntx.Passengers.ToList());
        //    }
        //}
    }
}
    
