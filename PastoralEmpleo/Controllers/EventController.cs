using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Reflection;

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
                Event candidate = new Event();

                candidate.Callnumber = eventViewModel.Callnumber;
                candidate.Initialeventdate = eventViewModel.Initialeventdate;
                candidate.Endeventdate = eventViewModel.Endeventdate;
                candidate.Position = eventViewModel.Position;
                candidate.Description = eventViewModel.Description;
                candidate.Product = eventViewModel.Product;
                candidate.Study = eventViewModel.Study;
                candidate.Experience = eventViewModel.Experience;
                candidate.Vacant = eventViewModel.Vacant;
                candidate.Idcontracttype = eventViewModel.Idcontracttype;
                candidate.Laboraltime = eventViewModel.Laboraltime;
                candidate.Place = eventViewModel.Place;
                candidate.Salary = eventViewModel.Salary;
                candidate.Idwaytopay = eventViewModel.Idwaytopay;
                candidate.Initialjobetime = eventViewModel.Initialjobetime;
                candidate.Endjobtime = eventViewModel.Endjobtime;
                candidate.Functions = eventViewModel.Functions;
                candidate.Observations = eventViewModel.Observations;

                db.Event.Add(candidate);
                db.SaveChanges();
                return RedirectToAction("Event");
            }

            return View(eventViewModel);

        }

        public ActionResult Imprimir(int id)
        {

            var evento = db.Event.FirstOrDefault(e => e.Idevent == id);           


            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream($"{("~/Pdf")}/hola.pdf", FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 18f, BaseColor.Blue);
            title.Add("PASTORAL SOCIAL");
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
            doc.Add(new Paragraph("Descripción" + evento.Description));
            doc.Add(new Paragraph("Producto:" + evento.Product ));
            doc.Add(new Paragraph("Estudio:" + evento.Study));
            doc.Add(new Paragraph("Experiencia:" + evento.Experience ));
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
                                                                    

            doc.Add(table);
            doc.Close();

            return Redirect("/Pdf/hola.pdf");
        }        

    }
}