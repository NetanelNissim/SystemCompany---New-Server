using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.ServiceModel;
using System.Data;

namespace WcfServiceLibrarySystemCompanies
{
    [DataContract]
    public class Companies
    {
        [DataMember]
        public string companyName { get; set; }
        [DataMember]
        public string contactName { get; set; }
        [DataMember]
        public string mobilePhone { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string FAX { get; set; }
        [DataMember]
        public string companynumber { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public string city { get; set; }
        [DataMember]
        public string ZIP { get; set; }
        [DataMember]
        public string PostalNum { get; set; }
        [DataMember]
        public int idCompany { get; set; }
        [DataMember]
        public string paymentTerms { get; set; }
        [DataMember]
        public string Method { get; set; }
        [DataMember]
        public bool isBool { get; set; }
        [DataMember]
        public List<Tuple<string, int>> list { get; set; }
        [DataMember]
        public string stringData { get; set; }
        [DataMember]
        public DataTable EmployeeTable { get; set;} 
        [DataMember]
        public DataSet EmployeeDataSet { get; set;} 

    }
}
