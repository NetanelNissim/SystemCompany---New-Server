using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services;
using System.Data;

namespace WcfServiceLibrarySystemCompanies
{
    public class ServiceCompanies
    {
        public void Delete(Companies comp)
        {
            CompanyServices.Instance.DeleteCompany(comp.idCompany);
        }

        public void Insert(Companies comp)
        {
            CompanyServices.Instance.InsertCompany(comp.companyName, comp.contactName, comp.mobilePhone,
                comp.email, comp.Phone, comp.FAX, comp.companynumber, comp.address, comp.city, comp.ZIP, comp.PostalNum, comp.paymentTerms);
        }

        public void Update(Companies comp)
        {
            CompanyServices.Instance.UpdateCompany(comp.companyName, comp.contactName, comp.mobilePhone,
                 comp.email, comp.Phone, comp.FAX, comp.companynumber, comp.address, comp.city, comp.ZIP, comp.PostalNum, comp.paymentTerms, comp.idCompany);
        }

        public bool CheckCompanyNumber(Companies comp)
        {
            return CompanyServices.Instance.CheckCompanyNumber(comp.companynumber);
        }

        public string GetCompanies()
        {
            return Utils.ConvertDataTableToXML(Services.CompanyServices.Instance.GetAllCustomers(), "Companies");
        }

        public DataTable GetCompaniesDataTable()
        {
            return Services.CompanyServices.Instance.GetAllCustomers();
        }

        public DataSet GetCompaniesDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(Services.CompanyServices.Instance.GetAllCustomers());
            return ds;
        }

        public List<Tuple<string, int>> GetAllCustomersToDropDown()
        {
            return Services.CompanyServices.Instance.GetAllCustomersToDropDown();
        }
    }
}
