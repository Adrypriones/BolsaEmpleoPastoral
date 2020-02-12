using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Shared.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace PastoralEmpleo.ViewModel
{
    public class CandidateInformationViewModel
    {
        [Display(Name = "Tipo Documento")]
        public int? Iddocumenttype { get; set; }
        public SelectList DocumenttypeList { get; set; }

        [Display(Name = "Documento Identidad")]
        public int Identitydocumento { get; set; }

        [Display(Name = "Adjunta Documento")]
        public string FilePath { get; set; }

        [AllowedExtensions(new string[] { ".pdf" })]
        public IFormFile File { get; set; }

        [Display(Name = "Apellido")]
        public string Surname { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        public string Mail { get; set; }

        [Display(Name = "Sexo")]
        public int? Idgender { get; set; }
        public SelectList GenderList { get; set; }

        [Display(Name = "Estado Civil")]
        public int? Idcivilstatus { get; set; }
        public SelectList CivilStatusList { get; set; }

        [DateValidation]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimento")]
        public DateTime? Brithdate  { get; set; }

        [Display(Name = "Teléfono")]
        public string Telephone { get; set; }

        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Municipio")]
        public string Municipality { get; set; }

        [Display(Name = "Barrio")]
        public string District { get; set; }        

    }
}
