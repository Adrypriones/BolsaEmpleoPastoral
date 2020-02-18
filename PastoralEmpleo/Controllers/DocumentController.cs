using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PastoralEmpleo.Data;
using PastoralEmpleo.ViewModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Document = PastoralEmpleo.Models.Document;
using ItextSharpText = iTextSharp.text;

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

        public ActionResult Generar()
        {
            var id = HttpContext.Session.GetInt32("IdCandidate");

            var candidate = db.Candidate.Include(c => c.IdgenderNavigation).FirstOrDefault(e => e.Idcandidate == id);
            var studies = db.Studies.Include(s => s.IdstudylevelNavigation).Where(e => e.Idcandidate == id).ToList();
            var experiences = db.Experience.Include(e => e.IdworkstatusNavigation).Where(e => e.Idcandidate == id).ToList();

            string path = Directory.GetCurrentDirectory();

            ItextSharpText.Document doc = new ItextSharpText.Document();

            var fileName = $"{candidate.Name}-{candidate.Surname}.pdf";

            using (FileStream fileStream = new FileStream($"{path}\\wwwroot\\PdfHojaVida\\{fileName}", FileMode.Create))
            {
                PdfWriter.GetInstance(doc, fileStream);
                doc.Open();

                Paragraph title = new Paragraph
                {
                    Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.Blue)
                };

                doc.Add(title); doc.Add(new Paragraph("HOJA DE VIDA"));

                doc.Add(new Paragraph("-------------------------------------------------------------------------------------------------------------------------------"));

                doc.Add(new Paragraph($" + {candidate.Name} {candidate.Surname}"));
                doc.Add(new Paragraph("DI:" + candidate.Identitydocumento));
                doc.Add(new Paragraph("Correo:" + candidate.Mail));
                doc.Add(new Paragraph("Estado Civil:" + candidate.IdgenderNavigation.Name));
                doc.Add(new Paragraph("FN:" + candidate.Brithdate));
                doc.Add(new Paragraph("Telefono:" + candidate.Telephone));
                doc.Add(new Paragraph("Direccion:" + candidate.Address));
                doc.Add(new Paragraph("Municipio:" + candidate.Municipality));
                doc.Add(new Paragraph("Municipio:" + candidate.District));

                foreach (var study in studies)
                {
                    doc.Add(new Paragraph("-------------------------------------------------------------------------------------------------------------------------------"));

                    doc.Add(title); doc.Add(new Paragraph("FORMACION"));

                    doc.Add(new Paragraph("" + study.School));
                    doc.Add(new Paragraph("Inició:" + study.Startdate));
                    doc.Add(new Paragraph("Finalizó:" + study.Enddate));
                    doc.Add(new Paragraph("Nivel Estudio:" + study.IdstudylevelNavigation.Name));
                    doc.Add(new Paragraph("Titulo Obtenido:" + study.Obtainedtitle));
                }

                doc.Add(new Paragraph("-------------------------------------------------------------------------------------------------------------------------------"));
                
                foreach (var experience in experiences)
                {
                    doc.Add(title); doc.Add(new Paragraph("EXPERIENCIA"));

                    doc.Add(new Paragraph("" + experience.Companyname));
                    doc.Add(new Paragraph("Inició:" + experience.Initialperiod));
                    doc.Add(new Paragraph("Finalizó:" + experience.Endperiod));
                    doc.Add(new Paragraph("Cargo:" + experience.Position));
                    doc.Add(new Paragraph("Estado Laboral:" + experience.IdworkstatusNavigation.Name));
                    doc.Add(new Paragraph("Jefe Inmediato:" + experience.Inmediateboss));
                    doc.Add(new Paragraph("Contacto Jefe:" + experience.Inmediatechiefnumbre));
                }

                doc.Close();
            }

            var stream = new FileStream($".\\wwwroot\\PdfHojaVida\\{fileName}", FileMode.Open);
            return File(stream, "application/pdf", fileName);
        }
    }
}