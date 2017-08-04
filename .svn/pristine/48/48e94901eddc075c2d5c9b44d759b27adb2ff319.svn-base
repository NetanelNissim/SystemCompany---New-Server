using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using SystemCustomers.MessageUtils;

namespace SystemCustomers.ManageProjectToCustomers
{
    public partial class AddProjectCustomers : Form
    {
        public AddProjectCustomers()
        {
            InitializeComponent();
            this.IsForSpecificCompany = false;
            InitcombListCompany();
            InitcombListProject();
        }

        #region Properties

        public AddProjectCustomers(string companyName, string projectName, string companyId,
                                   string idProject, string priceType, string discriptions, string paid,
                                   string destination, DateTime startDateProject, DateTime finishDateProject)
        {
            InitializeComponent();
            this.btnAdd.Visible = false;
            this.btnupdate.Visible = true;
            this.IsForSpecificCompany = true;
            this._companyName = companyName;
            this._projectName = projectName;
            this.CompanyId = companyId;
            this.IdProject = idProject;
            this.PriceType = priceType;
            this.Discriptions = discriptions;
            this.Paid = paid;
            PaidorNotPaid(this.Paid);
            this.Destination = destination;
            this.StartDateProject = startDateProject;
            this.FinishDateProject = finishDateProject;
            InitcombListCompany();
            InitcombListProject();
            GetOldDestination(companyId, idProject);
            CheckFileExists();
        }

        private void GetOldDestination(string companyId, string idProject)
        {
            using (var myClient = new SRProjectCompanies.ProjectCompaniesServicesClient())
            {
                var projectCompany = new SRProjectCompanies.ProjectCompanies();
                projectCompany.IdCompany = Convert.ToInt16(companyId);
                projectCompany.IdProject = Convert.ToInt16(idProject);

                this.OldDestination = myClient.GetOldDestination(projectCompany);
               // this.OldDestination = ProjectCompaniesServices.Instance.GetOldDestination(Convert.ToInt16(idProject),
                 //   Convert.ToInt16(companyId));
            }
        }

        private void PaidorNotPaid(string paid)
        {
            if (paid != "שולם")
            {
                radiobPaid.Checked = true;
                radiobNotPaid.Checked = false;
            }
            else
            {
                radiobNotPaid.Checked = true;
                radiobPaid.Checked = false;
            }
        }

        private bool _canAdd = false;

        public bool IsForSpecificCompany { get; set; }

        private string _companyName = string.Empty;

        public new string CompanyName
        {
            get { return _companyName = combListCompany.SelectedItem.ToString(); }
            set { _companyName = value; }
        }

        private string _projectName = string.Empty;

        public string ProjectName
        {
            get { return _projectName = combListProject.SelectedItem.ToString(); }
            set { _projectName = value; }
        }

        public string CompanyId { get; set; }

        public string IdProject { get; set; }

        public string PriceType
        {
            get { return txtbPriceType.Text; }
            set { txtbPriceType.Text = value; }
        }

        public string Discriptions
        {
            get { return txtDiscriptions.Text; }
            set { txtDiscriptions.Text = value; }
        }

        public string Paid { get; set; }

        private string _destination = string.Empty;

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public string OldDestination { get; set; }

        public DateTime StartDateProject
        {
            get { return dateStartProject.Value; }
            set { dateStartProject.Value = value; }
        }

        public DateTime FinishDateProject
        {
            get { return dateFinishProject.Value; }
            set { dateFinishProject.Value = value; }
        }

        #endregion Properties

        #region Method

        private void EnableAdd()
        {
            btnAdd.Enabled = btnupdate.Enabled = IsValid() && _canAdd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsValid()
        {
            return (txtbPriceType.Text.Trim() != string.Empty);
        }

        public void InitcombListCompany()
        {
            if (IsForSpecificCompany)
            {
                combListCompany.Items.Clear();
                IDToName comp = new IDToName(this._companyName, this.CompanyId);
                combListCompany.Items.Add(comp);
            }
            else
            {
                using (var companyService = new ServiceManager.ServiceSystemCompaniesClient())
                {
                    var comp = new ServiceManager.Companies();
                    comp.Method = "GetAllCustomersToDropDown";
                    comp = companyService.ManageCompanies(comp);
                    foreach (var listComp in comp.list)
                    //foreach (var listComp in CompanyServices.Instance.GetAllCustomersToDropDown())
                    {
                        string companyName = listComp.Item1;
                        string idCompany = listComp.Item2.ToString();
                        IDToName company = new IDToName(companyName, idCompany);
                        combListCompany.Items.Add(company);
                    }
                }
            }
            if (combListCompany.Items.Count > 0) combListCompany.SelectedIndex = 0;
        }

        public void InitcombListProject()
        {
            if (IsForSpecificCompany)
            {
                combListProject.Items.Clear();
                IDToName project = new IDToName(this._projectName, this.IdProject);
                combListProject.Items.Add(project);
            }
            else
            {
                using (var projectService = new ServiceManager.ServiceSystemCompaniesClient())
                {
                    var project = new ServiceManager.Project();
                    project.Method = "GetAllProjectsToDropDown";
                    project = projectService.ManageProject(project);
                    foreach (var listProject in project.list)
                    {
                        string projectName = listProject.Item1;
                        string idProject = listProject.Item2.ToString();
                        IDToName service = new IDToName(projectName, idProject);
                        combListProject.Items.Add(service);
                    }
                }
            }
            if (combListProject.Items.Count > 0) combListProject.SelectedIndex = 0;
        }

        private void combListCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDToName company = (IDToName) this.combListCompany.SelectedItem;
            if (company == null) return;
            this.CompanyId = company.ID;
            this.CompanyName = company.Name;
        }

        private void combListProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDToName project = (IDToName) this.combListProject.SelectedItem;
            if (project == null) return;
            this.IdProject = project.ID;
            this.ProjectName = project.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var myClient = new SRProjectCompanies.ProjectCompaniesServicesClient())
            {
                var projectCompany = new SRProjectCompanies.ProjectCompanies();
                projectCompany.IdCompany = Convert.ToInt16(CompanyId);
                projectCompany.IdProject = Convert.ToInt16(IdProject);

                if (myClient.CheckProjectToCompany(projectCompany))
                {
                    if (!radiobPaid.Checked)
                        Paid = "שולם";
                    else
                        Paid = "לא שולם";
                    /*  objRow = objTable.NewRow();
                      objRow["fileName"] = strPath[strPath.Length - 1]; //clip the full path - we just want last part!
                      objRow["fileSize"] = intLength / 1024; // KB instead of bytes
                      objRow["attachment"] = objData;  //our file
                      objTable.Rows.Add(objRow); //add our new record
                      objAdapter.Update(objTable);  */

                    projectCompany.PriceType = PriceType;
                    projectCompany.Discriptions = Discriptions;
                    projectCompany.DateStartProject = StartDateProject;
                    projectCompany.DateFinishProject = FinishDateProject;
                    projectCompany.Paid = Paid;
                    projectCompany.Destination = Destination;
                    myClient.Insert(projectCompany);
                   // ProjectCompaniesServices.Instance.InsertProjectToCompany(companyId, projectId, PriceType,
                     //   Discriptions, StartDateProject, FinishDateProject, Paid, Destination);
                    LogUtils.WriteToLog(String.Format(" Manage Company To Project: {0} And {1}", CompanyName, ProjectName));
                    LogUtils.SystemEventLogsInformation(String.Format(" Manage Company To Project: {0} And {1}", CompanyName,
                                                                      ProjectName));
                    new MessageBoxText("נוסף בהצלחה").OkMessaageBox();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    LogUtils.WriteToLog(String.Format(
                        " Error Company To Project the company and project exist: {0} And {1}", CompanyName, ProjectName));
                    LogUtils.SystemEventLogsInformation(
                        String.Format(" Error Company To Project the company and project exist: {0} And {1}", CompanyName,
                                      ProjectName));
                    new MessageBoxText("קיים במערכת אותו פרויקט לספק הנבחר").OkMessaageBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LogUtils.WriteToLog(" Exit From Manage Company To Project");
            LogUtils.SystemEventLogsInformation(" Exit From Manage Company To Project");
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (!radiobPaid.Checked)
                Paid = "שולם";
            else
                Paid = "לא שולם";

            using (var myClient = new SRProjectCompanies.ProjectCompaniesServicesClient())
            {
                var projectCompany = new SRProjectCompanies.ProjectCompanies();
                projectCompany.IdCompany = Convert.ToInt16(CompanyId);
                projectCompany.IdProject = Convert.ToInt16(IdProject);
                projectCompany.PriceType = PriceType;
                projectCompany.Discriptions = Discriptions;
                projectCompany.DateStartProject = StartDateProject;
                projectCompany.DateFinishProject = FinishDateProject;
                projectCompany.Paid = Paid;
                projectCompany.Destination = Destination;
                myClient.Update(projectCompany);
                //  ProjectCompaniesServices.Instance.UpdateProjectToCompany(companyId, projectId, PriceType, Discriptions,
                //    StartDateProject, FinishDateProject, Paid, Destination);
                LogUtils.WriteToLog(" Update Manage Company To Project");
                LogUtils.SystemEventLogsInformation(" Update Manage Company To Project");
                new MessageBoxText("עודכן בהצלחה").OkMessaageBox();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        /*  private void UpdateOrAddAttachment(tblAttachments attachment)
          {
              var objFileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
              int intLength = Convert.ToInt32(objFileStream.Length);
              const int threeMega = 3145728;
              if (intLength > threeMega)
              {
                  MessageBox.Show("The selected file is larger than 3 MB!!!", "Big File", MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                  return;
              }

              byte[] objData;
              objData = new byte[intLength];
              string[] strPath = FileName.Split(Convert.ToChar(@"\"));
              objFileStream.Read(objData, 0, intLength);
              objFileStream.Close();
              attachment.fileName = strPath[strPath.Length - 1]; //clip the full path - we just want last part!
              attachment.fileSize = intLength/1024; // KB instead of bytes
              attachment.attachment = objData; //our file
          }*/

        private void txtbPriceType_TextChanged(object sender, EventArgs e)
        {
            if (!MyRegEx.Validate(txtbPriceType.Text, MyRegEx.OnlyCharsSpacesAndApostropheDigitsHebrew))
            {
                epManageProjectToCompany.SetError(txtbPriceType, "קלט לא חוקי");
                _canAdd = false;
            }
            else
            {
                epManageProjectToCompany.SetError(txtbPriceType, string.Empty);
                _canAdd = true;
            }
            EnableAdd();
        }

        private void txtbPriceType_MouseHover(object sender, EventArgs e)
        {
            toolTipManageProjectToCompany.SetToolTip(txtbPriceType, "שדה חובה");
        }

        private void CheckFileExists()
        {
            if (File.Exists(this.OldDestination))
                btnOpenFile.Visible = true;
            else
                btnOpenFile.Visible = false;
        }

        private void buttonOpenPathFile_Click(object sender, EventArgs e)
        {
            // this.OldDestination = this.Destination;
            if (
                !System.IO.Directory.Exists(String.Format(@"{0}\DataFiles\{1}\{2}", Application.StartupPath,
                                                          this.CompanyId, this.IdProject)))
            {
                System.IO.Directory.CreateDirectory(String.Format(@"{0}\DataFiles\{1}\{2}", Application.StartupPath,
                                                                  this.CompanyId, this.IdProject));
            }
            this.openFile.FileName = "Choose File";
            this.openFile.Title = @"Insert an File";
            this.openFile.Filter = @"(*.doc;*.docx;*.pdf;*.jpg;*.tif)|*.doc;*.docx;*.pdf;*.jpg;*.tif;*.tiff";
            if (Directory.Exists(this.Destination))
                this.openFile.InitialDirectory = this.Destination;
            if (this.openFile.ShowDialog() == DialogResult.OK)
            {
                if (this.openFile.CheckFileExists)
                {
                    try
                    {
                        this.Destination = String.Format(@"{0}\DataFiles\{1}\{2}\{3}", Application.StartupPath,
                                                      this.CompanyId, this.IdProject, openFile.SafeFileName);
                        System.IO.File.Copy(openFile.FileName, this.Destination, true);
                        DeleteOldDestination();
                        btnOpenFile.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        btnOpenFile.Visible = false;
                        LogUtils.WriteToLog(ex.Message);
                        LogUtils.SystemEventLogsInformation(ex.Message);
                        new MessageBoxText(ex.Message, "Warning").WarningMessageBox();
                    }
                }
            }
            openFile.Dispose();
        }

        private void DeleteOldDestination()
        {
            if (this.OldDestination != this.Destination && this.OldDestination != string.Empty &&
                File.Exists(this.OldDestination))
                File.Delete(this.OldDestination);
        }

        private string _destinationThreed;
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.OldDestination))
            {
                _destinationThreed = this.OldDestination;
                var t = new Thread(OpenFile);
                t.Start();
            }
            if (File.Exists(this.Destination))
            {
                _destinationThreed = this.Destination;
                var t = new Thread(OpenFile);
                t.Start();
            }
        }

        private void OpenFile()
        {
            System.Diagnostics.Process.Start(_destinationThreed);
        }

        private void btnOpenFile_MouseHover(object sender, EventArgs e)
        {
            string dest;
            dest = !Equals(this.Destination, string.Empty) ? this.Destination : this.OldDestination;
            toolTipManageProjectToCompany.SetToolTip(btnOpenFile, "Open File: " + dest);
        }

        #endregion Method
    }
}
