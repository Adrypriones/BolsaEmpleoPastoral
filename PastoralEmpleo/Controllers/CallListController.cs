using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;

namespace PastoralEmpleo.Controllers
{
    public class CallListController : Controller
    {
        private PastoralContext db = new PastoralContext();
        
        public ActionResult IndexCallList()
        {
            var a = db.Event.ToList();
            return View(a);
        }

        
    }
}