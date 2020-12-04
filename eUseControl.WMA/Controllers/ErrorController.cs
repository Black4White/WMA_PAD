using eUseControl.WMA.Controllers.Attributes;
using eUseControl.WMA.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.WMA.Controllers
{
    [CookieCheck]
    public class ErrorController : Controller
    {
        public ActionResult NotFound()
        {
            var user = System.Web.HttpContext.Current.GetMySessionObject();

            Response.StatusCode = 404;
            return View();
        }

        public ActionResult Forbidden()
        {
            var user = System.Web.HttpContext.Current.GetMySessionObject();

            Response.StatusCode = 403;
            return View();
        }
    }
}