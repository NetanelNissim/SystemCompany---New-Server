using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace WindowsServiceSystemCompany
{
    public partial class wsRestSystemCompany : ServiceBase
    {
        private ServiceHost _wcfManageSystemCompany;

        public wsRestSystemCompany()
        {
            InitializeComponent();
        }

        public void OnDebug(string[] args)
        {
            OnStart(args);
        }

        protected override void OnStart(string[] args)
        {
            // Thread.Sleep(1000);
           
            _wcfManageSystemCompany = new ServiceHost(typeof(WcfServiceLibrarySystemCompanies.ServiceSystemCompanies));
            _wcfManageSystemCompany.Open();
        }

        protected override void OnStop()
        {
           // Thread.Sleep(1000);
            _wcfManageSystemCompany.Close();
        }
    }
}
