﻿using System;
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
    public class ListController : Controller
    {
        private PastoralContext db = new PastoralContext();
        // GET: List
       

        // GET: List/Details/5
        public ActionResult EmploymentListing()
        {
            var a = db.Experience.ToList();
            return View(a);         
        }      


        // GET: List/Edit/5
        public ActionResult Edit()
        {
            return View();
        }       

        
    }
}