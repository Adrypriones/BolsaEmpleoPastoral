using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using PastoralEmpleo.Shared.Enum;




namespace PastoralEmpleo.Controllers
{
    public class ExperienceController : Controller
    {
        private PastoralContext db = new PastoralContext();

        public ActionResult IndexExperience()
        {


            ExperienceInformationViewModel experience = new ExperienceInformationViewModel();

            experience.WorkStatusList = new SelectList(db.Workstatus.ToList(), "Idworkstatus", "Name", 1);

            return View(experience);
        }

        public ActionResult Guardar(ExperienceInformationViewModel experienceViewModel)
        {
            if (ModelState.IsValid)
            {

                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads");
                var fileName = Path.GetFileName(experienceViewModel.File.FileName);
                var filePath = Path.Combine(uploads, fileName);
                experienceViewModel.File.CopyTo(new FileStream(filePath, FileMode.Create));

                Experience experience = new Experience();

                experience.Companyname = experienceViewModel.Companyname;
                experience.Endperiod = experienceViewModel.Endperiod;
                experience.Position = experienceViewModel.Position;
                experience.Idworkstatus = experienceViewModel.Idworkstatus;
                experience.Initialperiod = experienceViewModel.initialperiod;
                experience.Inmediateboss = experienceViewModel.Inmediateboss;
                experience.Inmediatechiefnumbre = experienceViewModel.Inmediatechiefnumbre;
                experience.Idcandidate = HttpContext.Session.GetInt32("IdUser");

                db.Experience.Add(experience);
                db.SaveChanges();

                Document document = new Document
                {
                    Idcandidate = HttpContext.Session.GetInt32("IdUser"),
                    Url = filePath,
                    Iddocumenttype = (int)DocumentTypeEnum.CartaLaboral,
                };

                db.Document.Add(document);
                db.SaveChanges();

                return RedirectToAction("IndexDocument" , "Document");
            }

            return View(experienceViewModel);
        }



    }
}