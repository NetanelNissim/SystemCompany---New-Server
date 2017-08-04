﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfServiceLibrarySystemCompanies
{
    [DataContract]
    public class Priority
    {
        [DataMember]
        public string TypePriority { get; set; }

        [DataMember]
        public int IdPriority { get; set; }

        [DataMember]
        public string PriorityData { get; set; }

        [DataMember]
        public string Method {get;set;}

        [DataMember]
        public List<Tuple<int, string>> list { get; set;}

        [DataMember]
        public bool isBool { get; set; }

        [DataMember]
        public DataSet PriorityDataSet { get; set; } 
       

    }
}
