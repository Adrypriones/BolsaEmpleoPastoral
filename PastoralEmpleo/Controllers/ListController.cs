using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PastoralEmpleo.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult StudyListing()
        {
            return View();
        }

        // GET: List/Details/5
        public ActionResult EmploymentListing()
        {
            return View();
        }

        // GET: List/Create
        public ActionResult DocumentListing()
        {
            return View();
        }       
        

        // GET: List/Edit/5
        public ActionResult Edit()
        {
            return View();
        }
        

        // GET: List/Delete/5
        public ActionResult Delete()
        {
            return View();
        }
        
    }
}