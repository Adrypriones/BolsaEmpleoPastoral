﻿using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Documenttype
    {
        public Documenttype()
        {
            Candidate = new HashSet<Candidate>();
        }

        public int Iddocumenttype { get; set; }
        public string Name { get; set; }
        public int SubType { get; set; }

        public ICollection<Candidate> Candidate { get; set; }
        public ICollection<Document> Document { get; set; }
    }
}
