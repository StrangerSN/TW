using AutoMapper;
using MusicShop.Web.Extensions;
using MusicShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MusicShop.Web.App_Start.CustAccessFilter;

namespace MusicShop.Web.Controllers
{
    public class AdminController : BaseController
    {
        [AdminMod]
        public ActionResult Index()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] == "login")
            {
                var user = System.Web.HttpContext.Current.GetMySessionObject();
                var u = Mapper.Map<UserData>(user);
                return View(u);
            }
            return View();
        }
    }
}