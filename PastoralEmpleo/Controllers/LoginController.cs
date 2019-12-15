using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;

namespace PastoralEmpleo.Controllers
{
    public class LoginController : Controller
    {
        private PastoralContext db = new PastoralContext();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // GET: Login/Details/5

       
        public ActionResult Register()
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult ResetPassword()
        {
            return View();
        }

        public ActionResult Save([Bind("Name, Surname,Mail, Password")] User registro)
        {
            if (ModelState.IsValid)
            {
                db.User.Add(registro);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View();
        }        

        [HttpPost]
        public ActionResult Authenticate([Bind("Name, Surname,Mail, Password")] User usuario)
        {
            User user = db.User.FirstOrDefault(u => u.Name == usuario.Name && u.Surname == usuario.Surname && u.Mail == usuario.Mail && u.Password == usuario.Password);

            if (user != null)
            {
                return RedirectToAction("Contact", "Home");
            }
            else
            {
                return RedirectToAction("Register", "Login");
            }
        }



    }
}