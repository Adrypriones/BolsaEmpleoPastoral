using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Document
    {
        public int Iddocument { get; set; }
        public int? Idrequireddocument { get; set; }
        public string Documenttipe { get; set; }
        public string Url { get; set; }
        public int? Idcandidate { get; set; }

        public Candidate IdcandidateNavigation { get; set; }
        public Requireddocument IdrequireddocumentNavigation { get; set; }
    }
}
