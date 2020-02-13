using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using PastoralEmpleo.Shared.Enum;
using System;

namespace PastoralEmpleo.Controllers
{
    public class ExperienceController : Controller
    {
        private PastoralContext db = new PastoralContext();


        public ActionResult Experience(int id)
        {
            ExperienceInformationViewModel experience = new ExperienceInformationViewModel();

            if (id > 0)
            {
                Experience experienceObject = db.Experience.FirstOrDefault(e => e.Idexperience == id);

                experience.Idexperience = id;
                experience.Companyname = experienceObject.Companyname;
                experience.Endperiod = experienceObject.Endperiod;
                experience.Position = experienceObject.Position;
                experience.Idworkstatus = experienceObject.Idworkstatus;
                experience.Initialperiod = experienceObject.Initialperiod;
                experience.Inmediateboss = experienceObject.Inmediateboss;
                experience.Inmediatechiefnumbre = experienceObject.Inmediatechiefnumbre;                
            }

            experience.WorkStatusList = new SelectList(db.Workstatus.ToList(), "Idworkstatus", "Name", 1);

            return View(experience);
        }

        [HttpPost]
        public ActionResult Experience(int id, ExperienceInformationViewModel experienceViewModel)
        {
            if (ModelState.IsValid)
            {
                Experience experience = new Experience
                {
                    Companyname = experienceViewModel.Companyname,
                    Endperiod = experienceViewModel.Endperiod,
                    Position = experienceViewModel.Position,
                    Idworkstatus = experienceViewModel.Idworkstatus,
                    Initialperiod = (DateTime)experienceViewModel.Initialperiod,
                    Inmediateboss = experienceViewModel.Inmediateboss,
                    Inmediatechiefnumbre = experienceViewModel.Inmediatechiefnumbre,
                    Idcandidate = HttpContext.Session.GetInt32("IdCandidate")
                };

                if (id > 0)
                {
                    experience.Idexperience = id;
                    db.Experience.Update(experience);
                }
                else
                {
                    db.Experience.Add(experience);
                }

                db.SaveChanges();

                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads");
                var fileName = Path.GetFileName(experienceViewModel.File.FileName);
                var filePath = Path.Combine(uploads, fileName);
                using (FileStream file = new FileStream(filePath, FileMode.Create))
                {
                    experienceViewModel.File.CopyTo(file);
                    file.Close();
                }

                Document document = new Document
                {
                    Idcandidate = HttpContext.Session.GetInt32("IdCandidate"),
                    Url = $"\\uploads\\{fileName}",
                    Iddocumenttype = (int)DocumentTypeEnum.CartaLaboral,
                };

                db.Document.Add(document);
                db.SaveChanges();

                return RedirectToAction("ExperienceList");
            }

            experienceViewModel.WorkStatusList = new SelectList(db.Workstatus.ToList(), "Idworkstatus", "Name", 1);

            return View(experienceViewModel);
        }

        public ActionResult ExperienceList()
        {
            var a = db.Experience.Where(e => e.Idcandidate == HttpContext.Session.GetInt32("IdCandidate")).ToList();
            return View(a);
        }

        // GET: List/Edit/5
        public ActionResult Edit()
        {
            return View();
        }
    }
}