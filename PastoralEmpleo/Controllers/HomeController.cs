using Microsoft.AspNetCore.Mvc;
using PastoralEmpleo.Data;
using PastoralEmpleo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PastoralEmpleo.Controllers
{
    public class HomeController : Controller
    {
        private PastoralContext db = new PastoralContext();

        public IActionResult Index()
        {
            List<IndexConvocatoriaViewModel> convocatoria = new List<IndexConvocatoriaViewModel>();

            var eventList = db.Event.Where(e => e.Initialeventdate < DateTime.Now && e.Endeventdate > DateTime.Now).ToList();

            foreach (Models.Event eve in eventList)
            {
                convocatoria.Add(new IndexConvocatoriaViewModel
                {
                    Url = $"{eve.Url}",
                    Position = eve.Position
                });                
            }

            return View(convocatoria);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
