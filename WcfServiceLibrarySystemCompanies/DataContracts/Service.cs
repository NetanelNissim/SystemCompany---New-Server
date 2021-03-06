﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfServiceLibrarySystemCompanies.DataContracts
{
    [DataContract]
    public class Service
    {
        [DataMember]
        public string ServiceName { get; set; }

        [DataMember]
        public string serviceDescription { get; set; }

        [DataMember]
        public int IdService { get; set; }

        [DataMember]
        public string Method { get; set; }

        [DataMember]
        public List<Tuple<int, string>> list { get; set; }

        [DataMember]
        public string ServiceData { get; set; }

        [DataMember]
        public DataSet ServiceDataSet { get; set; }

        [DataMember]
        public bool isBool { get; set; }


    }
}
