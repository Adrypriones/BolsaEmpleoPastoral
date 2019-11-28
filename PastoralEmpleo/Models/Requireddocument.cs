using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Requireddocument
    {
        public Requireddocument()
        {
            Document = new HashSet<Document>();
        }

        public int IdrequiredDocument { get; set; }
        public string Name { get; set; }

        public ICollection<Document> Document { get; set; }
    }
}
