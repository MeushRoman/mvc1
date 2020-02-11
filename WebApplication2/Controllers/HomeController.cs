using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("Do1");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Do1()
        {
            return View();
        }

        [HttpPost]
        public void Do1(City city)
        {
            int id = city.Id;
            string name = city.Name;
        }

        [HttpGet]
        public ActionResult Do2()
        {
            City city = new City()
            {
                Id = 1,
                Name = "test"
            };
            return View(city);
        }
        [HttpGet]
        public ActionResult Do3()
        {
            City city = new City()
            {
                Id = 1,
                Name = "test"
            };
            return View(city);
        }

        [HttpPost]
        public ActionResult Do3(City city)
        {
            var obj = city;
            return View();
        }

        [HttpGet]
        public ActionResult Part()
        {            
            return View();
        }
        [HttpGet]
        public ActionResult HelperTest()
        {
            return View();
        }

    }
}