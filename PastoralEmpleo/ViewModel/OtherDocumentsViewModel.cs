using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using PastoralEmpleo.Shared.Validations;
using System.ComponentModel.DataAnnotations;


namespace PastoralEmpleo.ViewModel
{
    public class OtherDocumentsViewModel
    {
        
        [Display(Name = "Tipo Documento")]
        public int Iddocumenttype { get; set; }
        public SelectList DocumentTypeList { get; set; }

        public string Name { get; set; }

        [Display(Name = "Adjunta Documento")]
        public string FilePath { get; set; }

        [AllowedExtensions(new string[] { ".pdf" })]
        public IFormFile File { get; set; }
    }

   
}
