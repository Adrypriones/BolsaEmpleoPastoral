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
            candidate.GenderList = new SelectList(db.Gender.ToList(), "Idgender", "Name", 1);
            candidate.DocumenttypeList = new SelectList(db.Documenttype.ToList(), "Iddocumenttype", "Name", 1);

            return View(candidate);
        }

        public ActionResult Guardar([Bind("Iddocumenttype,Identitydocumento,Document,Surname,Name,Mail,Idgender,Idcivilstatus,Brithdate,Telephone,Address,Municipality,District")] CandidateInformationViewModel candidateViewModel)
        {
            if (ModelState.IsValid)
            {
                Candidate candidate = new Candidate();

                candidate.Idcivilstatus = candidateViewModel.Idcivilstatus;
                candidate.Iddocumenttype = candidateViewModel.Iddocumenttype;
                candidate.Idgender = candidateViewModel.Idgender;
                candidate.Name = candidateViewModel.Name;
                candidate.Surname = candidateViewModel.Surname;
                candidate.Mail = candidateViewModel.Mail;
                candidate.Identitydocumento = candidateViewModel.Identitydocumento;
                candidate.Telephone = candidateViewModel.Telephone;
                candidate.Address = candidateViewModel.Address;
                candidate.Brithdate = candidateViewModel.Brithdate;
                candidate.Municipality = candidateViewModel.Municipality;
                candidate.District = candidateViewModel.District;
                




                db.Candidate.Add(candidate);
                db.SaveChanges();
                return RedirectToAction("Studies");
            }

            return View(candidateViewModel);
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