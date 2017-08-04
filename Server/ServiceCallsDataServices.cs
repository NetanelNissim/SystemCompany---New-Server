using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFrameworkDAL;

namespace Server
{
 public class ServiceCallsDataServices
    {
      #region Singelton

        private static ServiceCallsDataServices _instance;

        public static ServiceCallsDataServices Instance
        {
            get { return _instance ?? (_instance = new ServiceCallsDataServices()); }
        }

        private ServiceCallsDataServices()
        {
            // this will happens only once
            // Do your connection stuff in here
        }

        #endregion Singelton

        #region Service Calls

        public IEnumerable<Viewing_Service_Calls> ViewingServiceCalls()
        {
            using (var ctx = new SystemCompanyEntities())
            {
                return ctx.Viewing_Service_Calls.ToList();

                //return ctx.ServiceCalls.Include("Company").Include("Priority").ToList();
            }
        }

        public IEnumerable<Viewing_Service_Calls> GetServiceCallsBetweenDate(ServiceCall serviceCall)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                // var query3 =

                return ctx.Viewing_Service_Calls.Where(
                   t => t.dateOpenCalls > serviceCall.dateOpenCalls && t.dateOpenCalls < DateTime.Now).ToList();
                //  return  ctx.ServiceCalls.Include("Company").Include("Priority").Where(
                //     t => t.dateOpenCalls > serviceCall.dateOpenCalls && t.dateOpenCalls < DateTime.Now).ToList();

                //.Select
                //        (item => new
                //        {
                //            companyName = item.Company.companyName,
                //            dateOpenCalls = item.dateOpenCalls.Value,
                //            discriptions = item.discriptions,
                //            TypePriority = item.Priority.TypePriority,
                //            idCallsServices = item.idCallsServices,
                //            idCompany = item.idCompany,
                //            idPriority = item.idPriority
                //        }
                //        ).ToList();
                //  var query = mDB.ServiceCalls.Where(t => t.dateOpenCalls > serviceCall.dateOpenCalls && t.dateOpenCalls < DateTime.Now).ToList();
                //return query3.Select(item => new ServiceCall
                //{
                //    idCompany = item.idCompany,
                //    dateOpenCalls = item.dateOpenCalls,
                //    discriptions = item.discriptions,
                //    idCallsServices = item.idCallsServices,
                //    idPriority = item.idPriority
                //}).ToList();
            }
        }

        public void DeleteServiceCall(ServiceCall serviceCall)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var serviceCallToDelete = ctx.ServiceCalls.First(e => e.idCallsServices == serviceCall.idCallsServices);
               
                AuditDataServices.Instance.InsertAudit(serviceCallToDelete.idCallsServices, serviceCallToDelete.idCompany, 0, "ServiceCalls", Convert.ToString(serviceCallToDelete.dateOpenCalls), "Delete");
                AuditDataServices.Instance.InsertAudit(serviceCallToDelete.idCallsServices, serviceCallToDelete.idCompany, 0, "ServiceCalls", serviceCallToDelete.discriptions, "Delete");
                AuditDataServices.Instance.InsertAudit(serviceCallToDelete.idCallsServices, serviceCallToDelete.idCompany, 0, "ServiceCalls", Convert.ToString(serviceCallToDelete.idPriority), "Delete");
              
                ctx.DeleteObject(serviceCallToDelete);
                ctx.SaveChanges();
            }
        }

        public void InsertServiceCall(ServiceCall serviceCall)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                ctx.AddToServiceCalls(serviceCall);
                ctx.SaveChanges();
            }
        }

        public void UpdateServiceCall(ServiceCall newServiceCall)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var serviceCall = ctx.ServiceCalls.First(e => e.idCallsServices == newServiceCall.idCallsServices);
                if (serviceCall.discriptions != newServiceCall.discriptions || serviceCall.status != newServiceCall.status)
                {
                    AuditDataServices.Instance.InsertAudit(serviceCall.idCallsServices, serviceCall.idCompany, 0, "ServiceCalls", serviceCall.discriptions, "Update");
                    AuditDataServices.Instance.InsertAudit(newServiceCall.idCallsServices, serviceCall.idCompany, 0, "ServiceCalls", newServiceCall.discriptions, "Update");
                    serviceCall.status = newServiceCall.status;
                    serviceCall.discriptions = newServiceCall.discriptions;
                    ctx.SaveChanges();
                }
            }
        }

        #endregion Service Calls

    }
}
