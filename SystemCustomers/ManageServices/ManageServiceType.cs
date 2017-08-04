﻿using System;
using System.ServiceModel;
using System.Windows.Forms;
using SystemCustomers.ManageServices;

namespace SystemCustomers
{
    public partial class ManageServiceType : Form
    {
        public ManageServiceType()
        {
            InitializeComponent();
        }

        public ManageServiceType(string servicename, string serviceDescription)
            : this()
        {
            this.ServiceName = servicename;
            this.ServiceDescription = serviceDescription;
        }

        private bool _canAdd = false;

        private void EnableAdd()
        {
            btnAdd.Enabled = btnUpdate.Enabled = IsValid() && _canAdd;
        }

        private bool IsValid()
        {
            return (txtbServiceName.Text.Trim() != string.Empty);
        }

        public string ServiceName
        {
            get { return txtbServiceName.Text; }
            set { txtbServiceName.Text = value; }
        }
        public string ServiceDescription
        {
            get { return txtbServiceDescription.Text; }
            set { txtbServiceDescription.Text = value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageUtils.LogUtils.WriteToLog(" Exit Manage Service ");
            MessageUtils.LogUtils.SystemEventLogsInformation(" Exit Manage Service ");
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(var serviceService = new ServiceManager.ServiceSystemCompaniesClient())
            {
                var service = new ServiceManager.Service();
                service.Method = "Insert";
                service.ServiceName = txtbServiceName.Text;
                service.serviceDescription = txtbServiceDescription.Text;
                serviceService.MangeServices(service);
            }
            MessageUtils.LogUtils.WriteToLog(" Add Service: " + txtbServiceName.Text);
            MessageUtils.LogUtils.SystemEventLogsInformation(" Add Service:" + txtbServiceName.Text);
            new MessageUtils.MessageBoxText(string.Format(" שרות נוסף בהצלחה: {0}", txtbServiceName.Text)).OkMessaageBox();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var serviceService = new ServiceManager.ServiceSystemCompaniesClient())
            {
                try
                {
                    var service = new ServiceManager.Service();
                    service.Method = "Update";
                    service.ServiceName = txtbServiceName.Text;
                    service.serviceDescription = txtbServiceDescription.Text;
                    service.IdService = Convert.ToInt32(FormViewingServices.Id);
                    serviceService.MangeServices(service);
                    MessageUtils.LogUtils.WriteToLog(" Update Service: " + txtbServiceName.Text +"Description: "+ this.ServiceDescription);
                    MessageUtils.LogUtils.SystemEventLogsInformation(" Update Service: " + txtbServiceName.Text + "Description: " + this.ServiceDescription);
                    new MessageUtils.MessageBoxText(string.Format(" שרות עודכן בהצלחה: {0}", txtbServiceName.Text)).OkMessaageBox();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (FaultException ex)
                {
                    MessageUtils.LogUtils.WriteToLog(" Update Service Faild dosn't Exist!!!!: " + txtbServiceName.Text + " Exception: " + ex.Message);
                    MessageUtils.LogUtils.SystemEventLogsError("Update Service Faild dosn't Exist!!!!: " + txtbServiceName.Text +" Exception: "+ ex.Message);
                    new MessageUtils.MessageBoxText(string.Format(" Update Service Faild dosn't Exist!!!!: {0}", txtbServiceName.Text)).ErrorMessageBox();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
           
        }

        private void txtbServiceName_TextChanged(object sender, EventArgs e)
        {
            if (!MyRegEx.Validate(txtbServiceName.Text, MyRegEx.OnlyCharsSpacesAndApostropheDigitsHebrew))
            {
                errorPServices.SetError(txtbServiceName, "רק אותיות גרש ורווחים מותרים");
                _canAdd = false;
            }
            else
            {
                errorPServices.SetError(txtbServiceName, string.Empty);
                _canAdd = true;
            }
            EnableAdd();
        }
    }
}
