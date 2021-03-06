﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace SystemCustomers.ManageServiceToCustomers
{
    class ManageViewingServiceToCustomer
    {
        public DataTable InitializeListServiceCompany()
        {
            using (var ds = new DataSet())
            {
                using (var objServiceToCompany = new ServiceManager.ServiceSystemCompaniesClient())
                {
                    var serviceToCompany = new ServiceManager.ServiceToCompany();
                    //  serviceToCompany.Method = "GetAll";
                    serviceToCompany.Method = "GetAllDataSet";
                    serviceToCompany = objServiceToCompany.ManageServiceToCompany(serviceToCompany);
                    // StringReader reader = new StringReader(serviceToCompany.DataServiceToCompany);
                    // ds.ReadXml(reader);
                    return serviceToCompany.ServiceToCompanyDataSet.Tables[0];
                }
                // return ds.Tables["ServiceToCompany"];
            }
        }

        public DialogResult editRowToolStripMenuItem(DataGridViewRow dr)
        {
            string compantId = dr.Cells["IdCompany_Services"].Value.ToString();
            string serviceId = dr.Cells["idservice_Services_Company"].Value.ToString();
            string companyName = dr.Cells["CompanyNameSTC"].Value.ToString();
            string serviceName = dr.Cells["serviceName_Service_Company"].Value.ToString();
            string priceCost = dr.Cells["priceCost"].Value.ToString();
            if (priceCost == string.Empty) priceCost = "0";
            bool paid = Convert.ToBoolean(dr.Cells["paidServiceCompany"].Value.ToString());
            using (
                ManageServiceToCustomer editData = new ManageServiceToCustomer(
                    companyName, serviceName, compantId, serviceId,
                    DateTime.Parse(dr.Cells["startdate"].Value.ToString()),
                    DateTime.Parse(dr.Cells["enddate"].Value.ToString()),
                    dr.Cells["price"].Value.ToString(), priceCost, paid))
            {
                editData.btnAdd.Visible = false;
                return editData.ShowDialog();
            }
        }

        public void deleteRowToolStripMenuItem(DataGridViewRow dr)
        {
            using (var objServiceToCompany = new ServiceManager.ServiceSystemCompaniesClient())
            {
                var serviceCompany = new ServiceManager.ServiceToCompany();
                serviceCompany.Method = "CheckToAdd";
                serviceCompany.idCompany = Convert.ToInt16(dr.Cells["IdCompany_Services"].Value.ToString());
                serviceCompany.idService = Convert.ToInt16(dr.Cells["idservice_Services_Company"].Value.ToString());
                serviceCompany = objServiceToCompany.ManageServiceToCompany(serviceCompany);
                if (!serviceCompany.isBool)
                {
                    serviceCompany.Method = "Delete";
                    objServiceToCompany.ManageServiceToCompany(serviceCompany);
                }
            }
        }
    }
}
