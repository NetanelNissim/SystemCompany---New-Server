﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;
using System.Data;

namespace Services
{
    public class ServiceCallsServices
    {
        private static ServiceCallsServices instance;
        public static ServiceCallsServices Instance
        {
            get { return instance ?? (instance = new ServiceCallsServices()); }
        }

        public void InsertServiceCalls(DateTime dateOpenCalls, string discriptions, int idCompany, int idPriority, string status)
        {
            ServiceCallsPersister.Instance.InsertServiceCalls(dateOpenCalls, discriptions, idCompany, idPriority, status);
        }

        public void UpdateServiceCalls(string discriptions, int idServiceCalls, string status)
        {
            ServiceCallsPersister.Instance.UpdateServiceCalls(discriptions, idServiceCalls, status);
        }

        public DataTable GetAllServiceCalls()
        {
            return DataTableCreator.Instance.ConvertListToDataTable(ServiceCallsPersister.Instance.GetAllServicesToCompanies().ToList<ServiceCalls>());
        }

        public DataTable GetServiceCallsBetweenDate(double daysToShow)
        {
            return DataTableCreator.Instance.ConvertListToDataTable(ServiceCallsPersister.Instance.GetServiceCallsBetweenDate(ConvertDoubleToDateTime(daysToShow)).ToList<ServiceCalls>());
        }

        public void DeleteServiceCalls(int idServiceCalls)
        {
            ServiceCallsPersister.Instance.DeleteServiceToCompanies(idServiceCalls);
        }

        public DateTime ConvertDoubleToDateTime(double daysToShow)
        {
            return DateTime.Today.AddDays(daysToShow);
        }


        public bool CheckServiceCall(int idServiceCall)
        {
            var list =  ServiceCallsPersister.Instance.GetAllServicesToCompanies();
            foreach (var item in list)
            {
                if (item.idCallsServices == idServiceCall) return false;
            }
            return true;
        }
    }
}
