using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using WcfServiceLibrarySystemCompanies;

namespace WindowsServiceWCF
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private ServiceHost _Users;  
        protected override void OnStart(string[] args)
        {
            _Users = new ServiceHost(typeof(ServiceUsers));
            _Users.Open();
        }

        protected override void OnStop()
        {
            _Users.Close();
        }
    }
}
