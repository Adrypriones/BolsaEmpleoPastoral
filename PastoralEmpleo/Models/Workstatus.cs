using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Workstatus
    {
        public Workstatus()
        {
            Experience = new HashSet<Experience>();
        }

        public int Idworkstatus { get; set; }
        public string Name { get; set; }

        public ICollection<Experience> Experience { get; set; }
    }
}
