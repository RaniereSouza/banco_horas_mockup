using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace banco_horas_mockup.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Login/HandleLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HandleLogin (string login, string senha)
        {
            if (login == "RaniereSouza" && senha == "123456")
            {
                Session["loggedIn"] = true;
                Session["username"] = login;

                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Login ou senha incorretos";

            return View("Index");
        }

        // GET: /Login/HandleLogout
        public ActionResult HandleLogout()
        {
            Session["loggedIn"] = false;
            Session["username"] = "";

            return RedirectToAction("Index", "Home");
        }
    }
}