using IntroAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class StudentController : ApiController
    {
        Context db = new Context();
        [HttpPost]
        [Route("api/students/create")]
        public HttpResponseMessage Insert(Student  s) {
            db.Students.Add(s);
            db.SaveChanges();
            return  Request.CreateResponse(HttpStatusCode.OK, s);
        }


        [HttpGet]
        [Route("api/students/all")]
        public HttpResponseMessage GetAll() {
            var data = db.Students.ToList();
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }
        [HttpGet]
        [Route("api/students/probation")]
        public HttpResponseMessage Probation() {
            return Request.CreateResponse(HttpStatusCode.OK,"Probation");
        }
    }
}
