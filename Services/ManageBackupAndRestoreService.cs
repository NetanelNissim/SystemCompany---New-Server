using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Services
{
    public class ManageBackupAndRestoreService
    {
        public ManageBackupAndRestoreService(string stringConnection, string choice)
        {
            this.ConnectionString = stringConnection;
            this.Choice = choice;
            Exception exception = null;
            Thread thread = new Thread(() => SafeExecute(() => SwichCaseBackupOrRestore(), out exception));
            thread.Start();
            thread.Join();
            Console.WriteLine(exception);
            Console.ReadLine();
            if (exception != null)
                throw new Exception(exception.Message);
        }

        private void SafeExecute(Action SwichCaseBackupOrRestore, out Exception exception)
        {
            exception = null;
            try
            {
                SwichCaseBackupOrRestore();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
        }

        private void SwichCaseBackupOrRestore()
        {
            switch (this.Choice)
            {
                case "Backup":
                    BackUpDatabase();
                    break;
                case "Restore":
                    RestoreDatabase();
                    break;
            }
        }

        private string DATABASE_BACKUP_SQL;
        private string ConnectionString { get; set; }
        private string Choice { get; set;}

        /// <summary>
        /// Backs up database.
        /// </summary>
        /// 
       // Exception exc = new Exception("Test");

        public void BackUpDatabase()
        {
            try
            {
                //Data Source=LAPTOP-PC;Initial Catalog=master;User Id=sa;Password=12213443;
                using (SqlConnection sqlC = new SqlConnection(this.ConnectionString))
                {
                    // Data Source=LAPTOP-PC;Initial Catalog=SystemCompany;User Id=sa;Password=12213443; BACKUP DATABASE DBName TO DISK = 'Full path' WITH  INIT ,  NOUNLOAD ,  NAME = 'Backup file name',  NOSKIP ,  STATS = 10,  NOFORMAT
                    DATABASE_BACKUP_SQL = String.Format("BACKUP DATABASE SystemCompany TO DISK = '//SystemCompany.bak' WITH FORMAT");
                    // DATABASE_BACKUP_SQL = String.Format("BACKUP DATABASE SystemCompany TO DISK = '{0}' WITH  INIT ,  NOUNLOAD ,  NAME = 'Systemcustomers.bak',  NOSKIP ,  STATS = 10,  NOFORMAT", appPath);

                    sqlC.Open();
                    SqlCommand Command = new SqlCommand(DATABASE_BACKUP_SQL, sqlC);
                    Command.ExecuteNonQuery();
                    sqlC.Close();
                }
            }
            catch (Exception ex) 
            {
              throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Restores the database.
        /// </summary>
        public void RestoreDatabase()
        {
            try
            {
                using (SqlConnection sqlC1 = new SqlConnection(this.ConnectionString))
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
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
