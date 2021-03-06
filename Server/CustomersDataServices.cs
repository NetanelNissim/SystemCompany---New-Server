﻿using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkDAL;
using Server;

namespace SystemCustomers.DBUtils
{
    public class CustomersDataServices
    {
        #region Singelton

        private static CustomersDataServices _instance;

        public static CustomersDataServices Instance
        {
            get { return _instance ?? (_instance = new CustomersDataServices()); }
        }

        private CustomersDataServices()
        {
            // this will happens only once
            // Do your connection stuff in here
        }

        #endregion Singelton

        #region Company

        /// <summary>
        /// ViewingCompanys()
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Company> ViewingCompanys()
        {
            using (var ctx = new SystemCompanyEntities())
            {
                return ctx.Companys.ToList();
            }
        }

        public void InsertCompany(Company company)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                ctx.AddToCompanys(company);
                ctx.SaveChanges();
            }
        }

        public void UpdateCompany(Company newCompany)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var company = ctx.Companys.First(e => e.idCompany == newCompany.idCompany);

                if (company.contactName != newCompany.contactName || 
                company.address != newCompany.address ||
                company.companyName != newCompany.companyName ||
                company.Phone != newCompany.Phone ||
                company.mobilePhone != newCompany.mobilePhone ||
                company.city != newCompany.city ||
                company.FAX != newCompany.FAX ||
                company.email != newCompany.email ||
                company.ZIP != newCompany.ZIP ||
                company.PostalNum != newCompany.PostalNum ||
                company.paymentTerms != newCompany.paymentTerms)
                {
                    company.contactName = newCompany.contactName;
                    company.address = newCompany.address;
                    company.companyName = newCompany.companyName;
                    company.Phone = newCompany.Phone;
                    company.mobilePhone = newCompany.mobilePhone;
                    company.city = newCompany.city;
                    company.FAX = newCompany.FAX;
                    company.email = newCompany.email;
                    company.ZIP = newCompany.ZIP;
                    company.PostalNum = newCompany.PostalNum;
                    company.paymentTerms = newCompany.paymentTerms;
                    ctx.SaveChanges();
                }
            }
        }

        public void DeleteCompany(Company company)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var companyToDelete = ctx.Companys.First(e => e.idCompany == company.idCompany);

                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.address, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.city, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.companyName, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.companynumber, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.contactName, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.email, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.FAX, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.mobilePhone, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.paymentTerms, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.Phone, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.PostalNum, "Delete");
                AuditDataServices.Instance.InsertAudit(companyToDelete.idCompany, 0, 0, "Companys", companyToDelete.ZIP, "Delete");

                ctx.DeleteObject(companyToDelete);
                ctx.SaveChanges();
            }
        }

        public Company GetCompanyById(Company company)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var companyToDelete = ctx.Companys.First(e => e.idCompany == company.idCompany);
                return companyToDelete;
            }
        }

/*
        public List<Company> GetCompanyNameAndId()
        {
            var query = _mDb.Companys.Select(c => new
            {
                c.idCompany,
                c.companyName
            });
            var comp = new List<Company>();
            foreach (var result in query)
            {
                comp.Add(new Company
                {
                    idCompany = result.idCompany,
                    companyName = result.companyName
                });
            }
            return comp;
        }

        public List<Company> DbViewingCompanyNumbers()
        {
            var query = _mDb.Companys.Select(c => new
            {
                c.companynumber
            });

            var comp = new List<Company>();
            foreach (var result in query)
            {
                comp.Add(new Company { companynumber = result.companynumber });
            }
            return comp;
        }
        */
        #endregion Company
    }

}
