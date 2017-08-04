using System.Collections.Generic;
using System.Data;
using Entities;


namespace Services
{
   public class DataTableCreator
    {
       private static DataTableCreator instance;
       public static DataTableCreator Instance
        {
            get { return instance ?? (instance = new DataTableCreator()); }
        }

       public DataTable ConvertListToDataTable(List<Entities.ProjectCompanies> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("idProject");
           table.Columns.Add("idCompany");
           table.Columns.Add("companyName");
           table.Columns.Add("projectName");
           table.Columns.Add("DateStartProject");
           table.Columns.Add("DateFinishProject");
           table.Columns.Add("priceType");
           table.Columns.Add("paid");
           table.Columns.Add("discriptions");
           table.Columns.Add("destination");
           
           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(
                   array.idProject,
                   array.idCompany,
                   array.companyName,
                   array.projectName,
                   array.DateStartProject,
                   array.DateFinishProject,
                   array.priceType,
                   array.paid,
                   array.discriptions,
                   array.destination
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
               table.Rows.Add(
                  array.companyName,
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
           table.Columns.Add("companyName"); 
           table.Columns.Add("idPriority");
           table.Columns.Add("status");
           table.Columns.Add("dateOpenCalls");
           table.Columns.Add("TypePriority");
           table.Columns.Add("discriptions");

            // Add rows.
            foreach (var array in list)
           {
               table.Rows.Add(array.idCallsServices,
                   array.idCompany,
                   array.companyName,
                   array.idPriority,
                   array.status,
                   array.dateOpenCalls,
                   array.TypePriority,
                   array.discriptions
                   );
           }
           return table;
       }

       public DataTable ConvertListToDataTable(List<Entities.Projects> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("IdProject");
           table.Columns.Add("ProjectName");
           table.Columns.Add("ProjectDescription");
           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(array.idProject,
                   array.projectName,
                   array.projectDescription
                   );
           }
           return table;
       }

       public DataTable ConvertListToDataTable(List<Entities.Services> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("IdService");
           table.Columns.Add("servicesName");
           table.Columns.Add("serviceDescription");
           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(array.idService,
                   array.servicesName, array.serviceDescription
                   );
           }
           return table;
       }

       public DataTable ConvertListToDataTable(List<Entities.Priorities> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("IdPriority");
           table.Columns.Add("TypePriority");

           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(array.idPriority,
                   array.TypePriority
                   );
           }
           return table;
       }

       internal DataTable ConvertListToDataTable(List<EnProducts> list)
       {
           // New table.
           var table = new DataTable();

           // Add columns.
           table.Columns.Add("idProduct");
           table.Columns.Add("ProductCostPrice");
           table.Columns.Add("ProductCount");
           table.Columns.Add("ProductDate");
           table.Columns.Add("ProductDiscription");
           table.Columns.Add("ProductName");


           // Add rows.
           foreach (var array in list)
           {
               table.Rows.Add(array.idProduct,
                   array.ProductCostPrice,
                   array.ProductCount,
                   array.ProductDate, 
                   array.ProductDiscription, 
                   array.ProductName
                   );
           }
           return table;
       }
    }
}
