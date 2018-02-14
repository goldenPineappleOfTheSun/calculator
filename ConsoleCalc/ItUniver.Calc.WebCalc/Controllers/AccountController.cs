using ItUniver.Calc.DB.Models;
using ItUniver.Calc.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserRepository Users { get; set; }

        public AccountController()
        {
            Users = new UserRepository("User");
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Registration(RegistrationModel model)
        {
            if (!ModelState.IsValid)
                return View();

            AddToUsers(model.Login, model.Password, model.Name, model.BirthDay);
            FormsAuthentication.SetAuthCookie(model.Login, true);
            return RedirectToAction("Index", "Calc");

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View();

            if (Users.Check(model.Login, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.Login, true);
                return RedirectToAction("Index", "Calc");
            }

            ModelState.AddModelError("", "Не удалось войти :(");

            return View();
        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        private void AddToUsers(string login, string password, string Name, DateTime birth)
        {
            var item = new UserItem();
            item.Login = login;
            item.Name = Name;
            item.Password = password;
            item.BirthDay = birth;

            Users.Save(item);
        }
    }
}