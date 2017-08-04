using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;
using System.Data;

namespace Services
{
    public class ServiceToCompaniesServices
    {
        private static ServiceToCompaniesServices instance;
        public static ServiceToCompaniesServices Instance
        {
            get { return instance ?? (instance = new ServiceToCompaniesServices()); }
        }

        public void InsertServiceToCompanies(DateTime startdate, DateTime enddate, bool paid, 
            string price, string priceCost, int idCompany, int idService)
        {
            ServicesToCompaniesPersister.Instance.InsertServiceToCompanies(startdate, enddate, paid,
                price, priceCost, idCompany, idService);
        }

        public void UpdateServiceToCompanies(DateTime startdate, DateTime enddate, bool paid, 
            string price, string priceCost, int idCompany, int idService)
        {
            ServicesToCompaniesPersister.Instance.UpdateServiceToCompanies(startdate, enddate, paid, 
                price, priceCost, idCompany, idService);
        }

        public DataTable GetAllServiceToCompanies()
        {
            return DataTableCreator.Instance.ConvertListToDataTable(ServicesToCompaniesPersister.Instance.GetAllServicesToCompanies().ToList<Entities.ServicesToCompanies>());
        }

        public void DeleteServiceToCompanies(int idService, int idCompany)
        {
            ServicesToCompaniesPersister.Instance.DeleteServiceToCompanies(idService,idCompany);
        }

        public bool CheckToAddServiceToCompanies(int idService, int idCompany)
        {
           var serviceToCompany = ServicesToCompaniesPersister.Instance.GetAllServicesToCompanies();
           foreach (var item in serviceToCompany)
           {
               if (idService == item.idService && idCompany == item.idCompany) return false;
           }
            return true;
        }

        public bool CheckServiceToCompanyIds(int idCompany, int idService)
        {
            var list = ServicesToCompaniesPersister.Instance.CheckServiceToCompanyIds();
            foreach (var item in list)
            {
                if (item.idCompany == idCompany && item.idService == idService) return false;
            }
            return true;
        }

    }
}
