using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.WMA.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.WMA.Controllers.Attributes
{
    public class CookieCheckAttribute : ActionFilterAttribute
    {
        private readonly ISession _session;

        public CookieCheckAttribute()
        {
            var businessLogic = new MyBusinessLogic();
            _session = businessLogic.GetSessionBL();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
            if (apiCookie != null)
            {
                var profile = _session.GetUserByCookie(apiCookie.Value);
                if (profile != null)
                {
                    HttpContext.Current.Session["LoginStatus"] = "login";
                    HttpContext.Current.SetMySessionObject(profile);
                }
                else
                {
                    HttpContext.Current.Session.Clear();
                    if (HttpContext.Current.Request.Cookies.AllKeys.Contains("X-KEY"))
                    {
                        var cookie = HttpContext.Current.Request.Cookies["X-KEY"];
                        if (cookie != null)
                        {
                            cookie.Expires = DateTime.Now.AddDays(-1);
                            HttpContext.Current.Response.Cookies.Add(cookie);
                        }
                    }

                    HttpContext.Current.Session["LoginStatus"] = "logout";
                }
            }
            else
            {
                HttpContext.Current.Session["LoginStatus"] = "logout";
            }
        }
    }
}