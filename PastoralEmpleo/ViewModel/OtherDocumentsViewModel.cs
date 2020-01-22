using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;


namespace PastoralEmpleo.ViewModel
{
    public class OtherDocumentsViewModel
    {
        
        [Display(Name = "Tipo Documento")]
        public int Iddocumenttype { get; set; }
        public SelectList DocumentTypeList { get; set; }

        [Display(Name = "Adjunta Documento")]
        public string FilePath { get; set; }

        public IFormFile File { get; set; }
    }

   
}
