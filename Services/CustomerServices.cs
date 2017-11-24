using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;
using System.Data;

namespace Services
{
    public class CompanyServices
    {
        private static CompanyServices instance;
        public static CompanyServices Instance
        {
            get { return instance ?? (instance = new CompanyServices()); }
        }

        public void InsertCompany(string companyName, string contactName, string mobilePhone,
            string email, string Phone, string FAX, string companynumber, string address, string city,
            string ZIP, string PostalNum, string paymentTerms)
        {
           CompanyPersister.Instance.InsertCompany(companyName, contactName, mobilePhone, email, Phone, FAX, companynumber,
                address, city, ZIP, PostalNum, paymentTerms);
        }

        public void UpdateCompany(string companyName, string contactName, string mobilePhone,
          string email, string Phone, string FAX, string companynumber, string address, string city,
          string ZIP, string PostalNum, string paymentTerms, int idCompany)
        {
            CompanyPersister.Instance.UpdateCompany(companyName, contactName, mobilePhone, email, Phone, FAX, companynumber,
                 address, city, ZIP, PostalNum, paymentTerms, idCompany);
        }

        public DataTable GetAllCustomers()
        {
            return DataTableCreator.Instance.ConvertListToDataTable(CompanyPersister.Instance.GetAllCustomers().ToList<Entities.Companies>());
        }

        public void DeleteCompany(int idCompany)
        {
            CompanyPersister.Instance.DeleteCompany(idCompany);
        }

        public Companies GetCompanyById(int idCompany)
        {
            return CompanyPersister.Instance.GetCompanyById(idCompany); 
        }

        public bool CheckCompanyNumber(string companyNumber)
        {
           var list = CompanyPersister.Instance.CheckCompanyNumber();
           foreach (var item in list)
           {
               if (item.companynumber == companyNumber) return false;
           }
           return true;
        }

        public List<Tuple<string, int>> GetAllCustomersToDropDown()
        {
          var company  =  CompanyPersister.Instance.GetAllCustomers();
          var list = new List<Tuple<string, int>>();
          foreach (var item in company)
          {  
              list.Add(new Tuple<string, int>( item.companyName, item.idCompany ));
          }
          return list;
        }

    }
}
