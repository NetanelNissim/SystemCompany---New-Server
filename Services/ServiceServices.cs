using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;
using System.Data;

namespace Services
{
    public class ServiceServices
    {
        private static ServiceServices instance;
        public static ServiceServices Instance
        {
            get { return instance ?? (instance = new ServiceServices()); }
        }

        public void InsertService(string serviceName, string serviceDescription)
        {
            ServicesPersister.Instance.InsertService(serviceName, serviceDescription);
        }

        public void UpdateService(string serviceName, int idService, string serviceDescription)
        {
            ServicesPersister.Instance.UpdateService(serviceName, idService, serviceDescription);
        }

        public DataTable GetAllService()
        {
            return DataTableCreator.Instance.ConvertListToDataTable(ServicesPersister.Instance.GetAllServices().ToList<Entities.Services>());
        }

        public void DeleteService(int idService)
        {
            try
            {
                ServicesPersister.Instance.DeleteService(idService);
            }
            catch(ExecutionEngineException)
            {
                throw;
            }
        }

        public List<Tuple<int, string>> GetAllServiceToDropDown()
        {
           var service =  ServicesPersister.Instance.GetAllServices();
           var list = new List<Tuple<int, string>>();
           foreach (var item in service)
           {
               list.Add(new Tuple<int, string>(item.idService , item.servicesName));
           }
           return list;
        }

        public bool CheckServiceId(int id)
        {
            var list = ServicesPersister.Instance.CheckServiceId();
            foreach (var item in list)
            {
                if (item.idService == id) return false;
            }
            return true;
        }

    }
}
