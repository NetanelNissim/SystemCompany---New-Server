namespace SystemCustomers
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxValidPassword = new System.Windows.Forms.TextBox();
            this.radioButtonSec = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxPrivateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "אימות סיסמא";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxValidPassword
            // 
            this.textBoxValidPassword.Location = new System.Drawing.Point(111, 102);
            this.textBoxValidPassword.MaxLength = 40;
            this.textBoxValidPassword.Name = "textBoxValidPassword";
            this.textBoxValidPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxValidPassword.TabIndex = 21;
            this.textBoxValidPassword.UseSystemPasswordChar = true;
            this.textBoxValidPassword.TextChanged += new System.EventHandler(this.textBoxValidPassword_TextChanged);
            // 
            // radioButtonSec
            // 
            this.radioButtonSec.AutoSize = true;
            this.radioButtonSec.Checked = true;
            this.radioButtonSec.Location = new System.Drawing.Point(93, 149);
            this.radioButtonSec.Name = "radioButtonSec";
            this.radioButtonSec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonSec.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSec.TabIndex = 28;
            this.radioButtonSec.TabStop = true;
            this.radioButtonSec.Text = "עובד";
            this.radioButtonSec.UseVisualStyleBackColor = true;
            this.radioButtonSec.CheckedChanged += new System.EventHandler(this.radioButtonSec_CheckedChanged);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(15, 149);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonAdmin.Size = new System.Drawing.Size(51, 17);
            this.radioButtonAdmin.TabIndex = 27;
            this.radioButtonAdmin.Text = "מנהל";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Enabled = false;
            this.buttonAddUser.Location = new System.Drawing.Point(69, 193);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 22;
            this.buttonAddUser.Text = "הוסף";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(173, 193);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "יציאה";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "סיסמא";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "שם משתמש";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(111, 76);
            this.txtBoxPassword.MaxLength = 40;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassword.TabIndex = 20;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(111, 50);
            this.txtBoxUserName.MaxLength = 40;
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUserName.TabIndex = 19;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            // 
            // txtBoxPrivateName
            // 
            this.txtBoxPrivateName.Location = new System.Drawing.Point(111, 24);
            this.txtBoxPrivateName.MaxLength = 40;
            this.txtBoxPrivateName.Name = "txtBoxPrivateName";
            this.txtBoxPrivateName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrivateName.TabIndex = 16;
            this.txtBoxPrivateName.TextChanged += new System.EventHandler(this.txtBoxPrivateName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "שם פרטי/משפחה";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(262, 228);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxValidPassword);
            this.Controls.Add(this.radioButtonSec);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.txtBoxPrivateName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(278, 266);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(278, 266);
            this.Name = "AddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת משתמש";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxValidPassword;
        private System.Windows.Forms.RadioButton radioButtonSec;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxPrivateName;
        private System.Windows.Forms.Label label1;
    }
}