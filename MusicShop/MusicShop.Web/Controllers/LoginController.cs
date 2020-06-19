using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicShop.BusinessLogic;
using MusicShop.BusinessLogic.Interfaces;
using MusicShop.Domain.Entities.User;
using MusicShop.Web.Models;

namespace MusicShop.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private readonly ISession _session;

        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        //Get: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] //transmiterea datelor client sau a formularului catre server
        [ValidateAntiForgeryToken]//pentru a preveni falsificarea cererilor între site-uri
        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Email = login.Email,
                    Password = login.Password,
                    LoginIp = Request.UserHostAddress,
                };

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    //add cookie
                    HttpCookie cookie = _session.GenCookie(login.Email);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }
            }

            return View();
        }
    }
}