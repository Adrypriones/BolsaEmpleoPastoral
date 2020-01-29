using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System.IO;
using System.Linq;
using ItextSharpText = iTextSharp.text;

namespace PastoralEmpleo.Controllers
{
    public class EventController : Controller
    {
        private PastoralContext db = new PastoralContext();

        // GET: Login
        public ActionResult Event()
        {
            EventInformationViewModel candidate = new EventInformationViewModel();

            candidate.ContractTypeList = new SelectList(db.Contracttype.ToList(), "Idcontracttype", "Name", 1);
            candidate.WayTopayList = new SelectList(db.Waytopay.ToList(), "Idwaytopay", "Name", 1);
            candidate.StatusList = new SelectList(db.Status.ToList(), "Idstatus", "Name", 1);

            return View(candidate);
        }

        public ActionResult Guardar([Bind("Callnumber,Initialeventdate,Endeventdate,Position,Description,Product,Study,Experience,Vacant,Idcontracttype,Laboraltime,Place,Salary,Idwaytopay,Initialjobetime,Endjobtime,Functions,Observations")] EventInformationViewModel eventViewModel)
        {
            if (ModelState.IsValid)
            {
                Event eventObject = new Event();

                eventObject.Callnumber = eventViewModel.Callnumber;
                eventObject.Initialeventdate = eventViewModel.Initialeventdate;
                eventObject.Endeventdate = eventViewModel.Endeventdate;
                eventObject.Position = eventViewModel.Position;
                eventObject.Description = eventViewModel.Description;
                eventObject.Product = eventViewModel.Product;
                eventObject.Study = eventViewModel.Study;
                eventObject.Experience = eventViewModel.Experience;
                eventObject.Vacant = eventViewModel.Vacant;
                eventObject.Idcontracttype = eventViewModel.Idcontracttype;
                eventObject.Laboraltime = eventViewModel.Laboraltime;
                eventObject.Place = eventViewModel.Place;
                eventObject.Salary = eventViewModel.Salary;
                eventObject.Idwaytopay = eventViewModel.Idwaytopay;
                eventObject.Initialjobetime = eventViewModel.Initialjobetime;
                eventObject.Endjobtime = eventViewModel.Endjobtime;
                eventObject.Functions = eventViewModel.Functions;
                eventObject.Observations = eventViewModel.Observations;

                db.Event.Add(eventObject);
                db.SaveChanges();

                GeneratePDF(eventObject.Idevent);

                return RedirectToAction("Event");
            }

            return View(eventViewModel);
        }


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

                Paragraph title = new Paragraph();
                title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.Blue);
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
    }
}