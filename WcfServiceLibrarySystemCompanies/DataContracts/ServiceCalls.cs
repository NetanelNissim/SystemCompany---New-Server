﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfServiceLibrarySystemCompanies.DataContracts
{
    [DataContract]
    public class ServiceCalls
    {
        [DataMember]
        public DateTime dateOpenCalls { get; set; }

        [DataMember]
        public string discriptions { get; set; }
        
        [DataMember]
        public string status { get; set; }
  
        [DataMember]
        public string companyName { get; set; }
        [DataMember]
        public int idCompany { get; set; }

        [DataMember]
        public int idPriority { get; set; }

        [DataMember]
        public int idServiceCall { get; set; }

        [DataMember]
        public double daysToShow { get; set; }

        [DataMember]
        public string Method { get; set; }

        [DataMember]
        public string DataServiceCalls { get; set; }

        [DataMember]
        public DataSet DataServiceCallsDataSet { get; set; }

        [DataMember]
        public string DataServiceCallsBetweenDate { get; set; }

        [DataMember]
        public DataSet DataServiceCallsBetweenDateDataSet { get; set; }

        [DataMember]
        public bool isBool { get; set; }
    }
}
