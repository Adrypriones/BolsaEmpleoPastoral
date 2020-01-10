using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Data;
using PastoralEmpleo.Models;
using PastoralEmpleo.ViewModel;

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


    }
}