using EfwithDTO.DTOs;
using EfwithDTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfwithDTO.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        StudentDB_F24_BEntities db = new StudentDB_F24_BEntities();
        public static Department Convert(DepartmentDTO d) {
            return new Department() { 
                Id = d.Id,
                Name = d.Name
            };
        }
        public static DepartmentDTO Convert(Department d)
        {
            return new DepartmentDTO()
            {
                Id = d.Id,
                Name = d.Name
            };
        }
        public List<DepartmentDTO> Convert(List<Department> data) { 
            var list = new List<DepartmentDTO>();
            foreach (var d in data) {
                list.Add(Convert(d));
            }
            return list;
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new DepartmentDTO());
        }
        [HttpPost]
        public ActionResult Create(DepartmentDTO d) {
            if (ModelState.IsValid) {

                db.Departments.Add(Convert(d));
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(d);
        }
        public ActionResult List() {
            var data = db.Departments.ToList();
            return View(Convert(data));
        }
    }
}