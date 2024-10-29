using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    
    public class StudentController : Controller
    {
        [HttpGet]   
        public ActionResult Create() {
            //ViewBag.Name = Request["Name"];
            //ViewBag.Id = Request["dfdf"];
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student s) {
            if (ModelState.IsValid) {
                return RedirectToAction("Index","Home");
            }
            
            return View(s);
        }
        /*public ActionResult Create(FormCollection fc)
        {
            ViewBag.Name = fc["Name"];
            ViewBag.Id = fc["Id"];
            return View();
        }*/
        /*public ActionResult Create(string Name, string Id) { 
            
        }*/

    }
}