using System.ComponentModel.DataAnnotations;

namespace PastoralEmpleo.ViewModel
{
    public class CurriculumVitaeSearch
    {
        [Display(Name = "Cargo")]
        public string Position { get; set; }
        
    }
}

