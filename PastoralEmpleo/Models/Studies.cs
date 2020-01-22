using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Studies
    {
        public int Idstudies { get; set; }
        public string Obtainedtitle { get; set; }
        public string School { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public int? Idcandidate { get; set; }
        public int? Idstudylevel { get; set; }
        public int? Idacademicstate { get; set; }
        public int? Idperiodicity { get; set; }
        public int? Iddocumenttype { get; set; }

        public Academicstate IdacademicstateNavigation { get; set; }
        public Candidate IdcandidateNavigation { get; set; }
        public Periodicity IdperiodicityNavigation { get; set; }
        public Studylevel IdstudylevelNavigation { get; set; }
        public Documenttype IddocumenttypeNavigation { get; set; }
    }
}
