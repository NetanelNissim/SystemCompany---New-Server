using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceLibrarySystemCompanies.DataContracts;

namespace WcfServiceLibrarySystemCompanies
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name = "IServiceSystemCompanies")]
    public interface IServiceSystemCompanies
    {
       // [OperationContract(Name = "ManageUsers")]
        [OperationContract]
        //[WebInvoke(Method = "POS", UriTemplate = "/GetJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        // [WebInvoke(UriTemplate = "/CallADSWebMethod", Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(UriTemplate = "/ManageUsers", RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        //[WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "ManageUsers")]
        Users ManageUsers(Users user);

        [OperationContract]
        Companies ManageCompanies(Companies comp);

        [OperationContract]
        Service MangeServices(Service service);

        [OperationContract]
        Project ManageProject(Project project);

        [OperationContract]
        Priority ManagePriority(Priority priority);

        [OperationContract]
        ServiceCalls ManageServiceCalls(ServiceCalls serviceCall);

        [OperationContract]
        ServiceToCompany ManageServiceToCompany(ServiceToCompany serviceToCompany);

        [OperationContract]
        [WebGet(UriTemplate = "/CheckConnection", ResponseFormat = WebMessageFormat.Json)]
        bool CheckConnection();

       /* [OperationContract]
        [WebInvoke(UriTemplate = "/CheckConnection",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json, Method = "POST")]                   
        bool CheckConnection();*/


        [OperationContract]
        [WebInvoke(UriTemplate = "/TestCheck",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        string TestCheck();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetAllCustomer", ResponseFormat = WebMessageFormat.Json)]
        string GetCompanies();
    }
}
