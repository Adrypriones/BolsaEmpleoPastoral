using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Shared.Enums;

namespace PastoralEmpleo.ViewModel
{
    public class CandidateInformationViewModel
    {
        [Display(Name = "Tipo Documento")]
        public int Iddocumenttype { get; set; }
        public IEnumerable<SelectListItem>Documenttype{ get; set; }

        [Display(Name = "Documento Identidad")]
        public int Identitydocumento { get; set; }

        [Display(Name = "Ajuntar Documento")]
        public string Documenttipe { get; set; }

        [Display(Name = "Apellido")]
        public string Surname { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        public string Mail { get; set; }

        [Display(Name = "Sexo")]
        public int Idgender { get; set; }
        public IEnumerable<SelectListItem> Gender { get; set; }

        [Display(Name = "Estado Civil")]
        public int Idcivilstatus { get; set; }
        public SelectList CivilStatusList { get; set; }

        [Display(Name = "Fecha Nacimento")]
        public DateTime Brithdate  { get; set; }

        [Display(Name = "Teléfono")]
        public int Telephone { get; set; }

        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Municipio")]
        public string Municipality { get; set; }

        [Display(Name = "Barrio")]
        public string District { get; set; }
    }
}
