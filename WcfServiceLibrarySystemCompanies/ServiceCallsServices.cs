﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WcfServiceLibrarySystemCompanies.DataContracts;

namespace WcfServiceLibrarySystemCompanies
{
    public class ServiceCallsServices 
    {
        public void InsertServiceCalls(ServiceCalls serviceCall)
        {
            Services.ServiceCallsServices.Instance.InsertServiceCalls(serviceCall.dateOpenCalls,serviceCall.discriptions,serviceCall.idCompany,serviceCall.idPriority,serviceCall.status  );
        }

        public void UpdateServiceCalls(ServiceCalls serviceCall)
        {
            Services.ServiceCallsServices.Instance.UpdateServiceCalls(serviceCall.discriptions,serviceCall.idServiceCall,serviceCall.status);
        }

        public string GetAllServiceCalls()
        {
         return Utils.ConvertDataTableToXML(Services.ServiceCallsServices.Instance.GetAllServiceCalls(), "ServiceCall");
        }

        public DataSet GetAllServiceCallsDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(Services.ServiceCallsServices.Instance.GetAllServiceCalls());
            return ds;
        }

        public string GetServiceCallsBetweenDate(ServiceCalls serviceCall)
        {
            return Utils.ConvertDataTableToXML(Services.ServiceCallsServices.Instance.GetServiceCallsBetweenDate(serviceCall.daysToShow), "ServiceCallsBetweenDate");
        }

        public DataSet GetServiceCallsBetweenDateDataSet(ServiceCalls serviceCall)
        {   
            DataSet ds = new DataSet();
            ds.Tables.Add(Services.ServiceCallsServices.Instance.GetServiceCallsBetweenDate(serviceCall.daysToShow));
            return ds;
        }

        public void DeleteServiceCalls(ServiceCalls serviceCall)
        {
            Services.ServiceCallsServices.Instance.DeleteServiceCalls(serviceCall.idServiceCall);
        }

        public DateTime ConvertDoubleToDateTime(ServiceCalls serviceCall)
        {
           return Services.ServiceCallsServices.Instance.ConvertDoubleToDateTime(serviceCall.daysToShow);
        }

        internal bool CheckServiceCall(ServiceCalls serviceCall)
        {
            return Services.ServiceCallsServices.Instance.CheckServiceCall(serviceCall.idServiceCall);
        }
    }
}
