using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using SystemCustomers.MessageUtils;


namespace SystemCustomers.ManageServiceCalls
{
   public class ManageViewingServiceCalls
    {
        public string IdCallsServices { get; set;}

        public DataTable InitializeServiceCallsDatagrid()
        {
            using (var ds = new DataSet())
            {
                using (var myServiceCalls = new ServiceManager.ServiceSystemCompaniesClient())
                {
                    try
                    {
                        var serviceCall = new ServiceManager.ServiceCalls();
                        //serviceCall.Method = "GetAllServiceCalls";
                        serviceCall.Method = "GetAllServiceCallsDataSet";
                        serviceCall = myServiceCalls.ManageServiceCalls(serviceCall);
                        //StringReader reader = new StringReader(serviceCall.DataServiceCalls);
                        //ds.ReadXml(reader);
                        //return ds.Tables["ServiceCall"];
                        return serviceCall.DataServiceCallsDataSet.Tables[0];
                    }
                    catch (FaultException ex)
                    {
                        LogUtils.WriteToLog(string.Format(" Get All Service Calls faild. Exception: {0} ",ex.Message));
                        LogUtils.SystemEventLogsError(string.Format(" Get All Service Calls faild. Exception: {0} ", ex.Message));
                        return null;
                    }
                }
            }
        }

        public DataTable DayView(double daysToShow)
        {
            using (var ds = new DataSet())
            {
                using (var myServiceCalls = new ServiceManager.ServiceSystemCompaniesClient())
                {
                    try
                    {
                        var serviceCall = new ServiceManager.ServiceCalls();
                        serviceCall.daysToShow = daysToShow;
                        //serviceCall.Method = "GetServiceCallsBetweenDate";
                        serviceCall.Method = "GetServiceCallsBetweenDateDataSet";
                        serviceCall = myServiceCalls.ManageServiceCalls(serviceCall);
                        //StringReader reader = new StringReader(serviceCall.DataServiceCallsBetweenDate);
                        //ds.ReadXml(reader);
                        //return ds.Tables["ServiceCallsBetweenDate"];
                        return serviceCall.DataServiceCallsBetweenDateDataSet.Tables[0];
                    }
                    catch (FaultException ex)
                    {
                        LogUtils.WriteToLog(string.Format(" Get Service Calls Between Date faild. Exception: {0} ", ex.Message));
                        LogUtils.SystemEventLogsError(string.Format(" Get Service Calls Between Date faild. Exception: {0} ", ex.Message));
                        return null;
                    }
                }
            }
        }

        public void DeleteRoWServiceCall(DataGridViewRow dr)
        {
            IdCallsServices = dr.Cells["idCallsServices"].Value.ToString();
            using (var myServiceCalls = new ServiceManager.ServiceSystemCompaniesClient())
            {
                try
                {
                    var serviceCall = new ServiceManager.ServiceCalls();
                    serviceCall.Method = "CheckServiceCall";
                    serviceCall.idServiceCall = Convert.ToInt32(IdCallsServices);
                    serviceCall = myServiceCalls.ManageServiceCalls(serviceCall);
                    if (!serviceCall.isBool)
                    {
                        serviceCall.Method = "Delete";
                        myServiceCalls.ManageServiceCalls(serviceCall);
                        LogUtils.WriteToLog(" Delete Service Calls: " + dr.Cells["companyName_Service_Call"].Value.ToString());
                        LogUtils.SystemEventLogsInformation(" Delete Service Calls: " +
                                                            dr.Cells["companyName_Service_Call"].Value.ToString());
                    }
                    else
                    {
                        LogUtils.WriteToLog(" Delete faild Service Calls dosn't exist: " + dr.Cells["companyName_Service_Call"].Value.ToString());
                        LogUtils.SystemEventLogsWarning(" Delete faild Service Calls dosn't exist: " +
                                                            dr.Cells["companyName_Service_Call"].Value.ToString());
                    }
                }
                catch (FaultException ex)
                {
                    LogUtils.WriteToLog(string.Format(" Delete faild Service Calls: {0}. Exception: {1}", dr.Cells["companyName_Service_Call"].Value.ToString(), ex.Message));
                    LogUtils.SystemEventLogsError(string.Format(" Delete faild Service Calls: {0}. Exception: {1}", dr.Cells["companyName_Service_Call"].Value.ToString(), ex.Message));
                }
            }
        }

       public DialogResult AddServiceCall()
        {
            const bool isAddServiceCall = false;
            using (ServiceCalls1 serviceCalls = new ServiceCalls1(isAddServiceCall))
            {
               var result = serviceCalls.ShowDialog();
               if (result == DialogResult.Cancel) return result;
               MessageUtils.LogUtils.WriteToLog(" Add Row Service Calls ");
               MessageUtils.LogUtils.SystemEventLogsInformation(" Add Row Service Calls ");
               return result;
            }
        }


       public DialogResult EditServiceCall(DataGridViewRow dr)
       {
           using (var serivceCalls = new ServiceCalls1(dr.Cells["idCallsServices"].Value.ToString(),
                                                       dr.Cells["idCompany_Service_Call"].Value.ToString(),
                                                       dr.Cells["companyName_Service_Call"].Value.ToString(),
                                                       dr.Cells["discriptions"].Value.ToString(),
                                                       dr.Cells["TypePriority"].Value.ToString(),                                                    
                                                       dr.Cells["idPriority"].Value.ToString(),
                                                       dr.Cells["status"].Value.ToString())
                                                       )
           {
               IdCallsServices = dr.Cells["idCallsServices"].Value.ToString();
               // serivceCalls.btnAdd.Visible = false;
               // serivceCalls.txtbCompanyNumber.Enabled = false;
               var result = serivceCalls.ShowDialog();
               if (result == DialogResult.Cancel) return result;
               else
               {
                   MessageUtils.LogUtils.WriteToLog(" Edit Row Viewing All Customers: " +
                                         dr.Cells["companyName_Service_Call"].Value.ToString());
                   MessageUtils.LogUtils.SystemEventLogsInformation(" Edit Row Viewing All Customers: " +
                                                       dr.Cells["companyName_Service_Call"].Value.ToString());
                   return result;

               }
           }
       }
    }
}
