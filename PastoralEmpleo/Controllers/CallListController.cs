using Microsoft.AspNetCore.Mvc;
using PastoralEmpleo.Data;
using System.IO;
using System.Linq;

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

            string path = evento.Url;
            var fileName = Path.GetFileNameWithoutExtension(path);

            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", fileName);
        }
    }
}