﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services;
using WcfServiceLibrarySystemCompanies.DataContracts;
using System.Data;

namespace WcfServiceLibrarySystemCompanies
{
    public class ServiceToCompanyService
    {
        public void Insert(ServiceToCompany serviceToCompany)
        {
            ServiceToCompaniesServices.Instance.InsertServiceToCompanies(serviceToCompany.Startdate, serviceToCompany.Enddate, serviceToCompany.Paid,serviceToCompany.Price, serviceToCompany.priceCost, serviceToCompany.idCompany, serviceToCompany.idService);
        }
          
        public void Update(ServiceToCompany serviceToCompany)
        {
            ServiceToCompaniesServices.Instance.UpdateServiceToCompanies(serviceToCompany.Startdate, serviceToCompany.Enddate, serviceToCompany.Paid, serviceToCompany.Price, serviceToCompany.priceCost, serviceToCompany.idCompany, serviceToCompany.idService);
        }

        public DataSet GetAllServiceToCompanyDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(ServiceToCompaniesServices.Instance.GetAllServiceToCompanies());
            return ds;
        }

        public string GetAll()
        {
            return Utils.ConvertDataTableToXML(ServiceToCompaniesServices.Instance.GetAllServiceToCompanies(), "ServiceToCompany");
        }

        public void Delete(ServiceToCompany serviceToCompany)
        {
            ServiceToCompaniesServices.Instance.DeleteServiceToCompanies(serviceToCompany.idService,serviceToCompany.idCompany);
        }

        public bool CheckToAdd(ServiceToCompany serviceToCompany)
        {
            return ServiceToCompaniesServices.Instance.CheckToAddServiceToCompanies(serviceToCompany.idService, serviceToCompany.idCompany);
        }
    }
}
