using System;
using System.IO;
using System.Windows.Forms;
using SystemCustomers.MessageUtils;

namespace SystemCustomers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!CheckConnection()) return;
           //if (!ReadFile()) return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Manage());
        }

        private static bool ReadFile()
        {
            const string FILE_NAME = "MyFile.txt";
            if (!File.Exists(FILE_NAME))
            {
                MessageUtils.LogUtils.WriteToLog("{0} does not exist." + FILE_NAME);
                MessageUtils.LogUtils.SystemEventLogsInformation("{0} does not exist." + FILE_NAME);
                ErrorMessageBox(ReadFileError);
                return false;
            }
            Manage.ConnectionString = File.ReadAllText(FILE_NAME);
            MessageUtils.LogUtils.WriteToLog(Manage.ConnectionString);
            return true;
        }

        private static bool CheckConnection()
        {
            try
            {
                using (var userService = new ServiceManager.ServiceSystemCompaniesClient())
                {
                    userService.Open();
                    var user = new ServiceManager.Users();
                    user.Method = "CheckConnection";
                    user = userService.ManageUsers(user);
                    if (user.isBool) return true;
                   MessageUtils.LogUtils.SystemEventLogsInformation(ERRORMESSAGE);
                   MessageUtils.LogUtils.WriteToLog(ERRORMESSAGE);
                   ErrorMessageBox(ERRORMESSAGE);
                   return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        private const string ERRORMESSAGE = "Data Base Connection Error";
        private const string ReadFileError = "The File does not exist!!!!";

        private static void ErrorMessageBox(string errormessage)
        {
            new MessageBoxText(errormessage, "Error!!!").ErrorMessageBox();
        }
    }
}
