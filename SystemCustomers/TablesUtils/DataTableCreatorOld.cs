﻿using System.Collections.Generic;
using System.Data;


namespace SystemCustomers.TablesUtils
{
   public class DataTableCreatorOld
    {
       private static DataTableCreatorOld instance;
       public static DataTableCreatorOld Instance
        {
            get { return instance ?? (instance = new DataTableCreatorOld()); }
        }
/*
       public DataTable ConvertListToDataTable(List<Entities.ProjectCompanies> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("companyName");
           table.Columns.Add("projectName");
           table.Columns.Add("DateStartProject");
           table.Columns.Add("DateFinishProject");
           table.Columns.Add("priceType");
           table.Columns.Add("paid");
           table.Columns.Add("discriptions");

           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(
                   array.companyName,
                   array.projectName,
                   array.DateStartProject,
                   array.DateFinishProject,
                   array.priceType,
                   array.paid,
                   array.discriptions
                   );
           }
           return table;
       }

       public DataTable ConvertListToDataTable(List<Entities.Companies> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("companyName");
           table.Columns.Add("contactName");
           table.Columns.Add("mobilePhone");
           table.Columns.Add("email");
           table.Columns.Add("Phone");
           table.Columns.Add("paymentTerms");
           table.Columns.Add("FAX");
           table.Columns.Add("companynumber");
           table.Columns.Add("address");
           table.Columns.Add("city");
           table.Columns.Add("ZIP");
           table.Columns.Add("PostalNum");
           table.Columns.Add("idCompany");

           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(array.companyName,
                   array.contactName,
                   array.mobilePhone,
                   array.email,
                   array.Phone,
                   array.paymentTerms,
                   array.FAX,
                   array.companynumber,
                   array.address,
                   array.city,
                   array.ZIP,
                   array.PostalNum,
                   array.idCompany
                   );
           }
           return table;
       }

       public DataTable ConvertListToDataTable(List<ServicesToCompanies> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("idService");
           table.Columns.Add("idCompany");
           table.Columns.Add("idCustService");
           table.Columns.Add("companyName");
           table.Columns.Add("servicesName");
           table.Columns.Add("startdate");
           table.Columns.Add("enddate");
           table.Columns.Add("price");
           table.Columns.Add("priceCost");
           table.Columns.Add("paid");
       
           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(array.idService,
                   array.idCompany,
                   array.idCustService,
                   array.companyName,
                   array.servicesName,
                   array.startdate,
                   array.enddate,
                   array.price,
                   array.priceCost,
                   array.paid
                   );
           }
           return table;
       }

       public DataTable ConvertListToDataTable(List<Entities.ServiceCalls> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("idCallsServices");
           table.Columns.Add("idCompany");
           table.Columns.Add("idPriority");
           table.Columns.Add("companyName");
           table.Columns.Add("dateOpenCalls");
           table.Columns.Add("TypePriority");
           table.Columns.Add("discriptions");

           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(array.idCallsServices,
                   array.idCompany,
                   array.idPriority,
                   array.companyName,
                   array.dateOpenCalls,
                   array.TypePriority,
                   array.discriptions
                   );
           }
           return table;
       }*/
    }
}
