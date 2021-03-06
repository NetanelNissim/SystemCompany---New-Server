﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Services;
using WcfServiceLibrarySystemCompanies.DataContracts;
using System.Data;

namespace WcfServiceLibrarySystemCompanies
{
    public class ServiceService 
    {
        public void Insert(Service service)
        {
            ServiceServices.Instance.InsertService(service.ServiceName, service.serviceDescription);
        }

        public void UpdateService(Service service)
        {
            ServiceServices.Instance.UpdateService(service.ServiceName, service.IdService, service.serviceDescription);
        }

        public string GetAllService()
        {
            return Utils.ConvertDataTableToXML(ServiceServices.Instance.GetAllService(), "Service");
        }
        
        public DataSet GetAllServiceDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(ServiceServices.Instance.GetAllService());
            return ds;
         }

        public void DeleteService(Service service)
        {
            try
            {
                ServiceServices.Instance.DeleteService(service.IdService);
            }
            catch (DbException e)
            {
                throw new FaultException(
                    new FaultReason(e.Message),
                    new FaultCode("Data Access Error"));
            }
        }

        public List<Tuple<int, string>> GetAllServiceToDropDown()
        {
            return ServiceServices.Instance.GetAllServiceToDropDown();
        }

        public bool CheckServiceId(Service service)
        {
            return ServiceServices.Instance.CheckServiceId(service.IdService);
        }
    }
}
