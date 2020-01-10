using System;
using System.Collections.Generic;
using PastoralEmpleo.Models;
using System.ComponentModel.DataAnnotations;

namespace PastoralEmpleo.Models
{
    public partial class Candidate
    {
        public int Idcandidate { get; set; }       
        public string Name { get; set; }        
        public string Surname { get; set; }        
        public int Identitydocumento { get; set; }       
        public string Mail { get; set; }        
        public string Telephone { get; set; }        
        public string Address { get; set; }       
        public DateTime? Brithdate { get; set; }
        public int? Iduser { get; set; }
        public int? Idcivilstatus { get; set; }
        public int? Idgender { get; set; }        
        public string Municipality { get; set; }        
        public string District { get; set; }
        public int? Iddocumenttype { get; set; }
        public Civilstatus IdcivilstatusNavigation { get; set; }
        public Documenttype IddocumenttypeNavigation { get; set; }
        public Gender IdgenderNavigation { get; set; }
        public User IduserNavigation { get; set; }        
        public Document Document { get; set; }
        public Experience Experience { get; set; }
        public Studies Studies { get; set; }
    }
}
