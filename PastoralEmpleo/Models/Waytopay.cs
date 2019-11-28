using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Waytopay
    {
        public Waytopay()
        {
            Event = new HashSet<Event>();
        }

        public int Idwaytopay { get; set; }
        public string Name { get; set; }

        public ICollection<Event> Event { get; set; }
    }
}
