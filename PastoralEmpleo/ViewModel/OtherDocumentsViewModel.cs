using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PastoralEmpleo.ViewModel
{
    public class OtherDocumentsViewModel
    {
        
        [Display(Name = "Tipo Documento")]
        public int Iddocumenttype { get; set; }
        public SelectList DocumentTypeList { get; set; }
    }

   
}
