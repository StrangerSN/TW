using MusicShop.BusinessLogic;
using MusicShop.BusinessLogic.Interfaces;
using MusicShop.Domain.Entities.User;
using MusicShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicShop.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISession _register;
        public RegisterController()
        {
            var bl = new BussinesLogic();
            _register = bl.GetSessionBL();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserRegister user)
        {
            URegisterData data = new URegisterData
            {
                Username = user.Username,
                Password = user.Password,
                Email = user.Email
            };

            _register.UserRegister(data);

            ULoginData u = new ULoginData
            {
                Email = user.Username,
                Password = user.Password
            };


            HttpCookie cookie = _register.GenCookie(u.Email);
            ControllerContext.HttpContext.Response.Cookies.Add(cookie);

            return RedirectToAction("Index", "Home");
        }
    }
}
