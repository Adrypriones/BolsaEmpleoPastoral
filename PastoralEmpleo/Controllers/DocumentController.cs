﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System.IO;
using System.Linq;

namespace PastoralEmpleo.Controllers
{
    public class DocumentController : Controller
    {
        private PastoralContext db = new PastoralContext();

        public ActionResult IndexDocument()
        {
            OtherDocumentsViewModel experience = new OtherDocumentsViewModel();

            experience.DocumentTypeList = new SelectList(db.Documenttype.Where(d => d.SubType == 2).ToList(), "Iddocumenttype", "Name", 1);

            return View(experience);
        }

        public ActionResult Guardar(OtherDocumentsViewModel documentViewModel)
        {
            if (ModelState.IsValid)
            {

                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
                var fileName = Path.GetFileName(documentViewModel.File.FileName);
                var filePath = Path.Combine(uploads, fileName);
                documentViewModel.File.CopyTo(new FileStream(filePath, FileMode.Create));

                Document document = new Document();

                document.Iddocumenttype = documentViewModel.Iddocumenttype;

                db.Document.Add(document);
                db.SaveChanges();

                Document doc = new Document
                {
                    Idcandidate = document.Idcandidate,
                    Url = filePath,
                    Iddocumenttype = documentViewModel.Iddocumenttype
                };

                db.Document.Add(document);
                db.SaveChanges();

                return RedirectToAction();
            }

            return View(documentViewModel);
        }


    }
}