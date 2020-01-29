﻿using System;
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
            if (TempData["Error"] != null && !string.IsNullOrEmpty(TempData["Error"].ToString()))
            {
                ViewBag.Error = TempData["Error"].ToString();
            }
            return View();
        }

        public ActionResult Iniciar(string Mail, string Password)
        {
            User user= db.User.FirstOrDefault(e => e.Mail == Mail && e.Password == Password);

            if (user == null)
            {
                TempData["Error"] = "Usuario no registrado";

                return RedirectToAction("Login");
            }

            HttpContext.Session.SetInt32("IdUser", user.Iduser);

            return RedirectToAction("Contact", "Home");
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