namespace PastoralEmpleo.Models
{
    public partial class Document
    {
        public int Iddocument { get; set; }
        public int? Iddocumenttype { get; set; }        
        public string Url { get; set; }
        public int? Idcandidate { get; set; }

        public Candidate IdcandidateNavigation { get; set; }
        public Documenttype IddocumenttypeNavigation { get; set; }
    }
}
