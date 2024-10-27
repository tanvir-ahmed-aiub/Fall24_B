using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroMVC.Models;

namespace IntroMVC.Controllers
{
    public class ProtfolioController : Controller
    {
        public ActionResult Bio() { 
            return View();
        }
        public ActionResult Education() {

            ViewBag.Name = "Tanvir Ahmed";
            ViewBag.Id = "23344";
            Degree d1 = new Degree() { 
                Title = "BSc",
                Result = "3.45",
                Ins = "AIUB",
                Year = "2019"
            };
            Degree d2 = new Degree()
            {
                Title = "HSC",
                Result = "5.00",
                Ins = "Ins1",
                Year = "2016"
            };
            Degree d3 = new Degree()
            {
                Title = "SSC",
                Result = "5.00",
                Ins = "Ins2",
                Year = "2014"
            };
            Degree[] degrees = new Degree[3] { d1,d2,d3};
            ViewBag.Degrees = degrees;
            return View();

        }
        public ActionResult Qualifications() {
            bool hasQualification = false;
            //
            //
            //
            if (hasQualification) { 
                return View();
            }
            TempData["Msg"] = "There is no qualifications, show education instead";
            return RedirectToAction("Education");
        }
    }
}