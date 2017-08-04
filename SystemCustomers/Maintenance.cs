﻿using System;
using System.Threading;
using System.Windows.Forms;
//using Services;


namespace SystemCustomers
{
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
               // new ManageBackupAndRestoreService(Manage.ConnectionString, "Backup");
                MessageBox.Show("Backup Success");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageUtils.LogUtils.WriteToLog(" Error Backup:  " + ex.Message + DateTime.Now);
                MessageUtils.LogUtils.SystemEventLogsError(" Error Backup: " + ex.Message + DateTime.Now);
                MessageBox.Show("The Backup Failed");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            // Only Process Key Down events for the Escape Key
            if (msg.Msg == WM_KEYDOWN)
            {
                if (keyData == Keys.Escape)
                {
                    this.Close();
                    // DialogResult = DialogResult.Cancel;
                    // Could call cancel click handler here
                    // Return true to indicate that Escape key was handled
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("?בטוח שאתה רוצה לשחזר", "שיחזור", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                 //   new ManageBackupAndRestoreService(Manage.ConnectionString, "Restore");
                    MessageUtils.LogUtils.WriteToLog(" Restore Success:  " + DateTime.Now);
                    MessageUtils.LogUtils.SystemEventLogsInformation(" Restore Success:  " + DateTime.Now);
                    MessageBox.Show("Restore Success");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageUtils.LogUtils.WriteToLog(" Error Restore:  " + ex.Message + DateTime.Now);
                MessageUtils.LogUtils.SystemEventLogsError(" Error Restore:  " + ex.Message + DateTime.Now);
                MessageBox.Show("The Restore Failed");
            }
        }
    }
}
