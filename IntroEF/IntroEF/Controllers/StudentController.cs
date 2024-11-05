
using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s) {
            //validations
            var db = new StudentDB_F24_BEntities();
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult List() {
            var db = new StudentDB_F24_BEntities();
            var data = db.Students.ToList();
            return View(data);
        }
        public ActionResult Details(int id) {
            var db = new StudentDB_F24_BEntities();
            var data = db.Students.Find(id);
            return View(data);
        }
    }
}