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

        public ActionResult Studies(int id)
        {
            StudiesInformationViewModel studies = new StudiesInformationViewModel();

            if (id > 0)
            {
                Studies studieObject = db.Studies.FirstOrDefault(e => e.Idstudies == id);

                studies.Idstudies = id;
                studies.School = studieObject.School;
                studies.Idstudylevel = studieObject.Idstudylevel;
                studies.Obtainedtitle = studieObject.Obtainedtitle;
                studies.Idacademicstate = studieObject.Idacademicstate;
                studies.Startdate = studieObject.Startdate;
                studies.Enddate = studieObject.Enddate;
                studies.Idperiodicity = studieObject.Idperiodicity;
            }

            studies.academicStateList = new SelectList(db.Academicstate.ToList(), "Idacademicstate", "Name", 1);
            studies.StudyLevelList = new SelectList(db.Studylevel.ToList(), "Idstudylevel", "Name", 1);
            studies.PeriodicityList = new SelectList(db.Periodicity.ToList(), "Idperiodicity", "Name", 1);

            return View(studies);
        }

        [HttpPost]
        public ActionResult Studies(int id, StudiesInformationViewModel studiesViewModel)
        {
            if (ModelState.IsValid)
            {
                Studies studie = new Studies
                {
                    School = studiesViewModel.School,
                    Idstudylevel = studiesViewModel.Idstudylevel,
                    Obtainedtitle = studiesViewModel.Obtainedtitle,
                    Idacademicstate = studiesViewModel.Idacademicstate,
                    Startdate = studiesViewModel.Startdate,
                    Enddate = studiesViewModel.Enddate,
                    Idperiodicity = studiesViewModel.Idperiodicity,
                    Idcandidate = HttpContext.Session.GetInt32("IdCandidate")
                };

                if (id > 0)
                {
                    studie.Idstudies = id;
                    db.Studies.Update(studie);
                }
                else
                {
                    db.Studies.Add(studie);
                }
               
                db.SaveChanges();

                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads");
                var fileName = Path.GetFileName(studiesViewModel.File.FileName);
                var filePath = Path.Combine(uploads, fileName);
                using (FileStream file = new FileStream(filePath, FileMode.Create))
                {
                    studiesViewModel.File.CopyTo(file);
                    file.Close();
                }

                Document document = new Document
                {
                    Idcandidate = HttpContext.Session.GetInt32("IdCandidate"),
                    Url = $"\\uploads\\{fileName}",
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

        // GET: List/Edit/5
        public ActionResult Edit()
        {
            return View();
        }
    }
}