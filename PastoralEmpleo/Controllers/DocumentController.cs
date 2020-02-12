using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PastoralEmpleo.Controllers
{
    public class DocumentController : Controller
    {
        private PastoralContext db = new PastoralContext();

        public ActionResult Document()
        {
            OtherDocumentsViewModel experience = new OtherDocumentsViewModel
            {
                DocumentTypeList = new SelectList(db.Documenttype.Where(d => d.SubType == 2).ToList(), "Iddocumenttype", "Name", 1)
            };

            return View(experience);
        }

        [HttpPost]
        public ActionResult Document(OtherDocumentsViewModel documentViewModel)
        {
            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads");
                var fileName = Path.GetFileName(documentViewModel.File.FileName);
                var filePath = Path.Combine(uploads, fileName);
                using (FileStream file = new FileStream(filePath, FileMode.Create))
                {
                    documentViewModel.File.CopyTo(file);
                    file.Close();
                }

                Document document = new Document
                {
                    Idcandidate = HttpContext.Session.GetInt32("IdCandidate"),
                    Url = $"\\uploads\\{fileName}",
                    Iddocumenttype = documentViewModel.Iddocumenttype,               
                };

                db.Document.Add(document);
                db.SaveChanges();

                return RedirectToAction("Document", "Document");
            }

            documentViewModel.DocumentTypeList = new SelectList(db.Documenttype.Where(d => d.SubType == 2).ToList(), "Iddocumenttype", "Name", 1);

            return View(documentViewModel);
        }


        public ActionResult DocumentList()
        {
            List<DocumentsViewModel> documentListViewModel = new List<DocumentsViewModel>();

            var documents = db.Document.Include(d => d.IddocumenttypeNavigation).Where(e => e.Idcandidate == HttpContext.Session.GetInt32("IdCandidate")).ToList();

            foreach (Document document in documents)
            {
                documentListViewModel.Add(new DocumentsViewModel
                {
                    IdDocument = document.Iddocument,
                    DocumentType = document.IddocumenttypeNavigation.Name
                });
            }

            return View(documentListViewModel);
        }

        public ActionResult Imprimir(int id)
        {
            var document = db.Document.FirstOrDefault(e => e.Iddocument == id);

            string path = document.Url;
            var fileName = Path.GetFileNameWithoutExtension(path);

            var stream = new FileStream($".\\wwwroot\\{path}", FileMode.Open);

            return File(stream, "application/pdf", fileName);
        }


        // GET: List/Edit/5
        public ActionResult Edit()
        {
            return View();
        }



    }
}