using System;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;

namespace SystemCustomers.DB
{
    public class DBBackup
    {
        public DBBackup()
        {
        }
     
        private string DATABASE_BACKUP_SQL;
        /// <summary>
        /// Backs up database.
        /// </summary>
        public bool BackUpDatabase()
        {
            try
            {
                //Data Source=LAPTOP-PC;Initial Catalog=master;User Id=sa;Password=12213443;
                using (SqlConnection sqlC = new SqlConnection(Manage.ConnectionString))
                {
                    // Data Source=LAPTOP-PC;Initial Catalog=SystemCompany;User Id=sa;Password=12213443; BACKUP DATABASE DBName TO DISK = 'Full path' WITH  INIT ,  NOUNLOAD ,  NAME = 'Backup file name',  NOSKIP ,  STATS = 10,  NOFORMAT
                     DATABASE_BACKUP_SQL = String.Format("BACKUP DATABASE SystemCompany TO DISK = '//SystemCompany.bak' WITH FORMAT");
                   // DATABASE_BACKUP_SQL = String.Format("BACKUP DATABASE SystemCompany TO DISK = '{0}' WITH  INIT ,  NOUNLOAD ,  NAME = 'Systemcustomers.bak',  NOSKIP ,  STATS = 10,  NOFORMAT", appPath);

                    sqlC.Open();
                    SqlCommand Command = new SqlCommand(DATABASE_BACKUP_SQL, sqlC);
                    Command.ExecuteNonQuery();
                    sqlC.Close();
                }
                return true;
            }
            catch (Exception ex )
            {
                MessageUtils.LogUtils.WriteToLog(ex.Message + DateTime.Now);
                MessageUtils.LogUtils.SystemEventLogsInformation(ex.Message + DateTime.Now);
                return false;
            }
        }

        /// <summary>
        /// Restores the database.
        /// </summary>
        public bool RestoreDatabase()
        {
            try
            {
                using (SqlConnection sqlC1 = new SqlConnection(Manage.ConnectionString))
                {
                    sqlC1.Open();

                    string UseMaster = "USE master";
                    SqlCommand UseMasterCommand = new SqlCommand(UseMaster, sqlC1);
                    UseMasterCommand.ExecuteNonQuery();

                    string Alter1 = @"ALTER DATABASE [SystemCompany] SET Single_User WITH Rollback Immediate";
                    SqlCommand Alter1Cmd = new SqlCommand(Alter1, sqlC1);
                    Alter1Cmd.ExecuteNonQuery();

                    string Restore = @"RESTORE DATABASE [SystemCompany] FROM DISK = N'//SystemCompany.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 10";
                    SqlCommand RestoreCmd = new SqlCommand(Restore, sqlC1);
                    RestoreCmd.ExecuteNonQuery();

                    string Alter2 = @"ALTER DATABASE [SystemCompany] SET Multi_User";
                    SqlCommand Alter2Cmd = new SqlCommand(Alter2, sqlC1);
                    Alter2Cmd.ExecuteNonQuery();
                    sqlC1.Close();
                }
             //SingletonManagerDb.InstantIsNull();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("שיחזור הנתונים לא הצליח");
                MessageUtils.LogUtils.WriteToLog(ex.Message + DateTime.Now);
                MessageUtils.LogUtils.SystemEventLogsInformation(ex.Message + DateTime.Now);
                return false;
            }
        }
    }
}
