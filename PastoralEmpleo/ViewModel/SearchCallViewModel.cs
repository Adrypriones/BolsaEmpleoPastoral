using System.ComponentModel.DataAnnotations;

namespace PastoralEmpleo.ViewModel
{
    public class SearchCallViewModel
    {
        [Display(Name = "Cargo")]
        public string Position { get; set; }

        [Display(Name = "Número Convocatoria")]
        public int Callnumber { get; set; }
    }
}
