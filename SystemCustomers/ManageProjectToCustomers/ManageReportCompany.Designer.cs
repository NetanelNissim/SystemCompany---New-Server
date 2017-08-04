namespace SystemCustomers.ManageProjectToCustomers
{
    partial class ManageReportCompany
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
            this.btnShowReport = new System.Windows.Forms.Button();
            this.datagListCompany = new System.Windows.Forms.DataGridView();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagListCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(12, 13);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(75, 23);
            this.btnShowReport.TabIndex = 0;
            this.btnShowReport.Text = "הצג דוח";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // datagListCompany
            // 
            this.datagListCompany.AllowUserToAddRows = false;
            this.datagListCompany.AllowUserToDeleteRows = false;
            this.datagListCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagListCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName,
            this.idcust});
            this.datagListCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagListCompany.Location = new System.Drawing.Point(0, 42);
            this.datagListCompany.Name = "datagListCompany";
            this.datagListCompany.ReadOnly = true;
            this.datagListCompany.Size = new System.Drawing.Size(258, 220);
            this.datagListCompany.TabIndex = 1;
            // 
            // companyName
            // 
            this.companyName.DataPropertyName = "companyName";
            this.companyName.HeaderText = "שם חברה";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // idcust
            // 
            this.idcust.DataPropertyName = "idcust";
            this.idcust.HeaderText = "מספר חברה";
            this.idcust.Name = "idcust";
            this.idcust.ReadOnly = true;
            this.idcust.Visible = false;
            // 
            // ManageReportCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(258, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.datagListCompany);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(274, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(274, 300);
            this.Name = "ManageReportCompany";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "דוחות ספקים";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManageReportCompany_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.datagListCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.DataGridView datagListCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcust;
    }
}