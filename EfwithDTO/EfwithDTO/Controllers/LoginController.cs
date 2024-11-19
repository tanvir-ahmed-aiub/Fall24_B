using EfwithDTO.DTOs;
using EfwithDTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfwithDTO.Controllers
{
    public class LoginController : Controller
    {
        StudentDB_F24_BEntities db = new StudentDB_F24_BEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginDTO log) {
            //
            var user = (from u in db.Users
                        where u.UName.Equals(log.Uname)
                        && u.Pass.Equals(log.Password)
                        select u).SingleOrDefault();
            if (user != null) {
                Session["user"] = user; //boxing
                return RedirectToAction("List","Department");
            }
            TempData["Msg"] = "User not found";
            return View();

        }
    }
}