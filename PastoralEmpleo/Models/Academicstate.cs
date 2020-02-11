using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Academicstate
    {
        public Academicstate()
        {
            Studies = new HashSet<Studies>();
        }

        public int Idacademicstate { get; set; }
        public string Name { get; set; }

        public ICollection<Studies> Studies { get; set; }
    }
}
