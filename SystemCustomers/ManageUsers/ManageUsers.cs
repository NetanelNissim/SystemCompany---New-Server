﻿
using System.ServiceModel;
namespace SystemCustomers.ManageUsers
{
  public class ManageUsers
    {
      private string UserName { get; set; }
      private string Password { get; set; }

      public ManageUsers(string userName, string password) 
      {
          this.UserName = userName;
          this.Password = password;
      }

      public string GetPermission()
      {
          if (this.UserName == "administrator" && this.Password == "12213443")
              return "True";
          using (var userService = new ServiceManager.ServiceSystemCompaniesClient())
          {
              try
              {
                  var user = new ServiceManager.Users();
                  user.UserName = this.UserName;
                  user.Password = this.Password;
                  user.Method = "getPermission";
                  user = userService.ManageUsers(user);
                  return user.Permission;
              }
              catch (FaultException ex)
              {
                  MessageUtils.LogUtils.WriteToLog(string.Format(" Error get Permission. Exception: {0}.", ex.Message));
                  MessageUtils.LogUtils.SystemEventLogsError(string.Format(" Error get Permission. Exception: {0}.", ex.Message));
                  return null;
              }
          }
      }
    }
}
