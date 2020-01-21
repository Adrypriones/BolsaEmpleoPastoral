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
    public class CallListController : Controller
    {
        private PastoralContext db = new PastoralContext();
        
        public ActionResult IndexCallList()
        {
            var a = db.Event.ToList();
            return View(a);
        }

        public ActionResult Imprimir(int id)
        {
            var evento = db.Event.FirstOrDefault(e => e.Idevent == id);

            string path = Directory.GetCurrentDirectory();

            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream($"{path}/PdfConvocatoria/{evento.Position}.pdf", FileMode.Create));
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

            return Redirect("/PdfConvocatoria/{evento.Position}.pdf");
        }
    }
}