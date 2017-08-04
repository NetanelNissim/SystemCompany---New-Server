using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using EntityFrameworkDAL;
using Server;
using SystemCustomers.DBUtils;
using Extensions;

namespace DataAccessLayer
{
    public class ServiceCallsPersister 
    {
        #region Singleton
        private ServiceCallsPersister()
        {
        }
        private static ServiceCallsPersister instance;
        public static ServiceCallsPersister Instance
        {
            get { return instance ?? (instance = new ServiceCallsPersister()); }
        }
        #endregion Singleton

        private static ServiceCall ConvertServicesToCompanies(ServiceCalls serviceCalls)
        {
            return new ServiceCall
                       {
                           idCallsServices = serviceCalls.idCallsServices,
                           dateOpenCalls = serviceCalls.dateOpenCalls,
                           idCompany = serviceCalls.idCompany,
                           idPriority = serviceCalls.idPriority,
                           discriptions =serviceCalls.discriptions,
                       };
        }

        public void InsertServiceCalls(DateTime dateOpenCalls, string discriptions, int idCompany, int idPriority, string status)
        {
            var serviceCalls = new ServiceCalls(dateOpenCalls, discriptions, idCompany, idPriority, status);
            ServiceCallsDataServices.Instance.InsertServiceCall(serviceCalls.MapTo(new ServiceCall()));
        }

        public IEnumerable<ServiceCalls> GetAllServicesToCompanies()
        {
            var serviceToCompanies = ServiceCallsDataServices.Instance.ViewingServiceCalls();
            return serviceToCompanies.Select(serivceToCompanie => serivceToCompanie.MapTo(new ServiceCalls())).ToList();
             /*   serivceToCompanie.Company.companyName, serivceToCompanie.Priority.TypePriority,
               serivceToCompanie.idCallsServices, serivceToCompanie.dateOpenCalls, serivceToCompanie.discriptions, serivceToCompanie.idCompany,
                serivceToCompanie.idPriority)).ToList();*/
        }

        public IEnumerable<ServiceCalls> GetServiceCallsBetweenDate(DateTime dateOpenCalls)
        {
            var serviceCalls = new ServiceCalls(dateOpenCalls);
            var serviceToCompanies = ServiceCallsDataServices.Instance.GetServiceCallsBetweenDate(serviceCalls.MapTo(new ServiceCall()));
            return serviceToCompanies.Select(serivceToCompanie => serivceToCompanie.MapTo(new ServiceCalls())).ToList();
                /*serivceToCompanie.Company.companyName, serivceToCompanie.Priority.TypePriority,
               serivceToCompanie.idCallsServices, serivceToCompanie.dateOpenCalls, serivceToCompanie.discriptions, serivceToCompanie.idCompany,
                serivceToCompanie.idPriority)).ToList();*/
        }

        public void UpdateServiceCalls(string discriptions, int idServiceCalls, string status)
        {
            var serviceCalls = new ServiceCalls(discriptions, idServiceCalls, status);
            ServiceCallsDataServices.Instance.UpdateServiceCall(serviceCalls.MapTo(new ServiceCall()));
        }

        public void DeleteServiceToCompanies(int idCallsServices)
        {
            var serviceCalls = new ServiceCalls(idCallsServices);
            ServiceCallsDataServices.Instance.DeleteServiceCall(serviceCalls.MapTo(new ServiceCall()));
        }
    }
}
