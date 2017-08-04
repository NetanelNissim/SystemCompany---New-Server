using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using EntityFrameworkDAL;
using Server;
using Extensions;


namespace DataAccessLayer
{
    public class ServicesPersister 
    {
        #region Singleton
        private ServicesPersister()
        {
        }
        private static ServicesPersister instance;
        public static ServicesPersister Instance
        {
            get { return instance ?? (instance = new ServicesPersister()); }
        }
        #endregion Singleton

      /*  private static Service ConvertServices(Services service)
        {
            return new Service
                       {
                           servicesName = service.servicesName,
                           idService = service.idService,
                           serviceDescription = service.serviceDescription
                       };
        }


        private static Service ConvertIdService(Services service)
        {
            return new Service
            {
                idService = service.idService
            };
        }
        */

        public void InsertService(string serviceName, string serviceDescription)
        {
            var service = new Services(serviceName,serviceDescription);
          //  ServicesDataServices.Instance.InsertService(ConvertServices(service));
            ServicesDataServices.Instance.InsertService(service.MapTo(new Service()));

        }

        public IEnumerable<Services> GetAllServices()
        {
            var service = ServicesDataServices.Instance.ViewingServices();
            //return service.Select(serivce => new Services(serivce.servicesName, serivce.idService, serivce.serviceDescription)).ToList();
            return service.Select(serivce => serivce.MapTo(new Services())).ToList();
        }

        public void UpdateService(string  serviceName, int idService, string serviceDescription)
        {
            var service = new Services(serviceName, idService, serviceDescription);
            ServicesDataServices.Instance.UpdateService(service.MapTo(new Service()));
        }

        public void DeleteService(int idService)
        {
            try
            {
                var service = new Services(idService);
                ServicesDataServices.Instance.DeleteService(service.MapTo(new Service()));
            }  //ServicesDataServices.Instance.DeleteService(ConvertIdService(service));
            catch (ExecutionEngineException)
            {
                throw;
            }
        }

        public IEnumerable<Services> CheckServiceId()
        {
            var service = ServicesDataServices.Instance.ViewingServices();
//            return service.Select(serivce => new Services(serivce.idService)).ToList();
            return service.Select(serivce => service.MapTo(new Services())).ToList();

        }
    }
}
