
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ItextSharpText = iTextSharp.text;

namespace PastoralEmpleo.Controllers
{
    public class CurriculumVitaeController : Controller
    {
        private PastoralContext db = new PastoralContext();
        // GET: CurriculumVitae
        public ActionResult CurriculumVitae()
        {
            return View();
        }

        public ActionResult Buscar([Bind("Position")] SearchCallViewModel searchCallViewModel)
        {
            var restult = db.Event.Where(e => e.Position.Contains(searchCallViewModel.Position)).ToList();

            if (!restult.Any())
            {
                TempData["Error"] = "CARGO NO ENCONTRADO";

                return RedirectToAction("EventSearch");
            }

            TempData["eventList"] = JsonConvert.SerializeObject(restult);

            return RedirectToAction("EventList");
        }

        public ActionResult EventSearch()
        {
            if (TempData["Error"] != null && !string.IsNullOrEmpty(TempData["Error"].ToString()))
            {
                ViewBag.Error = TempData["Error"].ToString();
            }

            return View();
        }

    }
}