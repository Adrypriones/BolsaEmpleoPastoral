using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Candidate = new HashSet<Candidate>();
        }

        public int Idgender { get; set; }
        public string Name { get; set; }

        public ICollection<Candidate> Candidate { get; set; }
    }
}
