﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using EntityFrameworkDAL;

namespace Server
{
  public  class ServicesDataServices
    {
        #region Singelton

        private static ServicesDataServices _instance;

        public static ServicesDataServices Instance
        {
            get { return _instance ?? (_instance = new ServicesDataServices()); }
        }

        private ServicesDataServices()
        {
            // this will happens only once
            // Do your connection stuff in here
        }

        #endregion Singelton


        #region Services

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Service> ViewingServices()
        {
            using(var ctx = new SystemCompanyEntities() )
            {
                return ctx.Services.ToList();
            }
        }

        public void DeleteService(Service idService)
        {

            using (var ctx = new SystemCompanyEntities())
            {
                try
                {
                    var service = ctx.Services.First(e => e.idService == idService.idService);
                    AuditDataServices.Instance.InsertAudit(service.idService, 0, 0, "Services", service.servicesName, "Delete");
                    ctx.DeleteObject(service);
                    ctx.SaveChanges();
                }
                catch (ContextMarshalException)
                {
                    throw;
                }
            }
        }

        public void UpdateService(Service newService)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var service = ctx.Services.First(e => e.idService == newService.idService);
                if (service.servicesName != newService.servicesName || service.serviceDescription != newService.serviceDescription)
                {
                    AuditDataServices.Instance.InsertAudit(service.idService, 0, 0, "Services", service.servicesName, "Update");
                    AuditDataServices.Instance.InsertAudit(newService.idService, 0, 0, "Services", newService.servicesName, "Update");
                    service.servicesName = newService.servicesName;
                    service.serviceDescription = newService.serviceDescription;

                    ctx.SaveChanges();
                }
            }
        }

        public void InsertService(Service service)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                ctx.AddToServices(service);
                ctx.SaveChanges();
            }
        }
        #endregion Services
    }
}
