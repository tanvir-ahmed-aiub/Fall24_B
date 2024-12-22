using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class HomeController : ApiController
    {
        public HttpResponseMessage Get() {
            return Request.CreateResponse(HttpStatusCode.OK,"Get Method");
        }
        public HttpResponseMessage Post() {
            return Request.CreateResponse(HttpStatusCode.OK, "Post Method");
        }
        /*public HttpResponseMessage Put() { }
        public HttpResponseMessage Delete() { }*/
    }
}
