namespace SystemCustomers.ManageProjectToCustomers
{
    partial class AddProjectCustomers
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.epManageProjectToCompany = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtbPriceType = new System.Windows.Forms.TextBox();
            this.combListProject = new System.Windows.Forms.ComboBox();
            this.combListCompany = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipManageProjectToCompany = new System.Windows.Forms.ToolTip(this.components);
            this.radiobPaid = new System.Windows.Forms.RadioButton();
            this.radiobNotPaid = new System.Windows.Forms.RadioButton();
            this.panelDiscriptions = new System.Windows.Forms.Panel();
            this.txtDiscriptions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenPathFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateStartProject = new System.Windows.Forms.DateTimePicker();
            this.dateFinishProject = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.epManageProjectToCompany)).BeginInit();
            this.panelDiscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Enabled = false;
            this.btnupdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnupdate.Location = new System.Drawing.Point(158, 385);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "עדכן";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(253, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(158, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // epManageProjectToCompany
            // 
            this.epManageProjectToCompany.BlinkRate = 300;
            this.epManageProjectToCompany.ContainerControl = this;
            // 
            // txtbPriceType
            // 
            this.txtbPriceType.Location = new System.Drawing.Point(128, 82);
            this.txtbPriceType.MaxLength = 20;
            this.txtbPriceType.Name = "txtbPriceType";
            this.txtbPriceType.Size = new System.Drawing.Size(121, 20);
            this.txtbPriceType.TabIndex = 5;
            this.txtbPriceType.TextChanged += new System.EventHandler(this.txtbPriceType_TextChanged);
            this.txtbPriceType.MouseHover += new System.EventHandler(this.txtbPriceType_MouseHover);
            // 
            // combListProject
            // 
            this.combListProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combListProject.FormattingEnabled = true;
            this.combListProject.Location = new System.Drawing.Point(128, 55);
            this.combListProject.Name = "combListProject";
            this.combListProject.Size = new System.Drawing.Size(121, 21);
            this.combListProject.TabIndex = 2;
            this.combListProject.SelectedIndexChanged += new System.EventHandler(this.combListProject_SelectedIndexChanged);
            // 
            // combListCompany
            // 
            this.combListCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combListCompany.FormattingEnabled = true;
            this.combListCompany.Location = new System.Drawing.Point(128, 28);
            this.combListCompany.Name = "combListCompany";
            this.combListCompany.Size = new System.Drawing.Size(121, 21);
            this.combListCompany.TabIndex = 1;
            this.combListCompany.SelectedIndexChanged += new System.EventHandler(this.combListCompany_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "פריסת תשלום";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "רשימת פרויקטים";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "רשימת ספקים";
            // 
            // toolTipManageProjectToCompany
            // 
            this.toolTipManageProjectToCompany.AutomaticDelay = 100;
            // 
            // radiobPaid
            // 
            this.radiobPaid.AutoSize = true;
            this.radiobPaid.Checked = true;
            this.radiobPaid.Location = new System.Drawing.Point(93, 176);
            this.radiobPaid.Name = "radiobPaid";
            this.radiobPaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radiobPaid.Size = new System.Drawing.Size(71, 17);
            this.radiobPaid.TabIndex = 22;
            this.radiobPaid.TabStop = true;
            this.radiobPaid.Text = "לא שולם";
            this.radiobPaid.UseVisualStyleBackColor = true;
            // 
            // radiobNotPaid
            // 
            this.radiobNotPaid.AutoSize = true;
            this.radiobNotPaid.Location = new System.Drawing.Point(196, 176);
            this.radiobNotPaid.Name = "radiobNotPaid";
            this.radiobNotPaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radiobNotPaid.Size = new System.Drawing.Size(53, 17);
            this.radiobNotPaid.TabIndex = 23;
            this.radiobNotPaid.Text = "שולם";
            this.radiobNotPaid.UseVisualStyleBackColor = true;
            // 
            // panelDiscriptions
            // 
            this.panelDiscriptions.Controls.Add(this.txtDiscriptions);
            this.panelDiscriptions.Location = new System.Drawing.Point(52, 221);
            this.panelDiscriptions.Name = "panelDiscriptions";
            this.panelDiscriptions.Size = new System.Drawing.Size(253, 109);
            this.panelDiscriptions.TabIndex = 24;
            // 
            // txtDiscriptions
            // 
            this.txtDiscriptions.AllowDrop = true;
            this.txtDiscriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscriptions.Location = new System.Drawing.Point(0, 0);
            this.txtDiscriptions.MaxLength = 500;
            this.txtDiscriptions.Multiline = true;
            this.txtDiscriptions.Name = "txtDiscriptions";
            this.txtDiscriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiscriptions.Size = new System.Drawing.Size(253, 109);
            this.txtDiscriptions.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "הערות:";
            // 
            // buttonOpenPathFile
            // 
            this.buttonOpenPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOpenPathFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOpenPathFile.Location = new System.Drawing.Point(181, 346);
            this.buttonOpenPathFile.Name = "buttonOpenPathFile";
            this.buttonOpenPathFile.Size = new System.Drawing.Size(35, 23);
            this.buttonOpenPathFile.TabIndex = 26;
            this.buttonOpenPathFile.Text = ".....";
            this.buttonOpenPathFile.UseVisualStyleBackColor = true;
            this.buttonOpenPathFile.Click += new System.EventHandler(this.buttonOpenPathFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(1, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "בחירת קובץ פרטי ספק פרויקט";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenFile.Location = new System.Drawing.Point(232, 346);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(47, 23);
            this.btnOpenFile.TabIndex = 28;
            this.btnOpenFile.Tag = "";
            this.btnOpenFile.Text = "פתח";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Visible = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            this.btnOpenFile.MouseHover += new System.EventHandler(this.btnOpenFile_MouseHover);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(2, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "תאריך סיום פרויקט";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(2, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "תאריך התחלת פרויקט";
            // 
            // dateStartProject
            // 
            this.dateStartProject.Location = new System.Drawing.Point(128, 110);
            this.dateStartProject.Name = "dateStartProject";
            this.dateStartProject.Size = new System.Drawing.Size(200, 20);
            this.dateStartProject.TabIndex = 31;
            // 
            // dateFinishProject
            // 
            this.dateFinishProject.Location = new System.Drawing.Point(128, 141);
            this.dateFinishProject.Name = "dateFinishProject";
            this.dateFinishProject.Size = new System.Drawing.Size(200, 20);
            this.dateFinishProject.TabIndex = 32;
            // 
            // AddProjectCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(340, 419);
            this.ControlBox = false;
            this.Controls.Add(this.dateFinishProject);
            this.Controls.Add(this.dateStartProject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOpenPathFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelDiscriptions);
            this.Controls.Add(this.radiobNotPaid);
            this.Controls.Add(this.radiobPaid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbPriceType);
            this.Controls.Add(this.combListProject);
            this.Controls.Add(this.combListCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(356, 457);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(356, 457);
            this.Name = "AddProjectCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת ספק לפרויקט";
            ((System.ComponentModel.ISupportInitialize)(this.epManageProjectToCompany)).EndInit();
            this.panelDiscriptions.ResumeLayout(false);
            this.panelDiscriptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider epManageProjectToCompany;
        private System.Windows.Forms.TextBox txtbPriceType;
        private System.Windows.Forms.ComboBox combListProject;
        private System.Windows.Forms.ComboBox combListCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipManageProjectToCompany;
        private System.Windows.Forms.RadioButton radiobNotPaid;
        private System.Windows.Forms.RadioButton radiobPaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDiscriptions;
        private System.Windows.Forms.TextBox txtDiscriptions;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpenPathFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFinishProject;
        private System.Windows.Forms.DateTimePicker dateStartProject;
    }
}