using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Shared.Enums;

namespace PastoralEmpleo.ViewModel
{
    public class DocumentRequiredViewModel
    {
        [Display(Name = "Tipo Documento")]
        public string Documenttipe { get; set; }
    }
}
