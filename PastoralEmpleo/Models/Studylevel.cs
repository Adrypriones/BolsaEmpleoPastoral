using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Studylevel
    {
        public Studylevel()
        {
            Studies = new HashSet<Studies>();
        }

        public int Idstudylevel { get; set; }
        public string Name { get; set; }

        public ICollection<Studies> Studies { get; set; }
    }
}
