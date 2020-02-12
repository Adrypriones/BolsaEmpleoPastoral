using Microsoft.AspNetCore.Http;
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
            CandidateInformationViewModel candidateViewModel = new CandidateInformationViewModel();
            candidateViewModel.CivilStatusList = new SelectList(db.Civilstatus.ToList(), "Idcivilstatus", "Name", 1);
            candidateViewModel.GenderList = new SelectList(db.Gender.ToList(), "Idgender", "Name", 1);
            candidateViewModel.DocumenttypeList = new SelectList(db.Documenttype.Where(d => d.SubType == 1).ToList(), "Iddocumenttype", "Name", 1);

            var candidate = db.Candidate.FirstOrDefault(c => c.Iduser == (int)HttpContext.Session.GetInt32("IdUser"));

            if (candidate != null)
            {
                candidateViewModel.Idcivilstatus = candidate.Idcivilstatus;
                candidateViewModel.Iddocumenttype = candidate.Iddocumenttype;
                candidateViewModel.Idgender = candidate.Idgender;
                candidateViewModel.Name = candidate.Name;
                candidateViewModel.Surname = candidate.Surname;
                candidateViewModel.Mail = candidate.Mail;
                candidateViewModel.Identitydocumento = candidate.Identitydocumento;
                candidateViewModel.Telephone = candidate.Telephone;
                candidateViewModel.Address = candidate.Address;
                candidateViewModel.Brithdate = candidate.Brithdate;
                candidateViewModel.Municipality = candidate.Municipality;
                candidateViewModel.District = candidate.District;              

            }
            return View(candidateViewModel);
        }

        [HttpPost]
        public ActionResult Candidate(CandidateInformationViewModel candidateViewModel)
        {
            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads");
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
                candidate.Iduser = HttpContext.Session.GetInt32("IdUser");

                db.Candidate.Add(candidate);
                db.SaveChanges();

                HttpContext.Session.SetInt32("IdCandidate", candidate.Idcandidate);

                Document document = new Document
                {  
                    Idcandidate = candidate.Idcandidate,
                    Url = $"\\uploads\\{fileName}",
                    Iddocumenttype = candidateViewModel.Iddocumenttype
                };

                db.Document.Add(document);
                db.SaveChanges();


                return RedirectToAction("Studies", "Studies");
            }

            candidateViewModel.CivilStatusList = new SelectList(db.Civilstatus.ToList(), "Idcivilstatus", "Name", 1);
            candidateViewModel.GenderList = new SelectList(db.Gender.ToList(), "Idgender", "Name", 1);
            candidateViewModel.DocumenttypeList = new SelectList(db.Documenttype.Where(d => d.SubType == 1).ToList(), "Iddocumenttype", "Name", 1);
                       
            return View(candidateViewModel);

        }

    }

}