﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using SystemCustomers.ManageCustomers;
using SystemCustomers.ManageServiceCalls;
using SystemCustomers.ManagePriority;
using SystemCustomers.ManageProject;
using SystemCustomers.ManageProjectToCustomers;
using SystemCustomers.ManageServices;
using SystemCustomers.ManageServiceToCustomers;
using SystemCustomers.MessageUtils;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using SystemCustomers.Properties;

namespace SystemCustomers
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            //this.tabControlSystemCustomers.Controls.Remove(tabPManagerProject);
            this.tabControlSystemCustomers.Controls.Remove(tabManageProjectToCompany);
            //this.tabControlSystemCustomers.Controls.Remove();
            //StartService(serviceName, timeOutMilliseconds);
            _isFirst = true;

        }

        #region Property
        private static bool _isFirst = false;
        // private static int timeOutMilliseconds = 1500;
        /// <summary>
        /// Gets a value indicating whether this instance is admin.
        /// </summary>
        /// <value><c>true</c> if this instance is admin; otherwise, <c>false</c>.</value>
        public static bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets the message log.
        /// </summary>
        /// <value>The message log.</value>
        public string LogMessage { get; set; }

        public static string ServiceName { get; set; }

        public static string ConnectionString { get; set; }
        #endregion Property

        /*  #region Manage Services
        public static void StartService(string serviceName, int timeoutMilliseconds)
        {
            using (ServiceController service = new ServiceController(serviceName))
            {
                try
                {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                catch
                {
                    // MessageBox.Show("The Sql Service don't start!!!");
                }
            }
        }


        public static void StopService(string serviceName, int timeoutMilliseconds)
        {
            using (ServiceController service = new ServiceController(serviceName))
            {
                try
                {
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                catch
                {
                    // MessageBox.Show("The Sql Service don't Stop!!!");
                }
            }
        }

        #endregion Manage Services*/

        #region Event Login And Change User Name

        private string GetPermission(string userName, string password)
        {
            return  new ManageUsers.ManageUsers(userName,password).GetPermission();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Login.ResultLogin result = Login.ResultLogin.Ok;
            bool usernamenotexists = true;
            int i = 0;
            while (usernamenotexists && result != Login.ResultLogin.Cancel)
            {
                using (Login login = new Login())
                {
                    login.ShowDialog();
                    if (login.UserName != string.Empty && login.PassWord != string.Empty && login.LoginDialogResult == Login.ResultLogin.Ok)
                    {
                        string permission = string.Empty;
                        permission = GetPermission(login.UserName, login.PassWord);
                        if (string.IsNullOrEmpty(permission))
                        {
                            i++;
                            if (i != 3)
                            {
                                string title = "כניסה למערכת";
                                string message = "שם משתמש או סיסמא לא נכונים";
                                new MessageBoxText(message, title ).ErrorMessageBox();
                                usernamenotexists = true;

                                LogUtils.WriteToLog(String.Format("{0} Try to logged in: {1}", login.UserName,
                                                                             DateTime.Now));
                                LogUtils.SystemEventLogsWarning(String.Format("{0} Try to logged in: {1}",
                                                                                  login.UserName, DateTime.Now));
                            }
                            if (i == 3)
                            {
                                string title = "המערכת נסגרת";
                                string message = "המערכת נסגרת אחרי שלושה ניסיונות כושלים!!!!";
                                new MessageBoxText(message, title).ErrorMessageBox();
                                LogUtils.WriteToLog(" The system closes after three failed login attempts  " +
                                                               DateTime.Now);
                                LogUtils.SystemEventLogsError(" The system closes after three failed login attempts  " +
                                                                    DateTime.Now);
                                //StopService(serviceName, timeOutMilliseconds);
                                this.Close();
                                return;
                            }
                        }
                        else
                        {
                            if (permission == "True")
                            {
                                lblWelcome.Text = String.Format("Welcome: {0} Your Permission: Manager", login.UserName);
                                IsAdmin = true;
                                SetButtons(true);
                                usernamenotexists = false;
                                if (!_isFirst)
                                {
                                    _isFirst = true;
                                    tabControlSystemCustomers.Controls.Add(tabPManagerAdmin);
                                }
                            }
                            else if (permission == "False")
                            {
                                lblWelcome.Text = String.Format("Welcome: {0} Your Permission: Worker", login.UserName);
                                _isFirst = false;
                                tabControlSystemCustomers.Controls.Remove(tabPManagerAdmin);
                                IsAdmin = false;
                                SetButtons(false);
                                usernamenotexists = false;
                            }
                        }
                        result = login.LoginDialogResult;
                    }
                    else
                    {
                        result = Login.ResultLogin.Cancel;
                        //  StopService(serviceName, timeOutMilliseconds);
                        this.Close();
                        return;
                    }
                    LogMessage = login.UserName;
                }
                ListCustomers();
            }
            LogUtils.WriteToLog(LogMessage + " logged in");
            LogUtils.SystemEventLogsInformation(LogMessage + " logged in ");
        }


        private void BtchangeUserClick(object sender, EventArgs e)
        {
            Login.ResultLogin result = Login.ResultLogin.Ok;
            bool usernamenotexists = true;
            while (usernamenotexists && result != Login.ResultLogin.Cancel)
            {
                using (Login login = new Login())
                {
                    login.ShowDialog();
                    if (login.UserName != string.Empty && login.PassWord != string.Empty)
                    {
                        string permission = string.Empty;
                        permission = GetPermission(login.UserName, login.PassWord);
                        if (string.IsNullOrEmpty(permission))
                        {
                            string title = "כניסה למערכת";
                            string message = "שם משתמש או סיסמא לא נכונים";
                            new MessageBoxText(message, title).ErrorMessageBox();
                            usernamenotexists = true;
                            LogUtils.WriteToLog(String.Format("{0} Try to logged in: {1}", login.UserName, DateTime.Now));
                            LogUtils.SystemEventLogsWarning(String.Format("{0} Try to logged in: {1}", login.UserName, DateTime.Now));
                        }
                        else
                        {
                            if (permission == "True")
                            {
                                lblWelcome.Text = String.Format("Welcome {0} Your Permission: Manager", login.UserName);
                                IsAdmin = true;
                                SetButtons(true);
                                usernamenotexists = false;
                                if (!_isFirst)
                                {
                                    _isFirst = true;
                                    tabControlSystemCustomers.Controls.Add(tabPManagerAdmin);
                                }
                            }
                            else if (permission == "False")
                            {
                                lblWelcome.Text = String.Format("Welcome {0} Your Permission: Worker", login.UserName);
                                _isFirst = false;
                                tabControlSystemCustomers.Controls.Remove(tabPManagerAdmin);
                                IsAdmin = false;
                                SetButtons(false);
                                usernamenotexists = false;
                            }
                        }
                        result = login.LoginDialogResult;
                    }
                    else
                    {
                        result = Login.ResultLogin.Cancel;
                    }
                    LogMessage = login.UserName;
                }
            }
            LogUtils.WriteToLog("Change User to: " + LogMessage  );
            LogUtils.SystemEventLogsInformation("Change User to: " + LogMessage );
        }

        #endregion Event Login And Change User Name

        #region Events
        /// <summary>
        /// Sets the buttons.
        /// </summary>
        /// <param name="admin">if set to <c>true</c> [admin].</param>
        private void SetButtons(bool admin)
        {
            btnMaintenance.Visible = admin;
            deleteRowToolStripMenuItem.Enabled = admin;
            toolStripMenuItem15.Enabled = admin;
            DeleteServicesToCustToolStrip.Enabled = admin;
            DeleteServiceCallMenu.Enabled = admin;
            DeleteProjectMenu.Enabled = admin;
            DeleteProjectCompanyMenu.Enabled = admin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //new Services.ManageBackupAndRestoreService(ConnectionString, "Backup");
            LogUtils.WriteToLog(" Backup Success: " + DateTime.Now);
            LogUtils.SystemEventLogsInformation(" Backup Success: " + DateTime.Now);
            string title = "יציאה";
            string message = "?בטוח שאתה רוצה לצאת";
            if (new MessageBoxText(title, message).YesorNoMessageBox() != DialogResult.Yes) return;
            LogUtils.WriteToLog(" Exit From System Customer " + DateTime.Now);
            LogUtils.SystemEventLogsInformation(" Exit From System Customer " + DateTime.Now);
            // StopService(serviceName, timeOutMilliseconds);
            this.Close();
        }

        private void Manage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var about = new AboutBoxServiceCustomers())
            {
                about.ShowDialog();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                GC.Collect();
                this.Refresh();
                // DialogResult = DialogResult.Cancel;
                // Could call cancel click handler here
                // Return true to indicate that Escape key was handled
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnMaintenanceClick(object sender, EventArgs e)
        {
            using (var maintenance = new Maintenance())
            {
                maintenance.ShowDialog();
            }
        }

        private void BtnAddUserClick(object sender, EventArgs e)
        {
            using (var addUser = new AddUser())
            {
                addUser.ShowDialog();
            }
        }

        private void BtnDeleteUserClick(object sender, EventArgs e)
        {
            using (var manageDeleteUsers = new DeleteUser())
            {
                manageDeleteUsers.ShowDialog();
            }
        }


        private void BtnAddPriorityClick(object sender, EventArgs e)
        {
            using (var addPriority = new AddPriority())
            {
                addPriority.ShowDialog();
            }
        }

        private void BtnListPriorityClick(object sender, EventArgs e)
        {
            using (var viewingPriority = new ViewingPriority())
            {
                viewingPriority.ShowDialog();
            }
        }

        private void BtnReportCompanyClick(object sender, EventArgs e)
        {
            using (var viewingReportCompany = new ManageReportCompany())
            {
                viewingReportCompany.ShowDialog();
            }
        }
        #endregion Events

        #region Customers

        private void ListCustomers()
        {
            custdataGridView.DataSource = new FromManageViewingAllCustomers().GetAllCustomers();
        }

        private void editRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (custdataGridView.SelectedRows.Count != 1) return;
            using (DataGridViewRow dr = custdataGridView.SelectedRows[0])
            {
                editRow(dr);
                custdataGridView.ClearSelection();
            }
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRow();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCustomers();
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (custdataGridView.SelectedRows.Count != 1) return;
            using (DataGridViewRow dr = custdataGridView.SelectedRows[0])
            {
                deleteRow(dr);
                custdataGridView.ClearSelection();
            }
        }

        private void tabCListCustomers_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Insert && Control.ModifierKeys == Keys.Control)
            {
                addRowToolStripMenuItem_Click(null, null);
            }

            if (e.KeyCode == Keys.E && Control.ModifierKeys == Keys.Control)
            {
                editRowToolStripMenuItem_Click(null, null);
            }

            if (e.KeyCode == Keys.Delete && Control.ModifierKeys == Keys.Control)
            {
                if (!deleteRowToolStripMenuItem.Enabled) return;
                deleteRowToolStripMenuItem_Click(null, null);
            }

            if (e.KeyCode == Keys.F5)
            {
                refreshToolStripMenuItem_Click(null, null);
            }
        }

        private void custdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (e.ColumnIndex != custdataGridView.Columns["email"].Index) return;
                string emailAdress = custdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (emailAdress == "") return;
                Process.Start("mailto:" + emailAdress);
            }
            catch(Exception ex)
            {
                 LogUtils.WriteToLog(" Exception!! Click On Email Columns: " + ex.Message);
                 LogUtils.SystemEventLogsInformation(" Exception!! Click On Email Columns: " + ex.Message);
            }
        }

        private void ExportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog1 = new FolderBrowserDialog())
            {
                folderBrowserDialog1.Description = "Select folder to save the file";
                folderBrowserDialog1.ShowDialog();
                if (folderBrowserDialog1.SelectedPath == string.Empty) return;
                DataTable dt = ((DataTable)this.custdataGridView.DataSource).Copy();
                const string fileName = "List_Customer.xlsx";
                string path = Path.Combine(folderBrowserDialog1.SelectedPath, fileName);
                try
                {
                    new ExportToExcel(path, fileName, dt);
                }
                catch (Exception ex)
                {
                    LogUtils.WriteToLog(string.Format(" Failed Export File. Exception: {0} ", ex.Message));
                    LogUtils.SystemEventLogsError(string.Format(" Failed Export File. Exception: {0} ", ex.Message));
                }
            }
        }

        private void custdataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < 0) return;
                custdataGridView.ClearSelection();
                custdataGridView.Rows[e.RowIndex].Selected = true;

                ContextMenuStrip mnu = new ContextMenuStrip();
                ToolStripMenuItem mnuAdd = new ToolStripMenuItem("Add") { Image = Resources.edit_add };
                ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit") { Image = Resources.edit };
                ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete") { Image = Resources.edit_delete };
                mnuAdd.Click += new EventHandler(miAddCustomer_Click);
                mnuEdit.Click += new EventHandler(miEditCustomer_Click);
                mnuDelete.Click += new EventHandler(miDeleteCustomer_Click);
                mnu.Items.AddRange(new ToolStripItem[] { mnuAdd, mnuEdit, mnuDelete });
                mnu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void miAddCustomer_Click(object sender, EventArgs e)
        {
            addRow();
        }

        private void addRow()
        {
            using (var cust = new ManageCustomer())
            {
                custdataGridView.ClearSelection();
                cust.btnupdate.Visible = false;
                var result = cust.ShowDialog();
                if (result == DialogResult.Cancel) return;
                ListCustomers();
            }
            LogUtils.WriteToLog(" Add Row Viewing All Customers ");
            LogUtils.SystemEventLogsInformation(" Add Row Viewing All Customers ");
        }

        private void miEditCustomer_Click(object sender, EventArgs e)
        {
            using (DataGridViewRow dr = custdataGridView.SelectedRows[0])
            {
                editRow(dr);
                custdataGridView.ClearSelection();
            }
        }

        private void editRow(DataGridViewRow dr)
        {
            var result = new FromManageViewingAllCustomers().editRowToolStripMenuItem(dr);
            if (result == DialogResult.Cancel) return;
            ListCustomers();
        }

        private void miDeleteCustomer_Click(object sender, EventArgs e)
        {
            using (DataGridViewRow dr = custdataGridView.SelectedRows[0])
            {
                deleteRow(dr);
                custdataGridView.ClearSelection();
            }
        }

        private void deleteRow(DataGridViewRow dr)
        {
            string titel = "מחיקת לקוח";
            string bodyMessage = "בטוח שאתה רוצה למחוק לקוח כולל השרותים שלו";
            if (new MessageBoxText(bodyMessage, titel).YesorNoMessageBox() == DialogResult.No) return;
            new FromManageViewingAllCustomers().deleteRowToolStripMenuItem(dr);
            ListCustomers();
        }

        #endregion Customers

        #region Services

        private void ListServices()
        {
            dgridvListServices.DataSource = new FormViewingServices().InitServicedatagrid();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            ListServices();
        }

        /// <summary>
        /// Edit Service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (dgridvListServices.SelectedRows.Count != 1) return;
            using (var dr = dgridvListServices.SelectedRows[0])
            {
                editrowService(dr);
                dgridvListServices.ClearSelection();
            }
        }

        /// <summary>
        /// Delete Service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (dgridvListServices.SelectedRows.Count != 1) return;
            using (var dr = dgridvListServices.SelectedRows[0])
            {
                deleteRowService(dr);
                dgridvListServices.ClearSelection();
            }
        }

        /// <summary>
        /// Add Services
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            addRowService();
        }

        private void tabPServices_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert && Control.ModifierKeys == Keys.Control)
            {
                // Add Service
                toolStripMenuItem16_Click(null, null);
            }

            if (e.KeyCode == Keys.E && Control.ModifierKeys == Keys.Control)
            {
                // Edit Services
                toolStripMenuItem14_Click(null, null);
            }

            if (e.KeyCode == Keys.Delete && Control.ModifierKeys == Keys.Control)
            {
                // Delete Services
                if (!toolStripMenuItem15.Enabled) return;
                toolStripMenuItem15_Click(null, null);
            }


            if (e.KeyCode == Keys.F5)
            {
                //refresh Services
                ListServices();
            }
        }

        private void dgridvListServices_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < 0) return;
                dgridvListServices.ClearSelection();
                dgridvListServices.Rows[e.RowIndex].Selected = true;

                ContextMenuStrip mnu = new ContextMenuStrip();
                ToolStripMenuItem mnuAdd = new ToolStripMenuItem("Add") { Image = Resources.edit_add };
                ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit") { Image = Resources.edit };
                ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete") { Image = Resources.edit_delete };
                mnuAdd.Click += new EventHandler(miAddService_Click);
                mnuEdit.Click += new EventHandler(miEditService_Click);
                mnuDelete.Click += new EventHandler(miDeleteService_Click);
                mnu.Items.AddRange(new ToolStripItem[] { mnuAdd, mnuEdit, mnuDelete });
                mnu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void miDeleteService_Click(object sender, EventArgs e)
        {
            using (DataGridViewRow dr = dgridvListServices.SelectedRows[0])
            {
                deleteRowService(dr);
                dgridvListServices.ClearSelection();
            }
        }

        private void deleteRowService(DataGridViewRow dr)
        {
            string title = "מחיקת שרות";
            string message = "בטוח שאתה רוצה למחוק שרות";
            if (new MessageBoxText(title, message).YesorNoMessageBox() == DialogResult.No) return;
            new FormViewingServices().DeleteService(dr);
            ListServices();
        }

        private void miEditService_Click(object sender, EventArgs e)
        {
            using (DataGridViewRow dr = dgridvListServices.SelectedRows[0])
            {
                editrowService(dr);
                dgridvListServices.ClearSelection();
            }
        }

        private void editrowService(DataGridViewRow dr)
        {
            var result = new FormViewingServices().EditService(dr);
            if (result == DialogResult.Cancel) return;
            ListServices();
        }

        private void miAddService_Click(object sender, EventArgs e)
        {
            addRowService();
        }

        private void addRowService()
        {
            using (var serviceType = new ManageServiceType())
            {
                serviceType.btnUpdate.Visible = false;
                var result = serviceType.ShowDialog();
                if (result == DialogResult.Cancel) return;
                ListServices();
            }
            LogUtils.WriteToLog(" Add Row Viewing All Services ");
            LogUtils.SystemEventLogsInformation(" Add Row Viewing All Services ");
        }

        #endregion Services

        #region Services To Company

        private void TabCServicesToCustomersKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert && Control.ModifierKeys == Keys.Control)
            {
                // Add Service To Customers
                AddServicesToCustToolStrip_Click(null, null);
            }

            if (e.KeyCode == Keys.E && Control.ModifierKeys == Keys.Control)
            {
                // Edit Services To Customers
                EditServicesToCustToolStrip_Click(null, null);
            }

            if (e.KeyCode == Keys.Delete && Control.ModifierKeys == Keys.Control)
            {
                // Delete Services To Customers
                if (!DeleteServicesToCustToolStrip.Enabled) return;
                DeleteServicesToCustToolStrip_Click(null, null);
            }

            if (e.KeyCode == Keys.F5)
            {
                //refresh Services To Customers
                InitdatagViewServiceToCust();
            }
        }

        private void InitdatagViewServiceToCust()
        {
            dataViewingServiceToCust1.DataSource = serviceToCompany 
                = new ManageViewingServiceToCustomer().InitializeListServiceCompany();
        }

        /*  enum p { paied, noPaid };
          private DataTable ChengeDataTableViewServiceToCust(DataTable tableServiceToCust)
          {
              foreach (DataRow rd in tableServiceToCust.Rows)
              {
                  string paid = rd["paid"].ToString();
                  if (paid != "True")
                       rd["paid"]= p.noPaid;
                  else
                      rd["paid"] = p. paied;
              }
              return tableServiceToCust;
          }
         */

        private void AddServicesToCustToolStrip_Click(object sender, EventArgs e)
        {
            addRowServiceToCust();
        }

        private void addRowServiceToCust()
        {
            using (var serviceTocust = new ManageServiceToCustomer())
            {
                serviceTocust.btnupdate.Visible = false;
                LogUtils.WriteToLog("Open Form Add Row Service To Customer");
                LogUtils.SystemEventLogsInformation("Open Form Add Row Service To Customer");
                var result = serviceTocust.ShowDialog();
                if (result == DialogResult.Cancel) return;
                InitdatagViewServiceToCust();
            }
        }

        private void EditServicesToCustToolStrip_Click(object sender, EventArgs e)
        {
            if (dataViewingServiceToCust1.SelectedRows.Count != 1) return;
            using (var dr = dataViewingServiceToCust1.SelectedRows[0])
            {
                editRowServicesToCust(dr);
                dataViewingServiceToCust1.ClearSelection();
            }
        }

        private void DeleteServicesToCustToolStrip_Click(object sender, EventArgs e)
        {
            if (dataViewingServiceToCust1.SelectedRows.Count != 1) return;
            using (var dr = dataViewingServiceToCust1.SelectedRows[0])
            {
                deleteRowServiceTocust(dr);
                dataViewingServiceToCust1.ClearSelection();
            }
        }

        private void deleteRowServiceTocust(DataGridViewRow dr)
        {
            string title;
            string message;
            string isPaid = dr.Cells["paidServiceCompany"].Value.ToString();
            if (isPaid != "True")
            {
                title = "לא ניתן למחיקה";
                message = "לקוח לא שילם את השירות!!!!";
                new MessageBoxText(message, title).ErrorMessageBox();
                return;
            }
            title = "מחיקת שרות ללקוח";
            message = "בטוח שאתה רוצה למחוק ";
            if (new MessageBoxText(message, title).YesorNoMessageBox() == DialogResult.No) return;
            new ManageViewingServiceToCustomer().deleteRowToolStripMenuItem(dr);
            InitdatagViewServiceToCust();
        }

        private bool _backGroundMode = false;
        private Color _selectedColor = Color.Red;
        public bool IsForSpecificCustomer = false;
        private int _monthToRemind = 3;

        static Manage()
        {
            IsAdmin = false;
        }

        private void dataViewingServiceToCust1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 6 || e.Value == null) return;
            if (!NeedToRemind(e.Value.ToString())) return;
            {
                ColorCell(this.dataViewingServiceToCust1[e.ColumnIndex, e.RowIndex]);
                ColorCell(this.dataViewingServiceToCust1[3, e.RowIndex]);
                ColorCell(this.dataViewingServiceToCust1[4, e.RowIndex]);
            }
        }

        private void ColorCell(DataGridViewCell cell)
        {
            if (this._backGroundMode)
            {
                cell.Style.BackColor = this._selectedColor;
                cell.Style.ForeColor = Color.Black;
            }
            else
            {
                cell.Style.ForeColor = this._selectedColor;
                cell.Style.BackColor = Color.White;
            }
        }

        private void UpdateCellsColors()
        {
            foreach (DataGridViewRow dr in this.dataViewingServiceToCust1.Rows)
            {
                if (dr.Cells[6].Value == null) continue;
                if (NeedToRemind(dr.Cells[6].Value.ToString()))
                {
                    ColorCell(dr.Cells[6]);
                    ColorCell(dr.Cells[3]);
                    ColorCell(dr.Cells[4]);
                }
                else
                {
                    RevertCell(dr.Cells[6]);
                    RevertCell(dr.Cells[3]);
                    RevertCell(dr.Cells[4]);
                }
            }
        }

        private void RevertCell(DataGridViewCell cell)
        {
            cell.Style.ForeColor = Color.Black;
            cell.Style.BackColor = Color.White;
        }

        private bool NeedToRemind(string date)
        {
            DateTime dt = DateTime.Parse(date);
            if (dt.Year == DateTime.Now.Year)
            {
                return Math.Abs(dt.Month - DateTime.Now.Month) <= _monthToRemind;
            }
            else if (Math.Abs(dt.Year - DateTime.Now.Year) == 2)
            {
                return Math.Abs((dt.Month + 24) - DateTime.Now.Month) <= _monthToRemind;
            }
            else
                return Math.Abs((dt.Month + 12) - DateTime.Now.Month) <= _monthToRemind;

        }

        private void setColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var setColor = new ColorDialog())
            {
                setColor.ShowDialog();
                this._selectedColor = setColor.Color;
                UpdateCellsColors();
            }
        }

        private void setBackgroundToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null) return;
            this._backGroundMode = item.Checked;
            UpdateCellsColors();
        }

        private void numberToRemindService_ValueChanged(object sender, EventArgs e)
        {
            var numberToRemindService = sender as NumericUpDown;
            if (numberToRemindService == null) return;
            this._monthToRemind = (int)numberToRemindService.Value;
            UpdateCellsColors();
        }

        private void ExportExcelServicesToCustToolStrip_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog1 = new FolderBrowserDialog())
            {
                folderBrowserDialog1.Description = "Select folder to save the file";
                folderBrowserDialog1.ShowDialog();
                if (folderBrowserDialog1.SelectedPath == string.Empty) return;
                DataTable dt = ((DataTable)this.dataViewingServiceToCust1.DataSource).Copy();
                const string fileName = "List_Service_Customers.xlsx";
                string path = Path.Combine(folderBrowserDialog1.SelectedPath, fileName);
                new ExportToExcel(path, fileName, dt);
            }
        }

        private void dataViewingServiceToCust1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < 0) return;
                dataViewingServiceToCust1.ClearSelection();
                dataViewingServiceToCust1.Rows[e.RowIndex].Selected = true;

                ContextMenuStrip mnu = new ContextMenuStrip();
                ToolStripMenuItem mnuAdd = new ToolStripMenuItem("Add") { Image = Resources.edit_add };
                ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit") { Image = Resources.edit };
                ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete") { Image = Resources.edit_delete };
                mnuAdd.Click += new EventHandler(miAddServiceToCust_Click);
                mnuEdit.Click += new EventHandler(miEditServiceToCust_Click);
                mnuDelete.Click += new EventHandler(miDeleteServiceToCust_Click);
                mnu.Items.AddRange(new ToolStripItem[] { mnuAdd, mnuEdit, mnuDelete });
                mnu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void miAddServiceToCust_Click(object sender, EventArgs e)
        {
            addRowServiceToCust();
        }

        private void miEditServiceToCust_Click(object sender, EventArgs e)
        {
            using (var dr = dataViewingServiceToCust1.SelectedRows[0])
            {
                editRowServicesToCust(dr);
                dataViewingServiceToCust1.ClearSelection();
            }
        }

        private void editRowServicesToCust(DataGridViewRow dr)
        {
            var result = new ManageViewingServiceToCustomer().editRowToolStripMenuItem(dr);
            if (result == DialogResult.Cancel) return;
            InitdatagViewServiceToCust();
        }

        private void miDeleteServiceToCust_Click(object sender, EventArgs e)
        {
            using (var dr = dataViewingServiceToCust1.SelectedRows[0])
            {
                deleteRowServiceTocust(dr);
                dataViewingServiceToCust1.ClearSelection();
            }
        }

        #endregion Services To Company

        #region price Company And Services

        private void InitdatagViewPriceToCustomer()
        {
            this.dataGViewingPriceToCustomer.Rows.Clear();
            using (DataTable table = serviceToCompany)
            {
                var hs = new HashSet<int>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    int price = 0;
                    int companyID = Int32.Parse(table.Rows[i]["idCompany"].ToString());
                    string companyName = table.Rows[i]["companyName"].ToString();
                    if (hs.Contains(companyID)) continue;
                    hs.Add(companyID);
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        int companyIdNext = Int32.Parse(table.Rows[j]["idCompany"].ToString());
                        if (companyIdNext != companyID) continue;
                        {
                            bool isPaid = bool.Parse(table.Rows[j]["paid"].ToString());
                            if (isPaid == true) continue;
                            price += Int32.Parse(table.Rows[j]["price"].ToString());
                        }
                    }
                    if (price == 0) continue;
                    this.dataGViewingPriceToCustomer.Rows.Add(new object[] { companyName, price });
                }
                hs.Clear();
            }
        }

        private DataTable serviceToCompany;

        private void InitdatagViewPricePerService()
        {
            this.dataGvPricePerService.Rows.Clear();
            DataTable table = serviceToCompany;
            var hs = new HashSet<int>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int price = 0;
                int priceCost = 0;
                int sumPrice = 0;
                int serviceId = Int32.Parse(table.Rows[i]["idservice"].ToString());
                string serviceName = table.Rows[i]["servicesName"].ToString();
                if (hs.Contains(serviceId)) continue;
                hs.Add(serviceId);
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    int serviceIdNext = Int32.Parse(table.Rows[j]["idservice"].ToString());
                    if (serviceIdNext != serviceId) continue;
                    price += Int32.Parse(table.Rows[j]["price"].ToString());
                    priceCost += Int32.Parse(table.Rows[j]["priceCost"].ToString());
                }
                sumPrice = price - priceCost;
                this.dataGvPricePerService.Rows.Add(new object[] { serviceName, price, priceCost, sumPrice });
            }
            table.Dispose();
            hs.Clear();
        }

        #endregion price Customers And Services

        #region Service Call

        private void ExportToExcelServiceCallMenu_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog1 = new FolderBrowserDialog())
            {
                folderBrowserDialog1.Description = "Select folder to save the file";
                folderBrowserDialog1.ShowDialog();
                if (folderBrowserDialog1.SelectedPath == string.Empty) return;
                DataTable dt = ((DataTable)this.ServiceCallsdataGridView.DataSource).Copy();
                const string fileName = "List_Service_Call.xlsx";
                string path = Path.Combine(folderBrowserDialog1.SelectedPath, fileName);
                new ExportToExcel(path, fileName, dt);
            }
        }

        private void ListServiceCalls()
        {
            ServiceCallsdataGridView.DataSource = new ManageViewingServiceCalls().InitializeServiceCallsDatagrid();
            this.serviceToCompany = new ManageViewingServiceToCustomer().InitializeListServiceCompany();
        }

        private void AllRadioButtonClick(object sender, EventArgs e)
        {
            ListServiceCalls();
        }

        private void DayRadioButtonClick(object sender, EventArgs e)
        {
            const double daysToShow = -1.0;
            ServiceCallsdataGridView.DataSource = new ManageViewingServiceCalls().DayView(daysToShow);
        }

        private void WeekRadioButtonClick(object sender, EventArgs e)
        {
            const double daysToShow = -7.0;
            ServiceCallsdataGridView.DataSource = new ManageViewingServiceCalls().DayView(daysToShow);
        }

        private void MonthRadioButtonClick(object sender, EventArgs e)
        {
            const double daysToShow = -30.0;
            ServiceCallsdataGridView.DataSource = new ManageViewingServiceCalls().DayView(daysToShow);
        }


        private void RefreshServiceCallMenu_Click(object sender, EventArgs e)
        {
            ListServiceCalls();
        }

        private void ServiceCallsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ServiceCallsdataGridView.CurrentCell.ColumnIndex.Equals(3)) return;
            if (e.RowIndex < 0) return;
            using (var dr = ServiceCallsdataGridView.Rows[e.RowIndex])
            {
                var result = new ManageViewingServiceCalls().EditServiceCall(dr);
                if (result == DialogResult.Cancel) return;
                ListServiceCalls();
            }
        }

        private int rowIndex = -1;
        private void ServiceCallsdataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (rowIndex != e.RowIndex)
            {
                rowIndex = e.RowIndex;
                string idCustomer = this.ServiceCallsdataGridView[1, e.RowIndex].Value.ToString();
                this._backGroundMode = CheckCustomerIsInService(idCustomer);
                if (this._backGroundMode)
                    ColorCell(this.ServiceCallsdataGridView[3, e.RowIndex]);
            }
        }

        private bool CheckCustomerIsInService(string idCustomer)
        {
            foreach (DataRow row in serviceToCompany.Rows)
            {
                if (row["idCompany"].ToString() == idCustomer) return true;
            }
            return false;
        }

        private void EditServiceCallMenu_Click(object sender, EventArgs e)
        {
            if (ServiceCallsdataGridView.SelectedRows.Count != 1) return;
            using (var dr = ServiceCallsdataGridView.SelectedRows[0])
            {
                var result = new ManageViewingServiceCalls().EditServiceCall(dr);
                if (result == DialogResult.Cancel) return;
                ListServiceCalls();
            }
        }

        private void DeleteServiceCallMenu_Click(object sender, EventArgs e)
        {
            if (ServiceCallsdataGridView.SelectedRows.Count != 1) return;
            string title = "מחיקת קריאת שרות";
            string message = "בטוח שאתה רוצה למחוק קריאת שרות";
            if (new MessageBoxText(title, message).YesorNoMessageBox() == DialogResult.No) return;
            using (var dr = ServiceCallsdataGridView.SelectedRows[0])
            {
                new ManageViewingServiceCalls().DeleteRoWServiceCall(dr);
                ListServiceCalls();
            }
        }

        private void AddServiceCallMenu_Click(object sender, EventArgs e)
        {
            var result = new ManageViewingServiceCalls().AddServiceCall();
            if (result == DialogResult.Cancel) return;
            ListServiceCalls();
        }


        #endregion Service Call

        #region Manage Project

        private void ListProject()
        {
            dgridvListProject.DataSource = new ManageViewingAllProject().InitializeProject();
        }


        private void RefreshProjectMenu_Click(object sender, EventArgs e)
        {
            ListProject();
        }


        private void EditProjectMenu_Click(object sender, EventArgs e)
        {
            if (dgridvListProject.SelectedRows.Count != 1) return;
            using (var dr = dgridvListProject.SelectedRows[0])
            {
                var result = new ManageViewingAllProject().EditProject(dr);
                if (result == DialogResult.Cancel) return;
                ListProject();
            }
        }

        private void DeleteProjectMenu_Click(object sender, EventArgs e)
        {
            if (dgridvListProject.SelectedRows.Count != 1) return;
            string title = "מחיקת פרויקט";
            string message = "בטוח שאתה רוצה למחוק ";
            if (new MessageBoxText(title, message).YesorNoMessageBox() == DialogResult.No) return;
            using (var dr = dgridvListProject.SelectedRows[0])
            {
                new ManageViewingAllProject().DeleteProject(dr);
                ListProject();
            }
        }

        private void AddProjectMenu_Click(object sender, EventArgs e)
        {
            using (AddProject addProject = new AddProject())
            {
                addProject.btnUpdate.Visible = false;
                var result = addProject.ShowDialog();
                if (result == DialogResult.Cancel) return;
                ListProject();
            }
            LogUtils.WriteToLog(" Add Row Viewing All Project ");
            LogUtils.SystemEventLogsInformation(" Add Row Viewing All Project ");
        }

        #endregion Manage View All Project

        #region  Project To Company

        private void ExportExcelProjectProviderMenu_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog1 = new FolderBrowserDialog())
            {
                folderBrowserDialog1.Description = "Select folder to save the file";
                folderBrowserDialog1.ShowDialog();
                if (folderBrowserDialog1.SelectedPath == string.Empty) return;
                const string fileName = "List_Project_Company.xlsx";
                string path = Path.Combine(folderBrowserDialog1.SelectedPath, fileName);
                new ExportToExcel(path, fileName,new ManageViewingProjectToCompany().InitializeListProjectCompany());
            }
        }

        private void ListProjectToCustomers()
        {
            var dt = new ManageViewingProjectToCompany().InitializeListProjectCompany();
            // on all table's rows
            foreach (DataRow dtRow in dt.Rows)
            {
                // on all table's columns
                foreach (DataColumn dc in dt.Columns)
                {
                    if ("destination" == dc.ColumnName)
                         dtRow[dc] = Path.GetFileName(dtRow[dc].ToString());
                }
            }
            //for (int i = 0; i < list.Count; i++)
            //{
            //    list[i].destination = Path.GetFileName(list[i].destination);
            //}
            dataViewingProjectToCompany.DataSource = dt;
            
        }

        private void AddProjectCompanyMenu_Click(object sender, EventArgs e)
        {
            using (var projectToCompany = new AddProjectCustomers())
            {
                projectToCompany.btnupdate.Visible = false;
                LogUtils.WriteToLog("Open Form Add Row Project To Company");
                LogUtils.SystemEventLogsInformation("Open Form Add Row Project To Company");
                var result = projectToCompany.ShowDialog();
                if (result == DialogResult.Cancel) return;
                ListProjectToCustomers();
            }
        }

        private void EditProjectCompanyMenu_Click(object sender, EventArgs e)
        {
            if (dataViewingProjectToCompany.SelectedRows.Count != 1) return;
            using (DataGridViewRow dr = dataViewingProjectToCompany.SelectedRows[0])
            {
                var result = new ManageViewingProjectToCompany().EditProjectCompany(dr);
                if (result == DialogResult.Cancel) return;
                ListProjectToCustomers();
            }
        }

        private void DeleteProjectCompanyMenuClick(object sender, EventArgs e)
        {
            if (dataViewingProjectToCompany.SelectedRows.Count != 1) return;
            string title = "מחיקת פרויקט לחברה";
            string message = "בטוח שאתה רוצה למחוק ";
            if (new MessageBoxText(title, message).YesorNoMessageBox() == DialogResult.No) return;
            using (var dr = dataViewingProjectToCompany.SelectedRows[0])
            {
                new ManageViewingProjectToCompany().DeleteProjectCompany(dr);
                ListProjectToCustomers();
            }
        }

        private void RefreshMenu_Click(object sender, EventArgs e)
        {
            ListProjectToCustomers();
        }

        private string _pathThreed;
        private void DataViewingProjectToCompanyCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 10 || e.RowIndex == -1) return;
            if (dataViewingProjectToCompany[e.ColumnIndex, e.RowIndex].Value.ToString() == string.Empty) return;
            var list = new ManageViewingProjectToCompany().GetDestination();
            _pathThreed = Convert.ToString( list[e.RowIndex]);
            if (File.Exists(_pathThreed))
            {
                var t = new Thread(OpenFileFromDataGrid);
                t.Start();
            }
        }

        private void OpenFileFromDataGrid()
        {
            Process.Start(_pathThreed);
        }

        #endregion Viewing Project To Company

        #region Event Tab Control
        private void TabControlSystemCustomersSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControlSystemCustomers.SelectedTab.Text.Trim())
            {
                case "קריאות שרות":
                    AllradioButton.Checked = true;
                    ListServiceCalls();
                    break;
                case "שירותים ללקוח":
                    TabCServicesToCustomersSelectedIndexChanged(null, null);
                    break;
                case "שירותים":
                    ListServices();
                    break;
                case "לקוחות":
                    // ListCustomers();
                    break;
                case "פרויקטים":
                    ListProject();
                    break;
                case "ניהול פרויקטים לספק":
                    ListProjectToCustomers();
                    break;
            }
        }

        private void TabCServicesToCustomersSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabCServicesToCustomers.SelectedTab.Text.Trim())
            {
                case "רשימת שירותים ללקוח":
                    // Show Services to Customers
                    //  if (serviceToCompany == null)
                    InitdatagViewServiceToCust();
                    break;
                case "סה\"כ חיובים ללקוח":
                    InitdatagViewPriceToCustomer();
                    break;
                case "רווח לפי שירות":
                    InitdatagViewPricePerService();
                    break;
            }
        }
        #endregion Event Tab Control

        #region Temp
        // private DateTime lastActivityTime = DateTime.Now;
        //private bool isFirstTime = false;
        // Process notePad = new Process();

        // private void timer1_Tick(object sender, EventArgs e)
        // {
        //     if (lastActivityTime.AddSeconds(7) < DateTime.Now && !isFirstTime)
        //     {
        //             notePad.StartInfo.FileName = "notepad.exe";
        //             notePad.StartInfo.Arguments = "ProcessStart.cs";

        //             notePad.Start();
        //             isFirstTime = true;
        //             //if (isFirstTime)
        //             //    notePad.Close();
        //            // IsProcessOpen("notepad.exe");

        //     }
        // }

        // public void IsProcessOpen(string name)
        // {
        //     //here we're going to get a list of all running processes on
        //     //the computer
        //     foreach (Process clsProcess in Process.GetProcesses())
        //     {
        //         //now we're going to see if any of the running processes
        //         //match the currently running processes. Be sure to not
        //         //add the .exe to the name you provide, i.e: NOTEPAD,
        //         //not NOTEPAD.EXE or false is always returned even if
        //         //notepad is running.
        //         //Remember, if you have the process running more than once, 
        //         //say IE open 4 times the loop thr way it is now will close all 4,
        //         //if you want it to just close the first one it finds
        //         //then add a return; after the Kill
        //         if (clsProcess.ProcessName.Contains(name))
        //         {

        //             clsProcess.Kill();
        //             //if the process is found to be running then we
        //             //return a true

        //         }
        //     }
        //     //otherwise we return a false

        // }

        // private void Manage_KeyPress(object sender, KeyPressEventArgs e)
        // {
        //     notePad.Close();
        //     lastActivityTime = DateTime.Now;
        //     isFirstTime = false;


        // }

        // private void Manage_MouseMove(object sender, MouseEventArgs e)
        // {
        //     notePad.Close();
        //     lastActivityTime = DateTime.Now;
        //     isFirstTime = false;
        // }
        #endregion Temp
    }
}
