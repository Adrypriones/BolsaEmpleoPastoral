using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Civilstatus
    {
        public Civilstatus()
        {
            Candidate = new HashSet<Candidate>();
        }

        public int Idcivilstatus { get; set; }
        public string Name { get; set; }

        public ICollection<Candidate> Candidate { get; set; }
    }
}
