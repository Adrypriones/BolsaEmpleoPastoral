using Microsoft.AspNetCore.Mvc;
using PastoralEmpleo.Data;
using System.Linq;

namespace PastoralEmpleo.Controllers

{
    public class StudyListingController : Controller
    {
        private PastoralContext db = new PastoralContext();

        public ActionResult Index()
        {
            var a = db.Studies.ToList();
            return View(a);
        }
    }
}