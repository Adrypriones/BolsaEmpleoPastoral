using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using System.Linq;

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
            User user = db.User.FirstOrDefault(e => e.Mail == Mail && e.Password == Password);

            if (user == null)
            {
                TempData["Error"] = "Usuario no registrado";

                return RedirectToAction("Login");
            }

            HttpContext.Session.SetInt32("IdUser", user.Iduser);

            var candidate = db.Candidate.FirstOrDefault(c => c.Iduser == user.Iduser);

            if (candidate != null)
            {
                HttpContext.Session.SetInt32("IdCandidate", candidate.Idcandidate);
            }

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

        public ActionResult Save([Bind("Name, Surname,Mail, Password")] User user)
        {
            if (ModelState.IsValid)
            {
                User userDB = db.User.FirstOrDefault(u => u.Mail == user.Mail);

                if (userDB == null)
                {
                    db.User.Add(user);
                    db.SaveChanges();
                }

                HttpContext.Session.SetInt32("IdUser", user.Iduser);

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