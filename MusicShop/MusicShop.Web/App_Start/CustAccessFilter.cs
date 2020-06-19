using MusicShop.BusinessLogic.Interfaces;
using MusicShop.Domain.Enums;
using MusicShop.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MusicShop.Web.App_Start
{
    public class CustAccessFilter
    {
        public class AdminModAttribute : ActionFilterAttribute
        {
            private readonly ISession _sessionBusinessLogic;

            public AdminModAttribute()
            {
                var businessLogic = new BusinessLogic.BussinesLogic();
                _sessionBusinessLogic = businessLogic.GetSessionBL();
            }

            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
                if (apiCookie != null)
                {
                    var profile = _sessionBusinessLogic.GetUserByCookie(apiCookie.Value);
                    if (profile != null && profile.Level == URole.Admin)
                    {
                        HttpContext.Current.SetMySessionObject(profile);
                    }
                    else
                    {
                        filterContext.Result = new RedirectToRouteResult(new
                            RouteValueDictionary(new { controller = "Error", action = "Error404" }));
                    }
                }
            }
        }
    }
}