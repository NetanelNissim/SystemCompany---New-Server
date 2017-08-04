using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfServiceLibrarySystemCompanies.DataContracts
{
    [DataContract]
    public class DateProjectCompanies
    {
        [DataMember]
        public int idProject { get; set; }
        [DataMember]
        public int idCompany { get; set; }
        [DataMember]
        public DateTime? DateStartProject { get; set; }
        [DataMember]
        public DateTime? DateFinishProject { get; set; }

    }
}
