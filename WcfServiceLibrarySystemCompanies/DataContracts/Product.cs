using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WcfServiceLibrarySystemCompanies.DataContracts
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public string ProductDescription { get; set; }

        [DataMember]
        public int IdProduct { get; set; }

        [DataMember]
        public string Method { get; set; }

        [DataMember]
        public List<Tuple<int, string>> list { get; set; }

        [DataMember]
        public string ProductData { get; set; }

        [DataMember]
        public DataSet ProductDataSet { get; set; }

        [DataMember]
        public bool isBool { get; set; }
        
        [DataMember]
        public int ProductCount { get; set; }
       
        [DataMember]        
        public int ProductCostPrice { get; set; }
       
        [DataMember]       
        public DateTime? ProductDate { get; set; }
    }
}
