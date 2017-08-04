using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Services
    {
        public Services(string servicesName, int idService, string serviceDescription)
        {
            this.servicesName = servicesName;
            this.idService = idService;
            this.serviceDescription = serviceDescription;
        }

        public Services(string servicesName, string serviceDescription)
        {
            this.servicesName = servicesName;
            this.serviceDescription = serviceDescription;
        }

        public Services()
        { 
        
        }

        public Services(int idService)
        {
            this.idService = idService;
        }
        public string serviceDescription { get; set; }
        public string servicesName { get; set; }
        public int idService { get; set; }

           

    /*    public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("Name = {0}; ", this.Name));
            sb.Append(string.Format("Address = {0}; ", this.Address));
           // sb.AppendLine(string.Format("Id = {0}.", this.Id));
            return sb.ToString();

        }*/
    }
}
