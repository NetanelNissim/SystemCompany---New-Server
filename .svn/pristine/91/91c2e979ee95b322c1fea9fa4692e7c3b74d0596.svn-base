using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfServiceLibrarySystemCompanies.DataContracts;

namespace WcfServiceLibrarySystemCompanies
{
   // [ServiceContract]
    public interface IProjectCompaniesServices
    {
       // [OperationContract]
        void Insert(ProjectCompanies projectCompany);

     //   [OperationContract]
        void Update(ProjectCompanies projectCompany);

      //  [OperationContract]
        string GetAllProjectToCompany();

     //   [OperationContract]
        List<string> GetDestination();

     //   [OperationContract]
        string GetOldDestination(ProjectCompanies projectCompany);

     //   [OperationContract]
        void Delete(ProjectCompanies projectCompany);

     //   [OperationContract]
        bool CheckProjectToCompany(ProjectCompanies projectCompany);
    }
}
