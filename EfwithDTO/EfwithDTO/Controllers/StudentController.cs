using EfwithDTO.Auth;
using EfwithDTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfwithDTO.Controllers
{
    [Logged]
    public class StudentController : Controller
    {
        StudentDB_F24_BEntities db = new StudentDB_F24_BEntities();
        // GET: Student
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            //validations
            if (ModelState.IsValid) {
                db.Students.Add(s);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(s);
            
        }
        [AllowAnonymous]
        public ActionResult List()
        {

            var data = db.Students.ToList();
            //scholarship
            var sch = (from s in db.Students
                       where s.Cgpa >= 3.75
                       select s).ToList();

            //probation
            var prob = (from s in db.Students
                        where s.Cgpa <= 2.50
                        select s).ToList();
            return View(data);
        }
        public ActionResult Details(int id)
        {

            var data = db.Students.Find(id);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var exobj = db.Students.Find(id);
            return View(exobj);
        }
        [HttpPost]
        public ActionResult Edit(Student formObj)
        {
            var dbobj = db.Students.Find(formObj.Id);
            formObj.Cgpa = dbobj.Cgpa;
            db.Entry(dbobj).CurrentValues.SetValues(formObj);

            //recommended
            //dbobj.Name = formObj.Name;
            //dbobj.Cgpa = formObj.Cgpa;
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(int Id, string dcsn)
        {
            if (dcsn.Equals("Yes"))
            {
                var data = db.Students.Find(Id);
                db.Students.Remove(data);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

    }
}