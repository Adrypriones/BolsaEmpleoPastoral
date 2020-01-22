using Microsoft.AspNetCore.Mvc;
using PastoralEmpleo.Data;
using System.Linq;

namespace PastoralEmpleo.Controllers

{
    public class ListController : Controller
    {
        private PastoralContext db = new PastoralContext();
        // GET: List
       

        // GET: List/Details/5
        public ActionResult EmploymentListing()
        {
            var a = db.Experience.ToList();
            return View(a);         
        }      


        // GET: List/Edit/5
        public ActionResult Edit()
        {
            return View();
        }       

        
    }
}