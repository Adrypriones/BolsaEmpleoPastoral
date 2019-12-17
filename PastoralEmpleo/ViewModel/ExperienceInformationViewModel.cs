using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Shared.Enums;


namespace PastoralEmpleo.ViewModel
{
    public class ExperienceInformationViewModel
    {
        [Display(Name = "Empresa")]
        public string Companyname { get; set; }

        [Display(Name = "Cargo")]
        public string Position { get; set; }

        [Display(Name = "Estado Laboral")]
        public int Idworkstatus { get; set; }
        public SelectList WorkStatusList { get; set; }
        
        [Display(Name = "Fecha Ingreso")]
        public DateTime initialperiod { get; set; }

        [Display(Name = "Fecha Salida")]
        public DateTime Endperiod { get; set; }

        [Display(Name = "Jefe Inmediato")]
        public string Inmediateboss { get; set; }

        [Display(Name = "Contacto Jefe")]
        public string Inmediatechiefnumbre { get; set; }
    }
}
