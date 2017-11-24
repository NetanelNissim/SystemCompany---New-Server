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
    public class CompanyPersister 
    {
        #region Singleton
        private CompanyPersister()
        {
        }
        private static CompanyPersister instance;
        public static CompanyPersister Instance
        {
            get { return instance ?? (instance = new CompanyPersister()); }
        }
        #endregion Singleton

        private static Company ConvertCustomer(Companies companies)
        {
            return new Company
                       {
                           address = companies.address,
                           city = companies.city,
                           companyName = companies.companyName,
                           companynumber = companies.companynumber,
                           contactName = companies.contactName,
                           email = companies.email,
                           FAX = companies.FAX,
                           idCompany = companies.idCompany,
                           mobilePhone = companies.mobilePhone,
                           paymentTerms = companies.paymentTerms,
                           Phone = companies.Phone,
                           PostalNum = companies.PostalNum,
                           ZIP = companies.ZIP
                       };
        }

        private static Company ConvertCustomerToUpdate(Companies companies)
        {
            return new Company
            {
                address = companies.address,
                city = companies.city,
                companyName = companies.companyName,
                companynumber = companies.companynumber,
                contactName = companies.contactName,
                email = companies.email,
                FAX = companies.FAX,
                idCompany = companies.idCompany,
                mobilePhone = companies.mobilePhone,
                paymentTerms = companies.paymentTerms,
                Phone = companies.Phone,
                PostalNum = companies.PostalNum,
                ZIP = companies.ZIP

            };
        }

        private static Company ConvertIdCustomer(Companies companies)
        {
            return new Company
            {
                idCompany = companies.idCompany
            };
        }

        private static Company ConvertCompanyNumber(Companies companies)
        {
            return new Company
            {
                companynumber = companies.companynumber
            };
        }


        public void InsertCompany(string companyName, string contactName, string mobilePhone,
            string email, string Phone, string FAX, string companynumber, string address, string city,
            string ZIP, string PostalNum, string paymentTerms)
        {
            var company = new Companies(companyName, contactName, mobilePhone, email, Phone, FAX, companynumber,
                address, city, ZIP, PostalNum, paymentTerms);
            //CustomersDataServices.Instance.InsertCompany(ConvertCustomer(company));
            CustomersDataServices.Instance.InsertCompany(company.MapTo(new Company()));
        }

        public IEnumerable<Companies> GetAllCustomers()
        {
            var customers = CustomersDataServices.Instance.ViewingCompanys();
           /* return customers.Select(companies => new Companies(companies.companyName, companies.contactName,
                companies.mobilePhone, companies.email, companies.Phone, companies.FAX,
                companies.companynumber, companies.address, companies.city, companies.ZIP,
                companies.PostalNum, companies.paymentTerms,companies.idCompany)).ToList();*/
             return customers.Select(companies =>companies.MapTo( new Companies())).ToList();
        }

        public void UpdateCompany(string companyName, string contactName, string mobilePhone,
          string email, string Phone, string FAX, string companynumber, string address, string city,
          string ZIP, string PostalNum, string paymentTerms, int idCompany)
        {
            var company = new Companies(companyName, contactName, mobilePhone, email, Phone, FAX, companynumber,
                address, city, ZIP, PostalNum, paymentTerms, idCompany);
            CustomersDataServices.Instance.UpdateCompany(company.MapTo(new Company()));
        }

        public void DeleteCompany(int idCompany)
        {
            var company = new Companies(idCompany);
            CustomersDataServices.Instance.DeleteCompany(company.MapTo(new Company()));
        }

        public Companies GetCompanyById(int idCompany)
        {
            var company = new Companies(idCompany);
            return CustomersDataServices.Instance.GetCompanyById(company.MapTo(new Company())).MapTo(new Companies());
        }

        public IEnumerable<Companies> CheckCompanyNumber()
        {
            var customers = CustomersDataServices.Instance.ViewingCompanys();
            return customers.Select(companies => companies.MapTo(new Companies())).ToList();
          
        }
    }
}
