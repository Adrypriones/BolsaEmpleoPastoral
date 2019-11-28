using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Contracttype
    {
        public Contracttype()
        {
            Event = new HashSet<Event>();
        }

        public int Idcontracttype { get; set; }
        public string Name { get; set; }

        public ICollection<Event> Event { get; set; }
    }
}
