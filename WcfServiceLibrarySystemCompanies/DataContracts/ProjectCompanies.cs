using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfServiceLibrarySystemCompanies.DataContracts
{
    [DataContract]
    public class ProjectCompanies
    {
        [DataMember]
        public int IdProject { get; set; }
        [DataMember]
        public int IdCompany { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public string ProjectName { get; set; }
        [DataMember]
        public string PriceType { get; set; }
        [DataMember]
        public string Discriptions { get; set; }
        [DataMember]
        public DateTime? DateStartProject { get; set; }
        [DataMember]
        public DateTime? DateFinishProject { get; set; }
        [DataMember]
        public string Paid { get; set; }
        [DataMember]
        public string Destination { get; set; }
    }
}
