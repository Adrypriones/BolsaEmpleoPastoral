using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Shared.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace PastoralEmpleo.ViewModel
{
    public class ExperienceInformationViewModel
    {
        [Display(Name = "Empresa")]
        public string Companyname { get; set; }

        [Display(Name = "Cargo")]
        public string Position { get; set; }

        [Display(Name = "Estado Laboral")]
        public int? Idworkstatus { get; set; }
        public SelectList WorkStatusList { get; set; }

        [DateValidation]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Ingreso")]
        public DateTime? Initialperiod { get; set; }

        [DateValidation]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Salida")]
        public DateTime? Endperiod { get; set; }

        [Display(Name = "Jefe Inmediato")]
        public string Inmediateboss { get; set; }

        [Display(Name = "Contacto Jefe")]
        public string Inmediatechiefnumbre { get; set; }

        [Display(Name = "Adjunte Certificado")]
        public string FilePath { get; set; }

        public IFormFile File { get; set; }

        public int Iddocumenttype { get; set; }

        public int Idexperience { get; set; }
    }
}
