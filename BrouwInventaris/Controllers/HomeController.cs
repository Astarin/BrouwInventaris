using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrouwInventaris.Models;

namespace BrouwInventaris.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ////git commit excuus
            //using (DbInventarisContext db = new DbInventarisContext())
            //{
            //    db.Brouwerijen.Add(new Brouwerij { Naam = "Rockabeery" });
            //    db.SaveChanges();
            //}

            DbInventarisContext db = new DbInventarisContext();
            var artikels = (from art in db.Artikels
                            select art).ToList();


            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View(artikels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
