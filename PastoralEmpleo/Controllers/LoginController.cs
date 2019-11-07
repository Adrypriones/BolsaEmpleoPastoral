using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PastoralEmpleo.Controllers
{
    public class LoginController : Controller
    {
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

        
           
    }
}