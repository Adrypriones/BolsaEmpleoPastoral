using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.Shared.Enum;
using PastoralEmpleo.ViewModel;
using System;
using System.IO;
using System.Linq;

namespace PastoralEmpleo.Controllers
{
    public class StudiesController : Controller
    {

        private PastoralContext db = new PastoralContext();

        public ActionResult Studies()
        {
            StudiesInformationViewModel studies = new StudiesInformationViewModel();
            studies.academicStateList = new SelectList(db.Academicstate.ToList(), "Idacademicstate", "Name", 1);
            studies.StudyLevelList = new SelectList(db.Studylevel.ToList(), "Idstudylevel", "Name", 1);
            studies.PeriodicityList = new SelectList(db.Periodicity.ToList(), "Idperiodicity", "Name", 1);

            return View(studies);
        }

        [HttpPost]
        public ActionResult Studies(StudiesInformationViewModel studiesViewModel)
        {
            if (ModelState.IsValid)
            {
                if (studiesViewModel.Startdate > DateTime.Now)
                {

                }

                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads");
                var fileName = Path.GetFileName(studiesViewModel.File.FileName);
                var filePath = Path.Combine(uploads, fileName);
                studiesViewModel.File.CopyTo(new FileStream(filePath, FileMode.Create));


                Studies studie = new Studies();

                studie.School = studiesViewModel.School;
                studie.Idstudylevel = studiesViewModel.Idstudylevel;
                studie.Obtainedtitle = studiesViewModel.Obtainedtitle;
                studie.Idacademicstate = studiesViewModel.Idacademicstate;
                studie.Startdate = studiesViewModel.Startdate;
                studie.Enddate = studiesViewModel.Enddate;
                studie.Idperiodicity = studiesViewModel.Idperiodicity;
                studie.Idcandidate = HttpContext.Session.GetInt32("IdCandidate");

                db.Studies.Add(studie);
                db.SaveChanges();

                Document document = new Document
                {
                    Idcandidate = HttpContext.Session.GetInt32("IdCandidate"),
                    Url = filePath,
                    Iddocumenttype = (int)DocumentTypeEnum.CertificadoEstudio,
                };

                db.Document.Add(document);
                db.SaveChanges();

                return RedirectToAction("Experience", "Experience");
            }

            return View(studiesViewModel);
        }
        
        public ActionResult StudyList()
        {
            var a = db.Studies.Where(s => s.Idcandidate == HttpContext.Session.GetInt32("IdCandidate")).ToList();
            return View(a);
        }
    }
}