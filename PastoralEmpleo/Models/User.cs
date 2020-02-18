using System.ComponentModel.DataAnnotations;



namespace PastoralEmpleo.Models
{
    public partial class User
    {
        public int Iduser { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        public string Surname { get; set; }

        [Display(Name = "Correo")]
        public string Mail { get; set; }

        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        public int IdRole { get; set; }

        public Candidate Candidate { get; set; }
        public Role Role { get; set; }
    }
}
