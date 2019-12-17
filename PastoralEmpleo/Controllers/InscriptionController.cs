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
            StudiesInformationViewModel studies = new StudiesInformationViewModel();
            studies.academicStateList = new SelectList(db.Academicstate.ToList(), "Idacademicstate", "Name", 1);
            studies.StudyLevelList = new SelectList(db.Studylevel.ToList(), "Idstudylevel", "Name", 1);
            studies.PeriodicityList = new SelectList(db.Periodicity.ToList(), "Idperiodicity", "Name", 1);

            return View(studies);
        }

        public ActionResult Continuar([Bind("School,Idstudylevel,Obtainedtitle,Idacademicstate,Startdate,Enddate, Idperiodicity")] StudiesInformationViewModel studiesViewModel)
        {
            if (ModelState.IsValid)
            {
                Studies studie = new Studies();

                studie.School = studiesViewModel.School;
                studie.Idstudylevel = studiesViewModel.Idstudylevel;
                studie.Obtainedtitle = studiesViewModel.Obtainedtitle;
                studie.Idacademicstate = studiesViewModel.Idacademicstate;
                studie.Startdate = studiesViewModel.Startdate;
                studie.Enddate = studiesViewModel.Enddate;
                studie.Idperiodicity = studiesViewModel.Idperiodicity;

                db.Studies.Add(studie);
                db.SaveChanges();
                return RedirectToAction("Experience");
            }

            return View(studiesViewModel);
        } 
            

            // GET: Inscription/Create
            public ActionResult Experience()
            {
            ExperienceInformationViewModel experience = new ExperienceInformationViewModel();

            experience.WorkStatusList = new SelectList(db.Workstatus.ToList(), "Idworkstatus", "Name", 1);

            return View(experience);
            }

        public ActionResult Guardarlo([Bind("Companyname,Position,Idworkstatus,initialperiod,endperiod,Inmediateboss,Inmediatechiefnumbre ")] ExperienceInformationViewModel experienceViewModel)
        {
            if (ModelState.IsValid)
            {
                Experience experience = new Experience();

                experience.Companyname = experienceViewModel.Companyname;
                experience.Endperiod = experienceViewModel.Endperiod;
                experience.Position = experienceViewModel.Position;
                experience.Idworkstatus = experienceViewModel.Idworkstatus;
                experience.Initialperiod = experienceViewModel.initialperiod;
                experience.Inmediateboss = experienceViewModel.Inmediateboss;
                experience.Inmediatechiefnumbre = experienceViewModel.Inmediatechiefnumbre;                

                db.Experience.Add(experience);
                db.SaveChanges();
                return RedirectToAction("Document");
            }

            return View(experienceViewModel);
        }



        public ActionResult Document()
        {
                return View();
        }
        
    }

}    