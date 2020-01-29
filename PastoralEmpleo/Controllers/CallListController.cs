using Microsoft.AspNetCore.Mvc;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PastoralEmpleo.Controllers
{
    public class CallListController : Controller
    {
        private PastoralContext db = new PastoralContext();

        public ActionResult IndexCallList(List<Event> events)
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

                return RedirectToAction("IndexSearchCall");
            }

            return RedirectToAction("IndexCallList", restult);
        }

        public ActionResult IndexSearchCall()
        {
            if (TempData["Error"] != null && !string.IsNullOrEmpty(TempData["Error"].ToString()))
            {
                ViewBag.Error = TempData["Error"].ToString();
            }

            return View();
        }
    }
}