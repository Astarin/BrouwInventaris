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
            DbInventarisContext db = new DbInventarisContext();
            var aankopen = (from aan in db.Aankopen.Include("Artikel")
                            select aan).ToList();


            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View(aankopen);
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
