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
    

    public class InscriptionController : Controller
    {
        private PastoralContext db = new PastoralContext();

        // GET: Inscription
        public ActionResult Candidate()
        {
            CandidateInformationViewModel candidate = new CandidateInformationViewModel();
            candidate.CivilStatusList = new SelectList(db.Civilstatus.ToList(), "Idcivilstatus", "Name", 1);

            return View(candidate);
        }

        public ActionResult Guardar([Bind("Documenttype,Identitydocumento,Document,Surname,Name,Mail,Gender,Civilstatus,Brithdate,Telephone,Address,Municipality,District")] CandidateInformationViewModel candidate)
        {
            if (ModelState.IsValid)
            {
                var a = candidate;

                //db.Candidate.Add(candidate);
                //db.SaveChanges();
                return RedirectToAction("Studies");
            }
           
            return View(candidate);
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