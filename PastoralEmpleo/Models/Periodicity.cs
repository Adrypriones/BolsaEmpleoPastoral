using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Periodicity
    {
        public Periodicity()
        {
            Studies = new HashSet<Studies>();
        }

        public int Idperiodicity { get; set; }
        public string Name { get; set; }

        public ICollection<Studies> Studies { get; set; }
    }
}
