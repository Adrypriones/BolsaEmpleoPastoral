using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Experience
    {
        public int Idexperience { get; set; }
        public string Companyname { get; set; }
        public string Position { get; set; }
        public DateTime Initialperiod { get; set; }
        public DateTime Endperiod { get; set; }       
        public int? Idworkstatus { get; set; }
        public int? Idcandidate { get; set; }
        public string Inmediateboss { get; set; }
        public string Inmediatechiefnumbre { get; set; }
        public int? Iddocumenttype { get; set; }

        public Candidate IdcandidateNavigation { get; set; }
        public Workstatus IdworkstatusNavigation { get; set; }
        public Documenttype IddocumenttypeNavigation { get; set; }
    }
}
