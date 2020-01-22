using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System.IO;
using System.Linq;

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
            candidate.DocumenttypeList = new SelectList(db.Documenttype.Where(d => d.SubType == 1).ToList(), "Iddocumenttype", "Name", 1);

            return View(candidate);
        }

        public ActionResult Guardar(CandidateInformationViewModel candidateViewModel)
        {
            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
                var fileName = Path.GetFileName(candidateViewModel.File.FileName);
                var filePath = Path.Combine(uploads, fileName);
                candidateViewModel.File.CopyTo(new FileStream(filePath, FileMode.Create));

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

                Document document = new Document
                {  
                    Idcandidate = candidate.Idcandidate,
                    Url = filePath,
                    Iddocumenttype = candidateViewModel.Iddocumenttype
                };

                db.Document.Add(document);
                db.SaveChanges();


                return RedirectToAction("IndexStudies", "Studies");
            }

            return View(candidateViewModel);

        }

    }

}