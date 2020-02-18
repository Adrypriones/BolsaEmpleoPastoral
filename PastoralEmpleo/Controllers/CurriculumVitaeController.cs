
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
            List<Studies> studies;

            TempData.TryGetValue("curriculumVitae", out object curriculumVitae);

            if (curriculumVitae != null)
            {
                studies = JsonConvert.DeserializeObject<List<Studies>>((string)curriculumVitae);
                TempData.Remove("curriculumVitae");
            }
            else
            {
                studies = db.Studies.ToList();
            }

            return View(studies);
        }      

        

    }
}