using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ItextSharpText = iTextSharp.text;

namespace PastoralEmpleo.Controllers
{
    public class EventController : Controller
    {
        private PastoralContext db = new PastoralContext();

        // GET: Login
        public ActionResult Event(int id)
        {
            EventInformationViewModel candidate = new EventInformationViewModel();

            if (id > 0)
            {
                Event eventObject = db.Event.FirstOrDefault(e => e.Idevent == id);

                candidate.Idevent = id;
                candidate.Callnumber = eventObject.Callnumber;
                candidate.Initialeventdate = eventObject.Initialeventdate;
                candidate.Endeventdate = eventObject.Endeventdate;
                candidate.Position = eventObject.Position;
                candidate.Description = eventObject.Description;
                candidate.Product = eventObject.Product;
                candidate.Study = eventObject.Study;
                candidate.Experience = eventObject.Experience;
                candidate.Vacant = eventObject.Vacant;
                candidate.Idcontracttype = eventObject.Idcontracttype;
                candidate.Laboraltime = eventObject.Laboraltime;
                candidate.Place = eventObject.Place;
                candidate.Salary = eventObject.Salary;
                candidate.Idwaytopay = eventObject.Idwaytopay;
                candidate.Initialjobetime = eventObject.Initialjobetime;
                candidate.Endjobtime = eventObject.Endjobtime;
                candidate.Functions = eventObject.Functions;
                candidate.Observations = eventObject.Observations;
            }

            candidate.ContractTypeList = new SelectList(db.Contracttype.ToList(), "Idcontracttype", "Name", 1);
            candidate.WayTopayList = new SelectList(db.Waytopay.ToList(), "Idwaytopay", "Name", 1);
            candidate.StatusList = new SelectList(db.Status.ToList(), "Idstatus", "Name", 1);

            return View(candidate);
        }

        [HttpPost]
        public ActionResult Event(int id, EventInformationViewModel eventViewModel)
        {
            if (ModelState.IsValid)
            {
                Event eventObject = new Event
                {
                    Callnumber = eventViewModel.Callnumber,
                    Initialeventdate = (DateTime)eventViewModel.Initialeventdate,
                    Endeventdate = (DateTime)eventViewModel.Endeventdate,
                    Position = eventViewModel.Position,
                    Description = eventViewModel.Description,
                    Product = eventViewModel.Product,
                    Study = eventViewModel.Study,
                    Experience = eventViewModel.Experience,
                    Vacant = eventViewModel.Vacant,
                    Idcontracttype = eventViewModel.Idcontracttype,
                    Laboraltime = eventViewModel.Laboraltime,
                    Place = eventViewModel.Place,
                    Salary = eventViewModel.Salary,
                    Idwaytopay = eventViewModel.Idwaytopay,
                    Initialjobetime = eventViewModel.Initialjobetime,
                    Endjobtime = eventViewModel.Endjobtime,
                    Functions = eventViewModel.Functions,
                    Observations = eventViewModel.Observations
                };

                if (id > 0)
                {
                    eventObject.Idevent = id;
                    db.Event.Update(eventObject);
                }
                else
                {
                    db.Event.Add(eventObject);
                } 

                db.SaveChanges();

                GeneratePDF(eventObject.Idevent);

                return RedirectToAction("Event");
            }

            return View(eventViewModel);
        }

        public ActionResult EventList(List<Event> events)
        {
            if (!events.Any())
            {
                events = db.Event.ToList();
            }

            return View(events);
        }

        public ActionResult Imprimir(int id)
        {
            var evento = db.Event.FirstOrDefault(e => e.Idevent == id);

            string path = evento.Url;
            var fileName = Path.GetFileNameWithoutExtension(path);

            var stream = new FileStream($".\\wwwroot\\{path}", FileMode.Open);
            return File(stream, "application/pdf", fileName);
        }

        public ActionResult Buscar([Bind("Position")] SearchCallViewModel searchCallViewModel)
        {
            var restult = db.Event.Where(e => e.Position.Contains(searchCallViewModel.Position)).ToList();

            if (restult == null)
            {
                TempData["Error"] = "CARGO NO ENCONTRADO";

                return RedirectToAction("EventSearch");
            }

            return RedirectToAction("EventList", restult);
        }

        public ActionResult EventSearch()
        {
            if (TempData["Error"] != null && !string.IsNullOrEmpty(TempData["Error"].ToString()))
            {
                ViewBag.Error = TempData["Error"].ToString();
            }

            return View();
        }


        #region private methods

        private void GeneratePDF(int id)
        {
            var evento = db.Event.FirstOrDefault(e => e.Idevent == id);

            string path = Directory.GetCurrentDirectory();

            ItextSharpText.Document doc = new ItextSharpText.Document();

            var fileName = $"{evento.Position}.pdf";

            using (FileStream fileStream = new FileStream($"{path}\\wwwroot\\PdfConvocatoria\\{fileName}", FileMode.Create))
            {
                PdfWriter.GetInstance(doc, fileStream);
                doc.Open();

                Paragraph title = new Paragraph
                {
                    Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.Blue)
                };

                doc.Add(title); doc.Add(new Paragraph("PASTORAL SOCIAL"));
                doc.Add(title); doc.Add(new Paragraph("ARQUIDIÓCESIS DE MEDELLÍN"));
                doc.Add(title); doc.Add(new Paragraph("CONVOCATORIA"));
                doc.Add(new Paragraph("DIRECCIÓN: Calle 56 No. 43-24 "));
                doc.Add(new Paragraph("TELEFÓNO:  284 74 11 Fax: 284 77 25"));

                doc.Add(new Paragraph("-------------------------------------------------------------------------------------------------------------------------------"));

                doc.Add(new Paragraph($"Convocatoria #: {evento.Callnumber}"));
                doc.Add(new Paragraph("Fecha Convocatoria:" + evento.Initialeventdate));
                doc.Add(new Paragraph("Fin Convocatoria:" + evento.Endeventdate));

                doc.Add(new Paragraph("-------------------------------------------------------------------------------------------------------------------------------"));

                doc.Add(new Paragraph("Cargo:" + evento.Position));
                doc.Add(new Paragraph("Descripción:" + evento.Description));
                doc.Add(new Paragraph("Producto:" + evento.Product));
                doc.Add(new Paragraph("Estudio:" + evento.Study));
                doc.Add(new Paragraph("Experiencia:" + evento.Experience));
                doc.Add(new Paragraph("Vacante:" + evento.Vacant));
                doc.Add(new Paragraph("Tipo Contrato:" + evento.Idcontracttype));
                doc.Add(new Paragraph("Tiempo Laboral:" + evento.Laboraltime));
                doc.Add(new Paragraph("Lugar de Trabajo:" + evento.Place));
                doc.Add(new Paragraph("Salario:" + evento.Salary));
                doc.Add(new Paragraph("Pago:" + evento.Idwaytopay));
                doc.Add(new Paragraph("Hora Entrada:" + evento.Initialjobetime));
                doc.Add(new Paragraph("Hora Salida:" + evento.Endjobtime));
                doc.Add(new Paragraph("Funciones:" + evento.Functions));
                doc.Add(new Paragraph("Observaciones:" + evento.Observations));

                doc.Add(new Paragraph("-------------------------------------------------------------------------------------------------------------------------------"));


                PdfPTable table = new PdfPTable(9);

                table.AddCell("Basico");
                table.AddCell("Total Horas");
                table.AddCell("Auxi.Transporte");
                table.AddCell("Salud");
                table.AddCell("Pension");
                table.AddCell("Extras Dia");
                table.AddCell("Extras Noche");
                table.AddCell("Recargo");
                table.AddCell("Neto");

                doc.Close();

                evento.Url = $"\\PdfConvocatoria\\{fileName}";
                db.Event.Update(evento);
                db.SaveChanges();
            }
        }

        #endregion
    }
}