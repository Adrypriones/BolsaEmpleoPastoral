using System;
using System.Collections.Generic;

namespace PastoralEmpleo.Models
{
    public partial class Event
    {
        public int Idevent { get; set; }
        public int Callnumber { get; set; }
        public string Position { get; set; }
        public TimeSpan Initialjobetime { get; set; }
        public TimeSpan Endjobtime { get; set; }
        public string Study { get; set; }
        public string Experience { get; set; }
        public string Functions { get; set; }
        public decimal Salary { get; set; }
        public string Observations { get; set; }
        public DateTime Initialeventdate { get; set; }
        public DateTime Endeventdate { get; set; }
        public int? Idstatus { get; set; }
        public string Description { get; set; }
        public string Product { get; set; }
        public int Vacant { get; set; }
        public string Laboraltime { get; set; }
        public string Place { get; set; }
        public int? Idcontracttype { get; set; }
        public int? Idwaytopay { get; set; }
        public string Url { get; set; }

        public Contracttype IdcontracttypeNavigation { get; set; }
        public Status IdstatusNavigation { get; set; }
        public Waytopay IdwaytopayNavigation { get; set; }
    }
}
