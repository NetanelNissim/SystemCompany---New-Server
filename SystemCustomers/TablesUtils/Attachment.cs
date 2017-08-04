using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemCustomers.TablesUtils
{
   public class Attachment
    {
       public int  idProject {get; set; }
       public int  idCompany {get; set; }
       public string fileName { get; set; }
       public int fileSize { get; set; }
       public byte[] attachment { get; set; }
    }
}
