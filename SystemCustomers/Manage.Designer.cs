﻿namespace SystemCustomers
{
    partial class Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btchangeUser = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControlSystemCustomers = new System.Windows.Forms.TabControl();
            this.tabPManagerCustomers = new System.Windows.Forms.TabPage();
            this.tabCListCustomers = new System.Windows.Forms.TabControl();
            this.tabListCustomers = new System.Windows.Forms.TabPage();
            this.splitContainerCustomer = new System.Windows.Forms.SplitContainer();
            this.custmenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custdataGridView = new System.Windows.Forms.DataGridView();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompany_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPManageServices = new System.Windows.Forms.TabPage();
            this.tabPServices = new System.Windows.Forms.TabControl();
            this.tabListServices = new System.Windows.Forms.TabPage();
            this.splitContainerServices = new System.Windows.Forms.SplitContainer();
            this.servicemenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgridvListServices = new System.Windows.Forms.DataGridView();
            this.servicesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idService_Services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicesCompanies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPManageServiceToCustomer = new System.Windows.Forms.TabPage();
            this.tabCServicesToCustomers = new System.Windows.Forms.TabControl();
            this.tabListServicesCustomer = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStripServices = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshServicesToCustToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditServicesToCustToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteServicesToCustToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AddServicesToCustToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportExcelServicesToCustToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNumberToRemid = new System.Windows.Forms.Label();
            this.numberToRemindService = new System.Windows.Forms.NumericUpDown();
            this.dataViewingServiceToCust1 = new System.Windows.Forms.DataGridView();
            this.CompanyNameSTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName_Service_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompany_Services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idservice_Services_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidServiceCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabListServicePrice = new System.Windows.Forms.TabPage();
            this.dataGvPricePerService = new System.Windows.Forms.DataGridView();
            this.NameServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrciePerCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCustomersPayment = new System.Windows.Forms.TabPage();
            this.dataGViewingPriceToCustomer = new System.Windows.Forms.DataGridView();
            this.CompanyNamePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPriceCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPManageServiceCalls1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ServiceCallsdataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.serviceCallsmenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileServiceCallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshServiceCallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditServiceCallCollectionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditServiceCallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteServiceCallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddServiceCallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportServiceCallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToExcelServiceCallMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AllradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPManagerProject = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.projectmenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshProjectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProjectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProjectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProjectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dgridvListProject = new System.Windows.Forms.DataGridView();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectCompanies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateProjectCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabManageProjectToCompany = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProjectCompanyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProjectCompanyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProjectCompanyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportExcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportExcelProjectProviderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataViewingProjectToCompany = new System.Windows.Forms.DataGridView();
            this.NameCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStartProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFinishProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustomerProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPManagerAdmin = new System.Windows.Forms.TabPage();
            this.btnReportCompany = new System.Windows.Forms.Button();
            this.btnAddPriority = new System.Windows.Forms.Button();
            this.btnListPriority = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.companyName_Service_Call = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateOpenCalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypePriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCallsServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompany_Service_Call = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlSystemCustomers.SuspendLayout();
            this.tabPManagerCustomers.SuspendLayout();
            this.tabCListCustomers.SuspendLayout();
            this.tabListCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustomer)).BeginInit();
            this.splitContainerCustomer.Panel1.SuspendLayout();
            this.splitContainerCustomer.Panel2.SuspendLayout();
            this.splitContainerCustomer.SuspendLayout();
            this.custmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custdataGridView)).BeginInit();
            this.tabPManageServices.SuspendLayout();
            this.tabPServices.SuspendLayout();
            this.tabListServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerServices)).BeginInit();
            this.splitContainerServices.Panel1.SuspendLayout();
            this.splitContainerServices.Panel2.SuspendLayout();
            this.splitContainerServices.SuspendLayout();
            this.servicemenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridvListServices)).BeginInit();
            this.tabPManageServiceToCustomer.SuspendLayout();
            this.tabCServicesToCustomers.SuspendLayout();
            this.tabListServicesCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStripServices.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberToRemindService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewingServiceToCust1)).BeginInit();
            this.tabListServicePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvPricePerService)).BeginInit();
            this.tabCustomersPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewingPriceToCustomer)).BeginInit();
            this.tabPManageServiceCalls1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceCallsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.serviceCallsmenuStrip.SuspendLayout();
            this.tabPManagerProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.projectmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridvListProject)).BeginInit();
            this.tabManageProjectToCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewingProjectToCompany)).BeginInit();
            this.tabPManagerAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(279, 26);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(101, 23);
            this.btnMaintenance.TabIndex = 12;
            this.btnMaintenance.Text = "תחזוקה";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.BtnMaintenanceClick);
            // 
            // btchangeUser
            // 
            this.btchangeUser.Location = new System.Drawing.Point(158, 26);
            this.btchangeUser.Name = "btchangeUser";
            this.btchangeUser.Size = new System.Drawing.Size(95, 23);
            this.btchangeUser.TabIndex = 17;
            this.btchangeUser.Text = "החלפת משתמש";
            this.btchangeUser.UseVisualStyleBackColor = true;
            this.btchangeUser.Click += new System.EventHandler(this.BtchangeUserClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(339, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 19);
            this.lblWelcome.TabIndex = 18;
            // 
            // tabControlSystemCustomers
            // 
            this.tabControlSystemCustomers.Controls.Add(this.tabPManagerCustomers);
            this.tabControlSystemCustomers.Controls.Add(this.tabPManageServices);
            this.tabControlSystemCustomers.Controls.Add(this.tabPManageServiceToCustomer);
            this.tabControlSystemCustomers.Controls.Add(this.tabPManageServiceCalls1);
            this.tabControlSystemCustomers.Controls.Add(this.tabPManagerProject);
            this.tabControlSystemCustomers.Controls.Add(this.tabManageProjectToCompany);
            this.tabControlSystemCustomers.Controls.Add(this.tabPManagerAdmin);
            this.tabControlSystemCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSystemCustomers.Location = new System.Drawing.Point(0, 0);
            this.tabControlSystemCustomers.Name = "tabControlSystemCustomers";
            this.tabControlSystemCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlSystemCustomers.RightToLeftLayout = true;
            this.tabControlSystemCustomers.SelectedIndex = 0;
            this.tabControlSystemCustomers.Size = new System.Drawing.Size(917, 527);
            this.tabControlSystemCustomers.TabIndex = 21;
            this.tabControlSystemCustomers.SelectedIndexChanged += new System.EventHandler(this.TabControlSystemCustomersSelectedIndexChanged);
            // 
            // tabPManagerCustomers
            // 
            this.tabPManagerCustomers.Controls.Add(this.tabCListCustomers);
            this.tabPManagerCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabPManagerCustomers.Name = "tabPManagerCustomers";
            this.tabPManagerCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPManagerCustomers.Size = new System.Drawing.Size(909, 501);
            this.tabPManagerCustomers.TabIndex = 0;
            this.tabPManagerCustomers.Text = "לקוחות";
            this.tabPManagerCustomers.UseVisualStyleBackColor = true;
            // 
            // tabCListCustomers
            // 
            this.tabCListCustomers.Controls.Add(this.tabListCustomers);
            this.tabCListCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCListCustomers.Location = new System.Drawing.Point(3, 3);
            this.tabCListCustomers.Name = "tabCListCustomers";
            this.tabCListCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCListCustomers.RightToLeftLayout = true;
            this.tabCListCustomers.SelectedIndex = 0;
            this.tabCListCustomers.Size = new System.Drawing.Size(903, 495);
            this.tabCListCustomers.TabIndex = 4;
            this.tabCListCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabCListCustomers_KeyDown);
            // 
            // tabListCustomers
            // 
            this.tabListCustomers.Controls.Add(this.splitContainerCustomer);
            this.tabListCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabListCustomers.Name = "tabListCustomers";
            this.tabListCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabListCustomers.Size = new System.Drawing.Size(895, 469);
            this.tabListCustomers.TabIndex = 0;
            this.tabListCustomers.Text = "פרטי לקוחות";
            this.tabListCustomers.UseVisualStyleBackColor = true;
            // 
            // splitContainerCustomer
            // 
            this.splitContainerCustomer.AllowDrop = true;
            this.splitContainerCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerCustomer.Location = new System.Drawing.Point(3, 3);
            this.splitContainerCustomer.MinimumSize = new System.Drawing.Size(889, 463);
            this.splitContainerCustomer.Name = "splitContainerCustomer";
            this.splitContainerCustomer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCustomer.Panel1
            // 
            this.splitContainerCustomer.Panel1.Controls.Add(this.custmenuStrip);
            this.splitContainerCustomer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainerCustomer.Panel2
            // 
            this.splitContainerCustomer.Panel2.Controls.Add(this.custdataGridView);
            this.splitContainerCustomer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainerCustomer.Size = new System.Drawing.Size(889, 463);
            this.splitContainerCustomer.SplitterDistance = 25;
            this.splitContainerCustomer.TabIndex = 4;
            // 
            // custmenuStrip
            // 
            this.custmenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ExportToolStripMenuItem});
            this.custmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.custmenuStrip.Name = "custmenuStrip";
            this.custmenuStrip.Size = new System.Drawing.Size(889, 25);
            this.custmenuStrip.TabIndex = 2;
            this.custmenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.file_manager;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.fileToolStripMenuItem.Text = "קובץ";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.view_refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.refreshToolStripMenuItem.Text = "&רענן";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem,
            this.addRowToolStripMenuItem});
            this.editToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.accessories_text_editor;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.editToolStripMenuItem.Text = "עריכה";
            // 
            // editRowToolStripMenuItem
            // 
            this.editRowToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.edit;
            this.editRowToolStripMenuItem.Name = "editRowToolStripMenuItem";
            this.editRowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editRowToolStripMenuItem.Text = "&ערוך רשומה";
            this.editRowToolStripMenuItem.Click += new System.EventHandler(this.editRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.edit_delete;
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteRowToolStripMenuItem.Text = "&מחיקת רשומה";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.edit_add;
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addRowToolStripMenuItem.Text = "&הוספת רשומה";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToExcelToolStripMenuItem});
            this.ExportToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.lc_exportto;
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.ExportToolStripMenuItem.Text = "יצוא";
            // 
            // ExportToExcelToolStripMenuItem
            // 
            this.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem";
            this.ExportToExcelToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ExportToExcelToolStripMenuItem.Text = "יצוא לאקסל";
            this.ExportToExcelToolStripMenuItem.Click += new System.EventHandler(this.ExportToExcelToolStripMenuItem_Click);
            // 
            // custdataGridView
            // 
            this.custdataGridView.AllowUserToAddRows = false;
            this.custdataGridView.AllowUserToDeleteRows = false;
            this.custdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName,
            this.contactName,
            this.mobilePhone,
            this.email,
            this.Phone,
            this.paymentTerms,
            this.FAX,
            this.companynumber,
            this.address,
            this.city,
            this.ZIP,
            this.PostalNum,
            this.idCompany_Company});
            this.custdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custdataGridView.Location = new System.Drawing.Point(0, 0);
            this.custdataGridView.Name = "custdataGridView";
            this.custdataGridView.ReadOnly = true;
            this.custdataGridView.Size = new System.Drawing.Size(889, 434);
            this.custdataGridView.TabIndex = 3;
            this.custdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custdataGridView_CellClick);
            this.custdataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.custdataGridView_CellMouseDown);
            // 
            // companyName
            // 
            this.companyName.DataPropertyName = "companyName";
            this.companyName.HeaderText = "שם חברה";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // contactName
            // 
            this.contactName.DataPropertyName = "contactName";
            this.contactName.HeaderText = "שם נציג חברה";
            this.contactName.Name = "contactName";
            this.contactName.ReadOnly = true;
            // 
            // mobilePhone
            // 
            this.mobilePhone.DataPropertyName = "mobilePhone";
            this.mobilePhone.HeaderText = "טלפון נייד";
            this.mobilePhone.Name = "mobilePhone";
            this.mobilePhone.ReadOnly = true;
            // 
            // email
            // 
            this.email.ActiveLinkColor = System.Drawing.Color.White;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "דואר אלקטרוני";
            this.email.LinkColor = System.Drawing.Color.Blue;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.email.Text = "";
            this.email.VisitedLinkColor = System.Drawing.Color.YellowGreen;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "מספר טלפון";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // paymentTerms
            // 
            this.paymentTerms.DataPropertyName = "paymentTerms";
            this.paymentTerms.HeaderText = "תנאי תשלום";
            this.paymentTerms.Name = "paymentTerms";
            this.paymentTerms.ReadOnly = true;
            // 
            // FAX
            // 
            this.FAX.DataPropertyName = "FAX";
            this.FAX.HeaderText = "פקס";
            this.FAX.Name = "FAX";
            this.FAX.ReadOnly = true;
            // 
            // companynumber
            // 
            this.companynumber.DataPropertyName = "companynumber";
            this.companynumber.HeaderText = "מספר ח\"פ";
            this.companynumber.Name = "companynumber";
            this.companynumber.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "כתובת";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "עיר";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // ZIP
            // 
            this.ZIP.DataPropertyName = "ZIP";
            this.ZIP.HeaderText = "מיקוד";
            this.ZIP.Name = "ZIP";
            this.ZIP.ReadOnly = true;
            // 
            // PostalNum
            // 
            this.PostalNum.DataPropertyName = "PostalNum";
            this.PostalNum.HeaderText = "תא דואר";
            this.PostalNum.Name = "PostalNum";
            this.PostalNum.ReadOnly = true;
            // 
            // idCompany_Company
            // 
            this.idCompany_Company.DataPropertyName = "idCompany";
            this.idCompany_Company.HeaderText = "מספר סידורי";
            this.idCompany_Company.Name = "idCompany_Company";
            this.idCompany_Company.ReadOnly = true;
            this.idCompany_Company.Visible = false;
            // 
            // tabPManageServices
            // 
            this.tabPManageServices.Controls.Add(this.tabPServices);
            this.tabPManageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPManageServices.Name = "tabPManageServices";
            this.tabPManageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPManageServices.Size = new System.Drawing.Size(909, 501);
            this.tabPManageServices.TabIndex = 1;
            this.tabPManageServices.Text = "שירותים";
            this.tabPManageServices.UseVisualStyleBackColor = true;
            // 
            // tabPServices
            // 
            this.tabPServices.Controls.Add(this.tabListServices);
            this.tabPServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPServices.Location = new System.Drawing.Point(3, 3);
            this.tabPServices.Name = "tabPServices";
            this.tabPServices.RightToLeftLayout = true;
            this.tabPServices.SelectedIndex = 0;
            this.tabPServices.Size = new System.Drawing.Size(903, 495);
            this.tabPServices.TabIndex = 5;
            this.tabPServices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabPServices_KeyDown);
            // 
            // tabListServices
            // 
            this.tabListServices.Controls.Add(this.splitContainerServices);
            this.tabListServices.Location = new System.Drawing.Point(4, 22);
            this.tabListServices.Name = "tabListServices";
            this.tabListServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabListServices.Size = new System.Drawing.Size(895, 469);
            this.tabListServices.TabIndex = 0;
            this.tabListServices.Text = "רשימת שירותים";
            this.tabListServices.UseVisualStyleBackColor = true;
            // 
            // splitContainerServices
            // 
            this.splitContainerServices.AllowDrop = true;
            this.splitContainerServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerServices.Location = new System.Drawing.Point(3, 3);
            this.splitContainerServices.Name = "splitContainerServices";
            this.splitContainerServices.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerServices.Panel1
            // 
            this.splitContainerServices.Panel1.Controls.Add(this.servicemenuStrip);
            this.splitContainerServices.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainerServices.Panel2
            // 
            this.splitContainerServices.Panel2.Controls.Add(this.dgridvListServices);
            this.splitContainerServices.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainerServices.Size = new System.Drawing.Size(889, 463);
            this.splitContainerServices.SplitterDistance = 25;
            this.splitContainerServices.TabIndex = 8;
            // 
            // servicemenuStrip
            // 
            this.servicemenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem13});
            this.servicemenuStrip.Location = new System.Drawing.Point(0, 0);
            this.servicemenuStrip.Name = "servicemenuStrip";
            this.servicemenuStrip.Size = new System.Drawing.Size(889, 24);
            this.servicemenuStrip.TabIndex = 8;
            this.servicemenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12});
            this.toolStripMenuItem10.Image = global::SystemCustomers.Properties.Resources.file_manager;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem10.Text = "קובץ";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = global::SystemCustomers.Properties.Resources.view_refresh;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem12.Text = "&רענן";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            this.toolStripMenuItem13.Image = global::SystemCustomers.Properties.Resources.accessories_text_editor;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem13.Text = "עריכה";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Image = global::SystemCustomers.Properties.Resources.edit;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem14.Text = "&ערוך רשומה";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Image = global::SystemCustomers.Properties.Resources.edit_delete;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem15.Text = "&מחיקת רשומה";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Image = global::SystemCustomers.Properties.Resources.edit_add;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem16.Text = "&הוספת רשומה";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // dgridvListServices
            // 
            this.dgridvListServices.AllowUserToAddRows = false;
            this.dgridvListServices.AllowUserToDeleteRows = false;
            this.dgridvListServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgridvListServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgridvListServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridvListServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicesName,
            this.idService_Services,
            this.ServicesCompanies,
            this.serviceDescription});
            this.dgridvListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridvListServices.Location = new System.Drawing.Point(0, 0);
            this.dgridvListServices.Name = "dgridvListServices";
            this.dgridvListServices.ReadOnly = true;
            this.dgridvListServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgridvListServices.Size = new System.Drawing.Size(889, 434);
            this.dgridvListServices.TabIndex = 4;
            this.dgridvListServices.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgridvListServices_CellMouseDown);
            // 
            // servicesName
            // 
            this.servicesName.DataPropertyName = "servicesName";
            this.servicesName.HeaderText = "שירות";
            this.servicesName.Name = "servicesName";
            this.servicesName.ReadOnly = true;
            this.servicesName.Width = 64;
            // 
            // idService_Services
            // 
            this.idService_Services.DataPropertyName = "idService";
            this.idService_Services.HeaderText = "מספר סידורי";
            this.idService_Services.Name = "idService_Services";
            this.idService_Services.ReadOnly = true;
            this.idService_Services.Visible = false;
            this.idService_Services.Width = 97;
            // 
            // ServicesCompanies
            // 
            this.ServicesCompanies.DataPropertyName = "ServicesCompanies";
            this.ServicesCompanies.HeaderText = "ServicesCompanies";
            this.ServicesCompanies.Name = "ServicesCompanies";
            this.ServicesCompanies.ReadOnly = true;
            this.ServicesCompanies.Visible = false;
            this.ServicesCompanies.Width = 125;
            // 
            // serviceDescription
            // 
            this.serviceDescription.DataPropertyName = "serviceDescription";
            this.serviceDescription.HeaderText = "תאור שירות";
            this.serviceDescription.Name = "serviceDescription";
            this.serviceDescription.ReadOnly = true;
            this.serviceDescription.Width = 93;
            // 
            // tabPManageServiceToCustomer
            // 
            this.tabPManageServiceToCustomer.Controls.Add(this.tabCServicesToCustomers);
            this.tabPManageServiceToCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPManageServiceToCustomer.Name = "tabPManageServiceToCustomer";
            this.tabPManageServiceToCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPManageServiceToCustomer.Size = new System.Drawing.Size(909, 501);
            this.tabPManageServiceToCustomer.TabIndex = 2;
            this.tabPManageServiceToCustomer.Text = "שירותים ללקוח";
            this.tabPManageServiceToCustomer.UseVisualStyleBackColor = true;
            // 
            // tabCServicesToCustomers
            // 
            this.tabCServicesToCustomers.Controls.Add(this.tabListServicesCustomer);
            this.tabCServicesToCustomers.Controls.Add(this.tabListServicePrice);
            this.tabCServicesToCustomers.Controls.Add(this.tabCustomersPayment);
            this.tabCServicesToCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCServicesToCustomers.Location = new System.Drawing.Point(3, 3);
            this.tabCServicesToCustomers.Name = "tabCServicesToCustomers";
            this.tabCServicesToCustomers.RightToLeftLayout = true;
            this.tabCServicesToCustomers.SelectedIndex = 0;
            this.tabCServicesToCustomers.Size = new System.Drawing.Size(903, 495);
            this.tabCServicesToCustomers.TabIndex = 12;
            this.tabCServicesToCustomers.SelectedIndexChanged += new System.EventHandler(this.TabCServicesToCustomersSelectedIndexChanged);
            this.tabCServicesToCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TabCServicesToCustomersKeyDown);
            // 
            // tabListServicesCustomer
            // 
            this.tabListServicesCustomer.Controls.Add(this.splitContainer1);
            this.tabListServicesCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabListServicesCustomer.Name = "tabListServicesCustomer";
            this.tabListServicesCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabListServicesCustomer.Size = new System.Drawing.Size(895, 469);
            this.tabListServicesCustomer.TabIndex = 0;
            this.tabListServicesCustomer.Text = "רשימת שירותים ללקוח";
            this.tabListServicesCustomer.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStripServices);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(889, 463);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 10;
            // 
            // menuStripServices
            // 
            this.menuStripServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItem8});
            this.menuStripServices.Location = new System.Drawing.Point(0, 0);
            this.menuStripServices.Name = "menuStripServices";
            this.menuStripServices.Size = new System.Drawing.Size(889, 24);
            this.menuStripServices.TabIndex = 10;
            this.menuStripServices.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshServicesToCustToolStrip});
            this.toolStripMenuItem1.Image = global::SystemCustomers.Properties.Resources.file_manager;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "קובץ";
            // 
            // RefreshServicesToCustToolStrip
            // 
            this.RefreshServicesToCustToolStrip.Image = global::SystemCustomers.Properties.Resources.view_refresh;
            this.RefreshServicesToCustToolStrip.Name = "RefreshServicesToCustToolStrip";
            this.RefreshServicesToCustToolStrip.Size = new System.Drawing.Size(96, 22);
            this.RefreshServicesToCustToolStrip.Text = "&רענן";
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditServicesToCustToolStrip,
            this.DeleteServicesToCustToolStrip,
            this.AddServicesToCustToolStrip,
            this.setColorToolStripMenuItem,
            this.setBackgroundToolStripMenuItem});
            this.toolStripMenuItemEdit.Image = global::SystemCustomers.Properties.Resources.accessories_text_editor;
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItemEdit.Text = "עריכה";
            // 
            // EditServicesToCustToolStrip
            // 
            this.EditServicesToCustToolStrip.Image = global::SystemCustomers.Properties.Resources.edit;
            this.EditServicesToCustToolStrip.Name = "EditServicesToCustToolStrip";
            this.EditServicesToCustToolStrip.Size = new System.Drawing.Size(166, 22);
            this.EditServicesToCustToolStrip.Text = "&ערוך רשומה";
            this.EditServicesToCustToolStrip.Click += new System.EventHandler(this.EditServicesToCustToolStrip_Click);
            // 
            // DeleteServicesToCustToolStrip
            // 
            this.DeleteServicesToCustToolStrip.Image = global::SystemCustomers.Properties.Resources.edit_delete;
            this.DeleteServicesToCustToolStrip.Name = "DeleteServicesToCustToolStrip";
            this.DeleteServicesToCustToolStrip.Size = new System.Drawing.Size(166, 22);
            this.DeleteServicesToCustToolStrip.Text = "&מחיקת רשומה";
            this.DeleteServicesToCustToolStrip.Click += new System.EventHandler(this.DeleteServicesToCustToolStrip_Click);
            // 
            // AddServicesToCustToolStrip
            // 
            this.AddServicesToCustToolStrip.Image = global::SystemCustomers.Properties.Resources.edit_add;
            this.AddServicesToCustToolStrip.Name = "AddServicesToCustToolStrip";
            this.AddServicesToCustToolStrip.Size = new System.Drawing.Size(166, 22);
            this.AddServicesToCustToolStrip.Text = "&הוספת רשומה";
            this.AddServicesToCustToolStrip.Click += new System.EventHandler(this.AddServicesToCustToolStrip_Click);
            // 
            // setColorToolStripMenuItem
            // 
            this.setColorToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.colors;
            this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            this.setColorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.setColorToolStripMenuItem.Text = "בחירת צבע";
            this.setColorToolStripMenuItem.Click += new System.EventHandler(this.setColorToolStripMenuItem_Click);
            // 
            // setBackgroundToolStripMenuItem
            // 
            this.setBackgroundToolStripMenuItem.CheckOnClick = true;
            this.setBackgroundToolStripMenuItem.Image = global::SystemCustomers.Properties.Resources.lc_selectmode;
            this.setBackgroundToolStripMenuItem.Name = "setBackgroundToolStripMenuItem";
            this.setBackgroundToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.setBackgroundToolStripMenuItem.Text = "צבע רקע או כיתוב";
            this.setBackgroundToolStripMenuItem.CheckedChanged += new System.EventHandler(this.setBackgroundToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportExcelServicesToCustToolStrip});
            this.toolStripMenuItem8.Image = global::SystemCustomers.Properties.Resources.lc_exportto;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem8.Text = "יצוא";
            // 
            // ExportExcelServicesToCustToolStrip
            // 
            this.ExportExcelServicesToCustToolStrip.Name = "ExportExcelServicesToCustToolStrip";
            this.ExportExcelServicesToCustToolStrip.Size = new System.Drawing.Size(136, 22);
            this.ExportExcelServicesToCustToolStrip.Text = "יצוא לאקסל";
            this.ExportExcelServicesToCustToolStrip.Click += new System.EventHandler(this.ExportExcelServicesToCustToolStrip_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.dataViewingServiceToCust1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(889, 434);
            this.panel3.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblNumberToRemid);
            this.panel5.Controls.Add(this.numberToRemindService);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(153, 337);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(736, 97);
            this.panel5.TabIndex = 11;
            // 
            // lblNumberToRemid
            // 
            this.lblNumberToRemid.AutoSize = true;
            this.lblNumberToRemid.Location = new System.Drawing.Point(525, 17);
            this.lblNumberToRemid.Name = "lblNumberToRemid";
            this.lblNumberToRemid.Size = new System.Drawing.Size(202, 13);
            this.lblNumberToRemid.TabIndex = 5;
            this.lblNumberToRemid.Text = "מספר חודשים לסיום חוזי שרות ללקוח";
            // 
            // numberToRemindService
            // 
            this.numberToRemindService.AutoSize = true;
            this.numberToRemindService.Location = new System.Drawing.Point(459, 15);
            this.numberToRemindService.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numberToRemindService.Name = "numberToRemindService";
            this.numberToRemindService.Size = new System.Drawing.Size(49, 20);
            this.numberToRemindService.TabIndex = 4;
            this.numberToRemindService.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberToRemindService.ValueChanged += new System.EventHandler(this.numberToRemindService_ValueChanged);
            // 
            // dataViewingServiceToCust1
            // 
            this.dataViewingServiceToCust1.AllowUserToAddRows = false;
            this.dataViewingServiceToCust1.AllowUserToDeleteRows = false;
            this.dataViewingServiceToCust1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewingServiceToCust1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyNameSTC,
            this.serviceName_Service_Company,
            this.startdate,
            this.enddate,
            this.price,
            this.priceCost,
            this.idCustService,
            this.IdCompany_Services,
            this.idservice_Services_Company,
            this.paidServiceCompany});
            this.dataViewingServiceToCust1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataViewingServiceToCust1.Location = new System.Drawing.Point(0, 0);
            this.dataViewingServiceToCust1.Name = "dataViewingServiceToCust1";
            this.dataViewingServiceToCust1.ReadOnly = true;
            this.dataViewingServiceToCust1.Size = new System.Drawing.Size(889, 337);
            this.dataViewingServiceToCust1.TabIndex = 10;
            this.dataViewingServiceToCust1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataViewingServiceToCust1_CellFormatting);
            this.dataViewingServiceToCust1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataViewingServiceToCust1_CellMouseDown);
            // 
            // CompanyNameSTC
            // 
            this.CompanyNameSTC.DataPropertyName = "companyName";
            this.CompanyNameSTC.Frozen = true;
            this.CompanyNameSTC.HeaderText = "שם חברה";
            this.CompanyNameSTC.Name = "CompanyNameSTC";
            this.CompanyNameSTC.ReadOnly = true;
            // 
            // serviceName_Service_Company
            // 
            this.serviceName_Service_Company.DataPropertyName = "servicesName";
            this.serviceName_Service_Company.Frozen = true;
            this.serviceName_Service_Company.HeaderText = "שירות";
            this.serviceName_Service_Company.Name = "serviceName_Service_Company";
            this.serviceName_Service_Company.ReadOnly = true;
            // 
            // startdate
            // 
            this.startdate.DataPropertyName = "startdate";
            this.startdate.Frozen = true;
            this.startdate.HeaderText = "תאריך תחילת מכירת שירות";
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            // 
            // enddate
            // 
            this.enddate.DataPropertyName = "enddate";
            this.enddate.Frozen = true;
            this.enddate.HeaderText = "תאריך יעד שירות";
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.Frozen = true;
            this.price.HeaderText = "מחיר";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // priceCost
            // 
            this.priceCost.DataPropertyName = "priceCost";
            this.priceCost.Frozen = true;
            this.priceCost.HeaderText = "מחיר עלות";
            this.priceCost.Name = "priceCost";
            this.priceCost.ReadOnly = true;
            // 
            // idCustService
            // 
            this.idCustService.DataPropertyName = "idCustService";
            this.idCustService.Frozen = true;
            this.idCustService.HeaderText = "מספר סידורי";
            this.idCustService.Name = "idCustService";
            this.idCustService.ReadOnly = true;
            this.idCustService.Visible = false;
            // 
            // IdCompany_Services
            // 
            this.IdCompany_Services.DataPropertyName = "idCompany";
            this.IdCompany_Services.Frozen = true;
            this.IdCompany_Services.HeaderText = "מספר לקוח";
            this.IdCompany_Services.Name = "IdCompany_Services";
            this.IdCompany_Services.ReadOnly = true;
            this.IdCompany_Services.Visible = false;
            // 
            // idservice_Services_Company
            // 
            this.idservice_Services_Company.DataPropertyName = "idService";
            this.idservice_Services_Company.Frozen = true;
            this.idservice_Services_Company.HeaderText = "מספר שרות";
            this.idservice_Services_Company.Name = "idservice_Services_Company";
            this.idservice_Services_Company.ReadOnly = true;
            this.idservice_Services_Company.Visible = false;
            // 
            // paidServiceCompany
            // 
            this.paidServiceCompany.DataPropertyName = "paid";
            this.paidServiceCompany.Frozen = true;
            this.paidServiceCompany.HeaderText = "מצב תשלום";
            this.paidServiceCompany.Name = "paidServiceCompany";
            this.paidServiceCompany.ReadOnly = true;
            // 
            // tabListServicePrice
            // 
            this.tabListServicePrice.Controls.Add(this.dataGvPricePerService);
            this.tabListServicePrice.Location = new System.Drawing.Point(4, 22);
            this.tabListServicePrice.Name = "tabListServicePrice";
            this.tabListServicePrice.Size = new System.Drawing.Size(895, 469);
            this.tabListServicePrice.TabIndex = 2;
            this.tabListServicePrice.Text = "רווח לפי שירות";
            this.tabListServicePrice.UseVisualStyleBackColor = true;
            // 
            // dataGvPricePerService
            // 
            this.dataGvPricePerService.AllowUserToAddRows = false;
            this.dataGvPricePerService.AllowUserToDeleteRows = false;
            this.dataGvPricePerService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvPricePerService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameServiceType,
            this.PrciePerCustomer,
            this.Cost,
            this.dataGridViewTextBoxColumn1});
            this.dataGvPricePerService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGvPricePerService.Location = new System.Drawing.Point(0, 0);
            this.dataGvPricePerService.Name = "dataGvPricePerService";
            this.dataGvPricePerService.ReadOnly = true;
            this.dataGvPricePerService.Size = new System.Drawing.Size(895, 469);
            this.dataGvPricePerService.TabIndex = 1;
            // 
            // NameServiceType
            // 
            this.NameServiceType.HeaderText = "מוצר";
            this.NameServiceType.Name = "NameServiceType";
            this.NameServiceType.ReadOnly = true;
            // 
            // PrciePerCustomer
            // 
            this.PrciePerCustomer.HeaderText = "מחיר ללקוח";
            this.PrciePerCustomer.Name = "PrciePerCustomer";
            this.PrciePerCustomer.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "מחיר עלות";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "סה\"כ רווח";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tabCustomersPayment
            // 
            this.tabCustomersPayment.Controls.Add(this.dataGViewingPriceToCustomer);
            this.tabCustomersPayment.Location = new System.Drawing.Point(4, 22);
            this.tabCustomersPayment.Name = "tabCustomersPayment";
            this.tabCustomersPayment.Size = new System.Drawing.Size(895, 469);
            this.tabCustomersPayment.TabIndex = 3;
            this.tabCustomersPayment.Text = "סה\"כ חיובים ללקוח";
            this.tabCustomersPayment.UseVisualStyleBackColor = true;
            // 
            // dataGViewingPriceToCustomer
            // 
            this.dataGViewingPriceToCustomer.AllowUserToAddRows = false;
            this.dataGViewingPriceToCustomer.AllowUserToDeleteRows = false;
            this.dataGViewingPriceToCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGViewingPriceToCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyNamePay,
            this.SumPriceCustomers});
            this.dataGViewingPriceToCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGViewingPriceToCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGViewingPriceToCustomer.Name = "dataGViewingPriceToCustomer";
            this.dataGViewingPriceToCustomer.ReadOnly = true;
            this.dataGViewingPriceToCustomer.Size = new System.Drawing.Size(895, 469);
            this.dataGViewingPriceToCustomer.TabIndex = 1;
            // 
            // CompanyNamePay
            // 
            this.CompanyNamePay.DataPropertyName = "companyName";
            this.CompanyNamePay.HeaderText = "שם חברה";
            this.CompanyNamePay.Name = "CompanyNamePay";
            this.CompanyNamePay.ReadOnly = true;
            this.CompanyNamePay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyNamePay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CompanyNamePay.Width = 150;
            // 
            // SumPriceCustomers
            // 
            this.SumPriceCustomers.DataPropertyName = "price";
            this.SumPriceCustomers.HeaderText = "סה\"כ חיובים";
            this.SumPriceCustomers.Name = "SumPriceCustomers";
            this.SumPriceCustomers.ReadOnly = true;
            // 
            // tabPManageServiceCalls1
            // 
            this.tabPManageServiceCalls1.Controls.Add(this.panel4);
            this.tabPManageServiceCalls1.Controls.Add(this.splitContainer2);
            this.tabPManageServiceCalls1.Location = new System.Drawing.Point(4, 22);
            this.tabPManageServiceCalls1.Name = "tabPManageServiceCalls1";
            this.tabPManageServiceCalls1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPManageServiceCalls1.Size = new System.Drawing.Size(909, 501);
            this.tabPManageServiceCalls1.TabIndex = 3;
            this.tabPManageServiceCalls1.Text = "קריאות שרות";
            this.tabPManageServiceCalls1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ServiceCallsdataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(903, 468);
            this.panel4.TabIndex = 12;
            // 
            // ServiceCallsdataGridView
            // 
            this.ServiceCallsdataGridView.AllowUserToAddRows = false;
            this.ServiceCallsdataGridView.AllowUserToDeleteRows = false;
            this.ServiceCallsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceCallsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName_Service_Call,
            this.dateOpenCalls,
            this.discriptions,
            this.TypePriority,
            this.status,
            this.idCallsServices,
            this.idCompany_Service_Call,
            this.idPriority});
            this.ServiceCallsdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceCallsdataGridView.Location = new System.Drawing.Point(0, 0);
            this.ServiceCallsdataGridView.Name = "ServiceCallsdataGridView";
            this.ServiceCallsdataGridView.ReadOnly = true;
            this.ServiceCallsdataGridView.Size = new System.Drawing.Size(903, 468);
            this.ServiceCallsdataGridView.TabIndex = 2;
            this.ServiceCallsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceCallsdataGridView_CellContentClick);
            this.ServiceCallsdataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ServiceCallsdataGridView_CellFormatting);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.serviceCallsmenuStrip);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.AllradioButton);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.monthRadioButton);
            this.splitContainer2.Panel2.Controls.Add(this.weekRadioButton);
            this.splitContainer2.Panel2.Controls.Add(this.dayRadioButton);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(903, 27);
            this.splitContainer2.SplitterDistance = 394;
            this.splitContainer2.TabIndex = 13;
            // 
            // serviceCallsmenuStrip
            // 
            this.serviceCallsmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileServiceCallMenu,
            this.EditServiceCallCollectionMenu,
            this.ExportServiceCallMenu});
            this.serviceCallsmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.serviceCallsmenuStrip.Name = "serviceCallsmenuStrip";
            this.serviceCallsmenuStrip.Size = new System.Drawing.Size(394, 24);
            this.serviceCallsmenuStrip.TabIndex = 3;
            this.serviceCallsmenuStrip.Text = "menuStrip1";
            // 
            // FileServiceCallMenu
            // 
            this.FileServiceCallMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshServiceCallMenu});
            this.FileServiceCallMenu.Image = global::SystemCustomers.Properties.Resources.file_manager;
            this.FileServiceCallMenu.Name = "FileServiceCallMenu";
            this.FileServiceCallMenu.Size = new System.Drawing.Size(60, 20);
            this.FileServiceCallMenu.Text = "קובץ";
            // 
            // RefreshServiceCallMenu
            // 
            this.RefreshServiceCallMenu.Image = global::SystemCustomers.Properties.Resources.view_refresh;
            this.RefreshServiceCallMenu.Name = "RefreshServiceCallMenu";
            this.RefreshServiceCallMenu.Size = new System.Drawing.Size(96, 22);
            this.RefreshServiceCallMenu.Text = "&רענן";
            this.RefreshServiceCallMenu.Click += new System.EventHandler(this.RefreshServiceCallMenu_Click);
            // 
            // EditServiceCallCollectionMenu
            // 
            this.EditServiceCallCollectionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditServiceCallMenu,
            this.DeleteServiceCallMenu,
            this.AddServiceCallMenu});
            this.EditServiceCallCollectionMenu.Image = global::SystemCustomers.Properties.Resources.accessories_text_editor;
            this.EditServiceCallCollectionMenu.Name = "EditServiceCallCollectionMenu";
            this.EditServiceCallCollectionMenu.Size = new System.Drawing.Size(67, 20);
            this.EditServiceCallCollectionMenu.Text = "עריכה";
            // 
            // EditServiceCallMenu
            // 
            this.EditServiceCallMenu.Image = global::SystemCustomers.Properties.Resources.edit;
            this.EditServiceCallMenu.Name = "EditServiceCallMenu";
            this.EditServiceCallMenu.Size = new System.Drawing.Size(148, 22);
            this.EditServiceCallMenu.Text = "&ערוך רשומה";
            this.EditServiceCallMenu.Click += new System.EventHandler(this.EditServiceCallMenu_Click);
            // 
            // DeleteServiceCallMenu
            // 
            this.DeleteServiceCallMenu.Image = global::SystemCustomers.Properties.Resources.edit_delete;
            this.DeleteServiceCallMenu.Name = "DeleteServiceCallMenu";
            this.DeleteServiceCallMenu.Size = new System.Drawing.Size(148, 22);
            this.DeleteServiceCallMenu.Text = "&מחיקת רשומה";
            this.DeleteServiceCallMenu.Click += new System.EventHandler(this.DeleteServiceCallMenu_Click);
            // 
            // AddServiceCallMenu
            // 
            this.AddServiceCallMenu.Image = global::SystemCustomers.Properties.Resources.edit_add;
            this.AddServiceCallMenu.Name = "AddServiceCallMenu";
            this.AddServiceCallMenu.Size = new System.Drawing.Size(148, 22);
            this.AddServiceCallMenu.Text = "&הוספת רשומה";
            this.AddServiceCallMenu.Click += new System.EventHandler(this.AddServiceCallMenu_Click);
            // 
            // ExportServiceCallMenu
            // 
            this.ExportServiceCallMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToExcelServiceCallMenu});
            this.ExportServiceCallMenu.Image = global::SystemCustomers.Properties.Resources.lc_exportto;
            this.ExportServiceCallMenu.Name = "ExportServiceCallMenu";
            this.ExportServiceCallMenu.Size = new System.Drawing.Size(56, 20);
            this.ExportServiceCallMenu.Text = "יצוא";
            // 
            // ExportToExcelServiceCallMenu
            // 
            this.ExportToExcelServiceCallMenu.Name = "ExportToExcelServiceCallMenu";
            this.ExportToExcelServiceCallMenu.Size = new System.Drawing.Size(136, 22);
            this.ExportToExcelServiceCallMenu.Text = "יצוא לאקסל";
            this.ExportToExcelServiceCallMenu.Click += new System.EventHandler(this.ExportToExcelServiceCallMenu_Click);
            // 
            // AllradioButton
            // 
            this.AllradioButton.AutoSize = true;
            this.AllradioButton.Checked = true;
            this.AllradioButton.Location = new System.Drawing.Point(241, 5);
            this.AllradioButton.Name = "AllradioButton";
            this.AllradioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllradioButton.Size = new System.Drawing.Size(46, 17);
            this.AllradioButton.TabIndex = 11;
            this.AllradioButton.TabStop = true;
            this.AllradioButton.Text = "הכל";
            this.AllradioButton.UseVisualStyleBackColor = true;
            this.AllradioButton.Click += new System.EventHandler(this.AllRadioButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "בחירת תצוגה:";
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Location = new System.Drawing.Point(56, 5);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthRadioButton.Size = new System.Drawing.Size(53, 17);
            this.monthRadioButton.TabIndex = 9;
            this.monthRadioButton.Text = "חודש";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.Click += new System.EventHandler(this.MonthRadioButtonClick);
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Location = new System.Drawing.Point(118, 5);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.weekRadioButton.Size = new System.Drawing.Size(53, 17);
            this.weekRadioButton.TabIndex = 8;
            this.weekRadioButton.Text = "שבוע";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            this.weekRadioButton.Click += new System.EventHandler(this.WeekRadioButtonClick);
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(185, 5);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dayRadioButton.Size = new System.Drawing.Size(42, 17);
            this.dayRadioButton.TabIndex = 7;
            this.dayRadioButton.Text = "יום";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            this.dayRadioButton.Click += new System.EventHandler(this.DayRadioButtonClick);
            // 
            // tabPManagerProject
            // 
            this.tabPManagerProject.CausesValidation = false;
            this.tabPManagerProject.Controls.Add(this.splitContainer3);
            this.tabPManagerProject.Location = new System.Drawing.Point(4, 22);
            this.tabPManagerProject.Name = "tabPManagerProject";
            this.tabPManagerProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPManagerProject.Size = new System.Drawing.Size(909, 501);
            this.tabPManagerProject.TabIndex = 5;
            this.tabPManagerProject.Text = "פרויקטים";
            this.tabPManagerProject.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.projectmenuStrip);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgridvListProject);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(903, 495);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 6;
            // 
            // projectmenuStrip
            // 
            this.projectmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17,
            this.toolStripMenuItem20});
            this.projectmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.projectmenuStrip.Name = "projectmenuStrip";
            this.projectmenuStrip.Size = new System.Drawing.Size(903, 24);
            this.projectmenuStrip.TabIndex = 4;
            this.projectmenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshProjectMenu});
            this.toolStripMenuItem17.Image = global::SystemCustomers.Properties.Resources.file_manager;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem17.Text = "קובץ";
            // 
            // RefreshProjectMenu
            // 
            this.RefreshProjectMenu.Image = global::SystemCustomers.Properties.Resources.view_refresh;
            this.RefreshProjectMenu.Name = "RefreshProjectMenu";
            this.RefreshProjectMenu.Size = new System.Drawing.Size(96, 22);
            this.RefreshProjectMenu.Text = "&רענן";
            this.RefreshProjectMenu.Click += new System.EventHandler(this.RefreshProjectMenu_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditProjectMenu,
            this.DeleteProjectMenu,
            this.AddProjectMenu});
            this.toolStripMenuItem20.Image = global::SystemCustomers.Properties.Resources.accessories_text_editor;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem20.Text = "עריכה";
            // 
            // EditProjectMenu
            // 
            this.EditProjectMenu.Image = global::SystemCustomers.Properties.Resources.edit;
            this.EditProjectMenu.Name = "EditProjectMenu";
            this.EditProjectMenu.Size = new System.Drawing.Size(148, 22);
            this.EditProjectMenu.Text = "&ערוך רשומה";
            this.EditProjectMenu.Click += new System.EventHandler(this.EditProjectMenu_Click);
            // 
            // DeleteProjectMenu
            // 
            this.DeleteProjectMenu.Image = global::SystemCustomers.Properties.Resources.edit_delete;
            this.DeleteProjectMenu.Name = "DeleteProjectMenu";
            this.DeleteProjectMenu.Size = new System.Drawing.Size(148, 22);
            this.DeleteProjectMenu.Text = "&מחיקת רשומה";
            this.DeleteProjectMenu.Click += new System.EventHandler(this.DeleteProjectMenu_Click);
            // 
            // AddProjectMenu
            // 
            this.AddProjectMenu.Image = global::SystemCustomers.Properties.Resources.edit_add;
            this.AddProjectMenu.Name = "AddProjectMenu";
            this.AddProjectMenu.Size = new System.Drawing.Size(148, 22);
            this.AddProjectMenu.Text = "&הוספת רשומה";
            this.AddProjectMenu.Click += new System.EventHandler(this.AddProjectMenu_Click);
            // 
            // dgridvListProject
            // 
            this.dgridvListProject.AllowUserToAddRows = false;
            this.dgridvListProject.AllowUserToDeleteRows = false;
            this.dgridvListProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgridvListProject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgridvListProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridvListProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectName,
            this.projectDescription,
            this.idProject,
            this.ProjectCompanies,
            this.DateProjectCompany});
            this.dgridvListProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridvListProject.Location = new System.Drawing.Point(0, 0);
            this.dgridvListProject.Name = "dgridvListProject";
            this.dgridvListProject.ReadOnly = true;
            this.dgridvListProject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgridvListProject.Size = new System.Drawing.Size(903, 466);
            this.dgridvListProject.TabIndex = 3;
            // 
            // projectName
            // 
            this.projectName.DataPropertyName = "projectName";
            this.projectName.HeaderText = "שם פרויקט";
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            this.projectName.Width = 81;
            // 
            // projectDescription
            // 
            this.projectDescription.DataPropertyName = "projectDescription";
            this.projectDescription.HeaderText = "תאור הפרויקט";
            this.projectDescription.Name = "projectDescription";
            this.projectDescription.ReadOnly = true;
            this.projectDescription.Width = 96;
            // 
            // idProject
            // 
            this.idProject.DataPropertyName = "idProject";
            this.idProject.HeaderText = "מספר סידורי";
            this.idProject.Name = "idProject";
            this.idProject.ReadOnly = true;
            this.idProject.Visible = false;
            this.idProject.Width = 89;
            // 
            // ProjectCompanies
            // 
            this.ProjectCompanies.DataPropertyName = "ProjectCompanies";
            this.ProjectCompanies.HeaderText = "ProjectCompanies";
            this.ProjectCompanies.Name = "ProjectCompanies";
            this.ProjectCompanies.ReadOnly = true;
            this.ProjectCompanies.Visible = false;
            this.ProjectCompanies.Width = 117;
            // 
            // DateProjectCompany
            // 
            this.DateProjectCompany.DataPropertyName = "DateProjectCompany";
            this.DateProjectCompany.HeaderText = "DateProjectCompany";
            this.DateProjectCompany.Name = "DateProjectCompany";
            this.DateProjectCompany.ReadOnly = true;
            this.DateProjectCompany.Visible = false;
            this.DateProjectCompany.Width = 132;
            // 
            // tabManageProjectToCompany
            // 
            this.tabManageProjectToCompany.Controls.Add(this.splitContainer4);
            this.tabManageProjectToCompany.Location = new System.Drawing.Point(4, 22);
            this.tabManageProjectToCompany.Name = "tabManageProjectToCompany";
            this.tabManageProjectToCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageProjectToCompany.Size = new System.Drawing.Size(909, 501);
            this.tabManageProjectToCompany.TabIndex = 6;
            this.tabManageProjectToCompany.Text = "ניהול פרויקטים לספק";
            this.tabManageProjectToCompany.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.AllowDrop = true;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataViewingProjectToCompany);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Size = new System.Drawing.Size(903, 495);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem24,
            this.toolStripMenuItem27,
            this.ExportExcelMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshMenu});
            this.toolStripMenuItem24.Image = global::SystemCustomers.Properties.Resources.file_manager;
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem24.Text = "קובץ";
            // 
            // RefreshMenu
            // 
            this.RefreshMenu.Image = global::SystemCustomers.Properties.Resources.view_refresh;
            this.RefreshMenu.Name = "RefreshMenu";
            this.RefreshMenu.Size = new System.Drawing.Size(96, 22);
            this.RefreshMenu.Text = "&רענן";
            this.RefreshMenu.Click += new System.EventHandler(this.RefreshMenu_Click);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditProjectCompanyMenu,
            this.DeleteProjectCompanyMenu,
            this.AddProjectCompanyMenu});
            this.toolStripMenuItem27.Image = global::SystemCustomers.Properties.Resources.accessories_text_editor;
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem27.Text = "עריכה";
            // 
            // EditProjectCompanyMenu
            // 
            this.EditProjectCompanyMenu.Image = global::SystemCustomers.Properties.Resources.edit;
            this.EditProjectCompanyMenu.Name = "EditProjectCompanyMenu";
            this.EditProjectCompanyMenu.Size = new System.Drawing.Size(148, 22);
            this.EditProjectCompanyMenu.Text = "&ערוך רשומה";
            this.EditProjectCompanyMenu.Click += new System.EventHandler(this.EditProjectCompanyMenu_Click);
            // 
            // DeleteProjectCompanyMenu
            // 
            this.DeleteProjectCompanyMenu.Image = global::SystemCustomers.Properties.Resources.edit_delete;
            this.DeleteProjectCompanyMenu.Name = "DeleteProjectCompanyMenu";
            this.DeleteProjectCompanyMenu.Size = new System.Drawing.Size(148, 22);
            this.DeleteProjectCompanyMenu.Text = "&מחיקת רשומה";
            this.DeleteProjectCompanyMenu.Click += new System.EventHandler(this.DeleteProjectCompanyMenuClick);
            // 
            // AddProjectCompanyMenu
            // 
            this.AddProjectCompanyMenu.Image = global::SystemCustomers.Properties.Resources.edit_add;
            this.AddProjectCompanyMenu.Name = "AddProjectCompanyMenu";
            this.AddProjectCompanyMenu.Size = new System.Drawing.Size(148, 22);
            this.AddProjectCompanyMenu.Text = "&הוספת רשומה";
            this.AddProjectCompanyMenu.Click += new System.EventHandler(this.AddProjectCompanyMenu_Click);
            // 
            // ExportExcelMenu
            // 
            this.ExportExcelMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportExcelProjectProviderMenu});
            this.ExportExcelMenu.Image = global::SystemCustomers.Properties.Resources.lc_exportto;
            this.ExportExcelMenu.Name = "ExportExcelMenu";
            this.ExportExcelMenu.Size = new System.Drawing.Size(56, 20);
            this.ExportExcelMenu.Text = "יצוא";
            // 
            // ExportExcelProjectProviderMenu
            // 
            this.ExportExcelProjectProviderMenu.Name = "ExportExcelProjectProviderMenu";
            this.ExportExcelProjectProviderMenu.Size = new System.Drawing.Size(136, 22);
            this.ExportExcelProjectProviderMenu.Text = "יצוא לאקסל";
            this.ExportExcelProjectProviderMenu.Click += new System.EventHandler(this.ExportExcelProjectProviderMenu_Click);
            // 
            // dataViewingProjectToCompany
            // 
            this.dataViewingProjectToCompany.AllowDrop = true;
            this.dataViewingProjectToCompany.AllowUserToAddRows = false;
            this.dataViewingProjectToCompany.AllowUserToDeleteRows = false;
            this.dataViewingProjectToCompany.AllowUserToOrderColumns = true;
            this.dataViewingProjectToCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCompany,
            this.NameProject,
            this.DateStartProject,
            this.DateFinishProject,
            this.priceType,
            this.paid,
            this.Discription,
            this.idCustomerProject,
            this.idCompany,
            this.ProjectId,
            this.destination});
            this.dataViewingProjectToCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewingProjectToCompany.Location = new System.Drawing.Point(0, 0);
            this.dataViewingProjectToCompany.Name = "dataViewingProjectToCompany";
            this.dataViewingProjectToCompany.ReadOnly = true;
            this.dataViewingProjectToCompany.Size = new System.Drawing.Size(903, 466);
            this.dataViewingProjectToCompany.TabIndex = 6;
            this.dataViewingProjectToCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewingProjectToCompanyCellClick);
            // 
            // NameCompany
            // 
            this.NameCompany.DataPropertyName = "companyName";
            this.NameCompany.Frozen = true;
            this.NameCompany.HeaderText = "שם חברה";
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.ReadOnly = true;
            this.NameCompany.Width = 78;
            // 
            // NameProject
            // 
            this.NameProject.DataPropertyName = "projectName";
            this.NameProject.Frozen = true;
            this.NameProject.HeaderText = "שם פרויקט";
            this.NameProject.Name = "NameProject";
            this.NameProject.ReadOnly = true;
            this.NameProject.Width = 88;
            // 
            // DateStartProject
            // 
            this.DateStartProject.DataPropertyName = "DateStartProject";
            this.DateStartProject.HeaderText = "תאריך התחלת פרויקט";
            this.DateStartProject.Name = "DateStartProject";
            this.DateStartProject.ReadOnly = true;
            this.DateStartProject.Width = 143;
            // 
            // DateFinishProject
            // 
            this.DateFinishProject.DataPropertyName = "DateFinishProject";
            this.DateFinishProject.HeaderText = "תאריך סיום פרויקט";
            this.DateFinishProject.Name = "DateFinishProject";
            this.DateFinishProject.ReadOnly = true;
            this.DateFinishProject.Width = 132;
            // 
            // priceType
            // 
            this.priceType.DataPropertyName = "priceType";
            this.priceType.HeaderText = "פריסת תשלום";
            this.priceType.Name = "priceType";
            this.priceType.ReadOnly = true;
            this.priceType.Width = 102;
            // 
            // paid
            // 
            this.paid.DataPropertyName = "paid";
            this.paid.HeaderText = "סטטוס תשלום";
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            this.paid.Width = 103;
            // 
            // Discription
            // 
            this.Discription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Discription.DataPropertyName = "discriptions";
            this.Discription.FillWeight = 250F;
            this.Discription.HeaderText = "הערות";
            this.Discription.Name = "Discription";
            this.Discription.ReadOnly = true;
            this.Discription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Discription.Width = 64;
            // 
            // idCustomerProject
            // 
            this.idCustomerProject.DataPropertyName = "idCustomerProject";
            this.idCustomerProject.HeaderText = "מספר סידורי";
            this.idCustomerProject.Name = "idCustomerProject";
            this.idCustomerProject.ReadOnly = true;
            this.idCustomerProject.Visible = false;
            this.idCustomerProject.Width = 97;
            // 
            // idCompany
            // 
            this.idCompany.DataPropertyName = "idCompany";
            this.idCompany.HeaderText = "מספר לקוח";
            this.idCompany.Name = "idCompany";
            this.idCompany.ReadOnly = true;
            this.idCompany.Visible = false;
            this.idCompany.Width = 88;
            // 
            // ProjectId
            // 
            this.ProjectId.DataPropertyName = "idProject";
            this.ProjectId.HeaderText = "מספר פרויקט";
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.ReadOnly = true;
            this.ProjectId.Visible = false;
            this.ProjectId.Width = 99;
            // 
            // destination
            // 
            this.destination.DataPropertyName = "destination";
            this.destination.HeaderText = "קובץ פרטים";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.destination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.destination.Width = 94;
            // 
            // tabPManagerAdmin
            // 
            this.tabPManagerAdmin.Controls.Add(this.btnReportCompany);
            this.tabPManagerAdmin.Controls.Add(this.btnAddPriority);
            this.tabPManagerAdmin.Controls.Add(this.btnListPriority);
            this.tabPManagerAdmin.Controls.Add(this.btchangeUser);
            this.tabPManagerAdmin.Controls.Add(this.btnAddUser);
            this.tabPManagerAdmin.Controls.Add(this.btnDeleteUser);
            this.tabPManagerAdmin.Controls.Add(this.btnMaintenance);
            this.tabPManagerAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPManagerAdmin.Name = "tabPManagerAdmin";
            this.tabPManagerAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPManagerAdmin.Size = new System.Drawing.Size(909, 501);
            this.tabPManagerAdmin.TabIndex = 4;
            this.tabPManagerAdmin.Text = "מנהל";
            this.tabPManagerAdmin.UseVisualStyleBackColor = true;
            // 
            // btnReportCompany
            // 
            this.btnReportCompany.Location = new System.Drawing.Point(729, 84);
            this.btnReportCompany.Name = "btnReportCompany";
            this.btnReportCompany.Size = new System.Drawing.Size(137, 23);
            this.btnReportCompany.TabIndex = 22;
            this.btnReportCompany.Text = "דוחות ספקים";
            this.btnReportCompany.UseVisualStyleBackColor = true;
            // 
            // btnAddPriority
            // 
            this.btnAddPriority.Location = new System.Drawing.Point(566, 26);
            this.btnAddPriority.Name = "btnAddPriority";
            this.btnAddPriority.Size = new System.Drawing.Size(96, 23);
            this.btnAddPriority.TabIndex = 21;
            this.btnAddPriority.Text = "הוספת עדיפות";
            this.btnAddPriority.UseVisualStyleBackColor = true;
            this.btnAddPriority.Click += new System.EventHandler(this.BtnAddPriorityClick);
            // 
            // btnListPriority
            // 
            this.btnListPriority.Location = new System.Drawing.Point(454, 26);
            this.btnListPriority.Name = "btnListPriority";
            this.btnListPriority.Size = new System.Drawing.Size(106, 23);
            this.btnListPriority.TabIndex = 20;
            this.btnListPriority.Text = "רשימת עדיפויות";
            this.btnListPriority.UseVisualStyleBackColor = true;
            this.btnListPriority.Click += new System.EventHandler(this.BtnListPriorityClick);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(770, 26);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(96, 23);
            this.btnAddUser.TabIndex = 19;
            this.btnAddUser.Text = "הוספת משתמש";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUserClick);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(668, 26);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteUser.TabIndex = 18;
            this.btnDeleteUser.Text = "מחיקת משתמש";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUserClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlSystemCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 527);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 41);
            this.panel2.TabIndex = 23;
            // 
            // companyName_Service_Call
            // 
            this.companyName_Service_Call.DataPropertyName = "companyName";
            this.companyName_Service_Call.HeaderText = "שם חברה";
            this.companyName_Service_Call.Name = "companyName_Service_Call";
            this.companyName_Service_Call.ReadOnly = true;
            this.companyName_Service_Call.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.companyName_Service_Call.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dateOpenCalls
            // 
            this.dateOpenCalls.DataPropertyName = "dateOpenCalls";
            this.dateOpenCalls.HeaderText = "תאריך פתיחת קריאה";
            this.dateOpenCalls.Name = "dateOpenCalls";
            this.dateOpenCalls.ReadOnly = true;
            // 
            // discriptions
            // 
            this.discriptions.DataPropertyName = "discriptions";
            this.discriptions.FillWeight = 300F;
            this.discriptions.HeaderText = "תאור";
            this.discriptions.Name = "discriptions";
            this.discriptions.ReadOnly = true;
            this.discriptions.Width = 150;
            // 
            // TypePriority
            // 
            this.TypePriority.DataPropertyName = "TypePriority";
            this.TypePriority.HeaderText = "עדיפות";
            this.TypePriority.Name = "TypePriority";
            this.TypePriority.ReadOnly = true;
            this.TypePriority.Width = 75;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "סטטוס";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // idCallsServices
            // 
            this.idCallsServices.DataPropertyName = "idCallsServices";
            this.idCallsServices.HeaderText = "idCallsServices";
            this.idCallsServices.Name = "idCallsServices";
            this.idCallsServices.ReadOnly = true;
            this.idCallsServices.Visible = false;
            // 
            // idCompany_Service_Call
            // 
            this.idCompany_Service_Call.DataPropertyName = "idCompany";
            this.idCompany_Service_Call.HeaderText = "idCompany";
            this.idCompany_Service_Call.Name = "idCompany_Service_Call";
            this.idCompany_Service_Call.ReadOnly = true;
            this.idCompany_Service_Call.Visible = false;
            // 
            // idPriority
            // 
            this.idPriority.DataPropertyName = "idPriority";
            this.idPriority.HeaderText = "idPriority";
            this.idPriority.Name = "idPriority";
            this.idPriority.ReadOnly = true;
            this.idPriority.Visible = false;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(917, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Manage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "מערכת ניהול לקוחות / ספקים";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Manage_MouseDoubleClick);
            this.tabControlSystemCustomers.ResumeLayout(false);
            this.tabPManagerCustomers.ResumeLayout(false);
            this.tabCListCustomers.ResumeLayout(false);
            this.tabListCustomers.ResumeLayout(false);
            this.splitContainerCustomer.Panel1.ResumeLayout(false);
            this.splitContainerCustomer.Panel1.PerformLayout();
            this.splitContainerCustomer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustomer)).EndInit();
            this.splitContainerCustomer.ResumeLayout(false);
            this.custmenuStrip.ResumeLayout(false);
            this.custmenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custdataGridView)).EndInit();
            this.tabPManageServices.ResumeLayout(false);
            this.tabPServices.ResumeLayout(false);
            this.tabListServices.ResumeLayout(false);
            this.splitContainerServices.Panel1.ResumeLayout(false);
            this.splitContainerServices.Panel1.PerformLayout();
            this.splitContainerServices.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerServices)).EndInit();
            this.splitContainerServices.ResumeLayout(false);
            this.servicemenuStrip.ResumeLayout(false);
            this.servicemenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridvListServices)).EndInit();
            this.tabPManageServiceToCustomer.ResumeLayout(false);
            this.tabCServicesToCustomers.ResumeLayout(false);
            this.tabListServicesCustomer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStripServices.ResumeLayout(false);
            this.menuStripServices.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberToRemindService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewingServiceToCust1)).EndInit();
            this.tabListServicePrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvPricePerService)).EndInit();
            this.tabCustomersPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGViewingPriceToCustomer)).EndInit();
            this.tabPManageServiceCalls1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceCallsdataGridView)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.serviceCallsmenuStrip.ResumeLayout(false);
            this.serviceCallsmenuStrip.PerformLayout();
            this.tabPManagerProject.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.projectmenuStrip.ResumeLayout(false);
            this.projectmenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridvListProject)).EndInit();
            this.tabManageProjectToCompany.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewingProjectToCompany)).EndInit();
            this.tabPManagerAdmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btchangeUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControlSystemCustomers;
        private System.Windows.Forms.TabPage tabPManagerCustomers;
        private System.Windows.Forms.TabPage tabPManageServices;
        private System.Windows.Forms.TabPage tabPManageServiceToCustomer;
        private System.Windows.Forms.TabPage tabPManageServiceCalls1;
        private System.Windows.Forms.TabPage tabPManagerAdmin;
        private System.Windows.Forms.Button btnAddPriority;
        private System.Windows.Forms.Button btnListPriority;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TabPage tabManageProjectToCompany;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip custmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridView custdataGridView;
        private System.Windows.Forms.SplitContainer splitContainerCustomer;
        private System.Windows.Forms.SplitContainer splitContainerServices;
        private System.Windows.Forms.DataGridView dgridvListServices;
        private System.Windows.Forms.MenuStrip servicemenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.TabControl tabCListCustomers;
        private System.Windows.Forms.TabPage tabListCustomers;
        private System.Windows.Forms.TabControl tabPServices;
        private System.Windows.Forms.TabPage tabListServices;
        private System.Windows.Forms.TabControl tabCServicesToCustomers;
        private System.Windows.Forms.TabPage tabListServicesCustomer;
        private System.Windows.Forms.TabPage tabListServicePrice;
        private System.Windows.Forms.TabPage tabCustomersPayment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumberToRemid;
        private System.Windows.Forms.NumericUpDown numberToRemindService;
        private System.Windows.Forms.MenuStrip menuStripServices;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RefreshServicesToCustToolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem EditServicesToCustToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteServicesToCustToolStrip;
        private System.Windows.Forms.ToolStripMenuItem AddServicesToCustToolStrip;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem ExportExcelServicesToCustToolStrip;
        private System.Windows.Forms.DataGridView dataViewingServiceToCust1;
        private System.Windows.Forms.DataGridView dataGViewingPriceToCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNamePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumPriceCustomers;
        private System.Windows.Forms.DataGridView dataGvPricePerService;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView ServiceCallsdataGridView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip serviceCallsmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileServiceCallMenu;
        private System.Windows.Forms.ToolStripMenuItem RefreshServiceCallMenu;
        private System.Windows.Forms.ToolStripMenuItem EditServiceCallCollectionMenu;
        private System.Windows.Forms.ToolStripMenuItem EditServiceCallMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteServiceCallMenu;
        private System.Windows.Forms.ToolStripMenuItem AddServiceCallMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportServiceCallMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportToExcelServiceCallMenu;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.RadioButton AllradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.MenuStrip projectmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem RefreshProjectMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem EditProjectMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteProjectMenu;
        private System.Windows.Forms.ToolStripMenuItem AddProjectMenu;
        private System.Windows.Forms.DataGridView dgridvListProject;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem RefreshMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripMenuItem EditProjectCompanyMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteProjectCompanyMenu;
        private System.Windows.Forms.ToolStripMenuItem AddProjectCompanyMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportExcelMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportExcelProjectProviderMenu;
        private System.Windows.Forms.DataGridView dataViewingProjectToCompany;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReportCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhone;
        private System.Windows.Forms.DataGridViewLinkColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompany_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectCompanies;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateProjectCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStartProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFinishProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomerProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewButtonColumn destination;
        private System.Windows.Forms.TabPage tabPManagerProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrciePerCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idService_Services;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicesCompanies;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameSTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName_Service_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustService;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompany_Services;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservice_Services_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidServiceCompany;
        private System.Windows.Forms.DataGridViewButtonColumn companyName_Service_Call;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpenCalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypePriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCallsServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompany_Service_Call;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPriority;
    }
}

