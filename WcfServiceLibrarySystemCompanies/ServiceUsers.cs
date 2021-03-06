﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.IO;
using System.Diagnostics;

namespace WcfServiceLibrarySystemCompanies
{
    public class ServiceUsers // : IServiceUsers
    {
        private static TraceSource mySource =
        new TraceSource("TraceSourceApp");
        public void Insert(Users user)
        {
            UsersServices.Instance.InsertUser(user.UserName, user.PrivateName, user.Permission, user.Password);
        }

        public void UpdateUser(Users user)
        {
            UsersServices.Instance.UpdateUser(user.UserName, user.PrivateName, user.Permission, user.Password);
        }

        public void DeleteUser(Users user)
        {
            UsersServices.Instance.DeleteUser(user.UserId);
        }

        public bool CheckUser(Users user)
        {
            WriteToLog("**User Name Login\\Changed User Name**: " + user.UserName);
            return UsersServices.Instance.CheckUserName(user.UserName);
        }

        public List<Tuple<string, int>> GetAllToFillDropDown()
        {
            return UsersServices.Instance.GetAllToDropDown();
        }

        public string GetPermission(Users user)
        {
            WriteToLog("User Name Login\\Changed User Name: "+ user.UserName);
            return UsersServices.Instance.GetPermission(user.UserName, user.Password);
        }

        public bool CheckConnection()
        {
            try
            {
                UsersServices.Instance.CheckConnection();
                var context = OperationContext.Current;
                var prop = context.IncomingMessageProperties;
                var endpoint = prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
                string ip = endpoint.Address;
                int port = endpoint.Port; 

                WriteToLog("Successfully connected to Data Base");
                WriteToLog("Ip Address: "+ ip + " And Port: "+ port.ToString());
                WriteToLog("Date Time: "+ DateTime.Now.ToString());

                mySource.TraceEvent(TraceEventType.Information, 1,"Error message.");
              //  EventTypeFilter configFilter =(EventTypeFilter)mySource.Listeners["console"].Filter;
              //  mySource.Listeners["console"].Filter = new EventTypeFilter(SourceLevels.Warning);
               // mySource.Switch.Level = SourceLevels.All;
                mySource.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //throw new Exception(ex.Message);
            }
        }

        public void WriteToLog(string logString)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties prop = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint = prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            string ipAddres = endpoint.Address;
          //  string sClean = ipAddres.Replace(".", "_");
           // string sessionId =  OperationContext.Current.SessionId;
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            if (!appPath.EndsWith("\\"))
            {
                appPath = appPath + "\\";
            }
            // create a writer and open the file
            TextWriter tw = new StreamWriter(appPath + DateTime.Today.ToString("MMM dd yyyy") + " " + ipAddres + " log.txt", true);
            // write a line of text to the file
            tw.WriteLine(DateTime.Now + ": " + logString);
            // close the stream
            tw.Close();
        }

        internal bool CheckUserId(Users user)
        {
            return UsersServices.Instance.CheckUserId(user.UserId);
        }
    }
}
