using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ServiceCalls
    {

        public ServiceCalls(string status, string TypePriority, string companyName, int idCallsServices, DateTime? dateOpenCalls, string discriptions, int idCompany, int idPriority)
        {
            //for Insert
            this.idCompany = idCompany;
            this.dateOpenCalls = dateOpenCalls;
            this.discriptions = discriptions;
            this.idPriority = idPriority;
            this.idCallsServices = idCallsServices;
            this.TypePriority = TypePriority;
            this.companyName = companyName;
            this.status = status;

        }
        public ServiceCalls(DateTime dateOpenCalls, string discriptions, int idCompany, int idPriority, string status)
        {
            //for Insert
             this.idCompany = idCompany;
             this.dateOpenCalls = dateOpenCalls;
             this.discriptions = discriptions;
             this.idPriority = idPriority;
             this.status = status;
        }

        public ServiceCalls(DateTime dateOpenCalls)
        {
            this.dateOpenCalls = dateOpenCalls;
        }

        public ServiceCalls(string discriptions, int idCallsServices, string status)
        {
            //For Update
            this.discriptions = discriptions;
            this.status = status;
            this.idCallsServices = idCallsServices;
        }


        public ServiceCalls(int idCallsServices)
        {
            //For Delete
            this.idCallsServices = idCallsServices;
        }

        public ServiceCalls()
        { 
        
        }

        public string status { get; set; }
        public DateTime? dateOpenCalls { get; set; }
        public string discriptions { get; set; }
        public string companyName { get; set; }
        public string TypePriority { get; set; }
        public int idCallsServices { get; set; }
        public int idCompany { get; set; }
        public int idPriority { get; set; }
           

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
