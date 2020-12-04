using eUseControl.Domain.Entities.User;
using eUseControl.WMA.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eUseControl.WMA.Controllers.Attributes
{
    public class AdminModAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if ((string)HttpContext.Current.Session["LoginStatus"] == "login")
            {
                var user = HttpContext.Current.GetMySessionObject();
                if (user != null)
                {
                    if (user.Level != URole.Administrator)
                    {
                        filterContext.Result = new RedirectToRouteResult(new
                            RouteValueDictionary(new { controller = "Error", action = "NotFound" }));
                    }
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new
                            RouteValueDictionary(new { controller = "Error", action = "NotFound" }));
                }
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(new
                            RouteValueDictionary(new { controller = "Error", action = "NotFound" }));
            }
        }
    }
}