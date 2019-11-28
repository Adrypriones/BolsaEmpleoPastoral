using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class User
    {
        public int Iduser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public Candidate Candidate { get; set; }
    }
}
