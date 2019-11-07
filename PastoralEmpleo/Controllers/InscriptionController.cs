using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PastoralEmpleo.Controllers
{
    public class InscriptionController : Controller
    {
        // GET: Inscription
        public ActionResult Candidate()
        {
            return View();
        }

        // GET: Inscription/Details/5
        public ActionResult Studies()
        {
            return View();
        }

        // GET: Inscription/Create
        public ActionResult Experience()
        {
            return View();
        }


        public ActionResult Document()
        {
            return View();
        }
    }
}