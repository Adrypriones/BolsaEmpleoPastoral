using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PastoralEmpleo.Controllers
{
    public class EventController : Controller
    {
        // GET: Login
        public ActionResult Event()
        {
            return View();
        }
    }
}