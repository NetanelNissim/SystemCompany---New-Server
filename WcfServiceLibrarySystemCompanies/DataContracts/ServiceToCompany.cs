using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfServiceLibrarySystemCompanies.DataContracts
{
    [DataContract]
    public class ServiceToCompany
    {
        [DataMember]
        public DateTime Startdate { get; set; }
        [DataMember]
        public DateTime Enddate { get; set; }
        [DataMember]
        public bool Paid { get; set; }
        [DataMember]
        public string Price { get; set; }
        [DataMember]
        public string priceCost { get; set; }
        [DataMember]
        public int idCompany { get; set; }
        [DataMember]
        public int idService { get; set; }
        [DataMember]
        public string Method { get; set; }
        [DataMember]
        public string DataServiceToCompany { get; set; }
        [DataMember]
        public DataSet ServiceToCompanyDataSet { get; set; }
        [DataMember]
        public bool isBool { get; set; }
    }
}
