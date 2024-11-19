using EfwithDTO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfwithDTO.Auth
{
    public class Logged : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = (User)httpContext.Session["user"];
            if(user != null) return true;
            return false;
        }
    }
}