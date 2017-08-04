namespace SystemCustomers
{
    partial class AddPriority
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbTypePriority = new System.Windows.Forms.TextBox();
            this.btnAddPriority = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorpPriority = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorpPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "עדיפות:";
            // 
            // txtbTypePriority
            // 
            this.txtbTypePriority.Location = new System.Drawing.Point(66, 18);
            this.txtbTypePriority.MaxLength = 8;
            this.txtbTypePriority.Name = "txtbTypePriority";
            this.txtbTypePriority.Size = new System.Drawing.Size(111, 20);
            this.txtbTypePriority.TabIndex = 1;
            this.txtbTypePriority.TextChanged += new System.EventHandler(this.txtbTypePriority_TextChanged);
            // 
            // btnAddPriority
            // 
            this.btnAddPriority.Location = new System.Drawing.Point(102, 56);
            this.btnAddPriority.Name = "btnAddPriority";
            this.btnAddPriority.Size = new System.Drawing.Size(75, 23);
            this.btnAddPriority.TabIndex = 2;
            this.btnAddPriority.Text = "הוסף";
            this.btnAddPriority.UseVisualStyleBackColor = true;
            this.btnAddPriority.Click += new System.EventHandler(this.btnAddPriority_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(224, 56);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorpPriority
            // 
            this.errorpPriority.ContainerControl = this;
            // 
            // AddPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(311, 91);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddPriority);
            this.Controls.Add(this.txtbTypePriority);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(327, 129);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(327, 129);
            this.Name = "AddPriority";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הוספת עדיפות";
            ((System.ComponentModel.ISupportInitialize)(this.errorpPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbTypePriority;
        private System.Windows.Forms.Button btnAddPriority;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorpPriority;
    }
}