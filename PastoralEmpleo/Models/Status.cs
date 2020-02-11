using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Status
    {
        public Status()
        {
            Event = new HashSet<Event>();
        }

        public int Idstatus { get; set; }
        public string Name { get; set; }

        public ICollection<Event> Event { get; set; }
    }
}
