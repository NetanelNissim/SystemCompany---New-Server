namespace SystemCustomers.ManageProject
{
    partial class AddProject
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtbProjectName = new System.Windows.Forms.TextBox();
            this.errorProject = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.txtProjectDiscriptions = new System.Windows.Forms.TextBox();
            this.panelProjectDiscriptions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProject)).BeginInit();
            this.panelProjectDiscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(188, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(188, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.ForeColor = System.Drawing.Color.Red;
            this.lblProjectName.Location = new System.Drawing.Point(7, 24);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(63, 13);
            this.lblProjectName.TabIndex = 10;
            this.lblProjectName.Text = "שם פרויקט";
            // 
            // txtbProjectName
            // 
            this.txtbProjectName.Location = new System.Drawing.Point(80, 21);
            this.txtbProjectName.MaxLength = 100;
            this.txtbProjectName.Name = "txtbProjectName";
            this.txtbProjectName.Size = new System.Drawing.Size(265, 20);
            this.txtbProjectName.TabIndex = 1;
            this.txtbProjectName.TextChanged += new System.EventHandler(this.txtbProjectName_TextChanged);
            // 
            // errorProject
            // 
            this.errorProject.BlinkRate = 300;
            this.errorProject.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(278, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtProjectDiscriptions
            // 
            this.txtProjectDiscriptions.AcceptsReturn = true;
            this.txtProjectDiscriptions.AcceptsTab = true;
            this.txtProjectDiscriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProjectDiscriptions.Location = new System.Drawing.Point(0, 0);
            this.txtProjectDiscriptions.MaxLength = 100;
            this.txtProjectDiscriptions.Multiline = true;
            this.txtProjectDiscriptions.Name = "txtProjectDiscriptions";
            this.txtProjectDiscriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProjectDiscriptions.Size = new System.Drawing.Size(265, 100);
            this.txtProjectDiscriptions.TabIndex = 2;
            this.txtProjectDiscriptions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProjectDiscriptions_KeyDown);
            // 
            // panelProjectDiscriptions
            // 
            this.panelProjectDiscriptions.Controls.Add(this.txtProjectDiscriptions);
            this.panelProjectDiscriptions.Location = new System.Drawing.Point(80, 72);
            this.panelProjectDiscriptions.Name = "panelProjectDiscriptions";
            this.panelProjectDiscriptions.Size = new System.Drawing.Size(265, 100);
            this.panelProjectDiscriptions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "תאור הפרויקט";
            // 
            // AddProject
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(367, 234);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProjectDiscriptions);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.txtbProjectName);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 272);
            this.Name = "AddProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת פרויקט";
            ((System.ComponentModel.ISupportInitialize)(this.errorProject)).EndInit();
            this.panelProjectDiscriptions.ResumeLayout(false);
            this.panelProjectDiscriptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtbProjectName;
        private System.Windows.Forms.ErrorProvider errorProject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelProjectDiscriptions;
        private System.Windows.Forms.TextBox txtProjectDiscriptions;
        private System.Windows.Forms.Label label1;
    }
}