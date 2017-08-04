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
    public class ServicesToCompaniesPersister 
    {
        #region Singleton
        private ServicesToCompaniesPersister()
        {
        }
        private static ServicesToCompaniesPersister instance;
        public static ServicesToCompaniesPersister Instance
        {
            get { return instance ?? (instance = new ServicesToCompaniesPersister()); }
        }
        #endregion Singleton

        private static ServicesCompany ConvertServicesToCompanies(ServicesToCompanies serviceToCompanies)
        {
            return new ServicesCompany
                       {
                         
                           idCompany = serviceToCompanies.idCompany,
                           idService = serviceToCompanies.idService,
                           startdate = serviceToCompanies.startdate,
                           enddate = serviceToCompanies.enddate,
                           paid = serviceToCompanies.paid,
                           price = serviceToCompanies.price,
                           priceCost = serviceToCompanies.priceCost
                       };
        }


        private static ServicesCompany ConvertIdServiceToCompanies(ServicesToCompanies serviceToCompany)
        {
            return new ServicesCompany
            {
                idService = serviceToCompany.idService,
                idCompany=serviceToCompany.idCompany
            };
        }


        public void InsertServiceToCompanies(DateTime startdate, DateTime enddate, bool paid, string price,
            string priceCost, int idCompany, int idService)
        {
            var serviceToCompanies = new ServicesToCompanies(startdate, enddate, paid, price, priceCost, idCompany, idService);
            ServiceToCompanyDataServices.Instance.InsertServiceToCompany(serviceToCompanies.MapTo(new ServicesCompany()));
        }

        public IEnumerable<ServicesToCompanies> GetAllServicesToCompanies()
        {
            var serviceToCompanies = ServiceToCompanyDataServices.Instance.ViewingServicesToCompanys();
            return serviceToCompanies.Select(serivceToCompanie => serivceToCompanie.MapTo( new ServicesToCompanies())).ToList();
              /*  serivceToCompanie.Service.servicesName, serivceToCompanie.Company.companyName,
                serivceToCompanie.startdate, serivceToCompanie.enddate, serivceToCompanie.paid,
                serivceToCompanie.price, serivceToCompanie.priceCost, serivceToCompanie.idCustService,
                serivceToCompanie.idCompany, serivceToCompanie.idService)).ToList();*/
        }

        public void UpdateServiceToCompanies(DateTime startdate, DateTime enddate, bool paid, 
            string price, string priceCost, int idCompany, int idService)
        {
            var serviceToCompanies = new ServicesToCompanies(startdate, enddate, paid, price, priceCost, idCompany, idService);
            ServiceToCompanyDataServices.Instance.UpdateServiceToCompany(serviceToCompanies.MapTo(new ServicesCompany()));
        }

        public void DeleteServiceToCompanies(int idService,int idCompany)
        {
            var serviceToCompanies = new ServicesToCompanies(idService, idCompany);
            ServiceToCompanyDataServices.Instance.DeleteServiceToCompany(serviceToCompanies.MapTo(new ServicesCompany()));
        }

        public IEnumerable<ServicesToCompanies> CheckServiceToCompanyIds()
        {
            var serviceCompany = ServiceToCompanyDataServices.Instance.ViewingServicesToCompanys();
            return serviceCompany.Select(services => services.MapTo( new ServicesToCompanies())).ToList();
        }
    }
}
