using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace SystemCustomers
{

    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
            InitializeListUser();
        }

        private string userID = string.Empty;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private void InitializeListUser()
        {
            string userName = string.Empty;
            string idUser = string.Empty;
            using (var userService = new ServiceManager.ServiceSystemCompaniesClient())
            {
                try
                {
                    var user = new ServiceManager.Users();
                    user.Method = "fillDropDown";
                    user = userService.ManageUsers(user);

                    foreach (var listUsers in user.list)
                    {
                        idUser = listUsers.Item2.ToString();
                        userName = listUsers.Item1;
                        if (userName != "admin")
                        {
                            IDToName users = new IDToName(userName, idUser);
                            comboxListUsers.Items.Add(users);
                        }
                    }
                }
                catch (FaultException ex)
                {
                    MessageUtils.LogUtils.WriteToLog(string.Format(" Error Get All User. Exception: {0} ",ex.Message));
                    MessageUtils.LogUtils.SystemEventLogsError(string.Format(" Error Get All User. Exception: {0} ", ex.Message));
                }
                if (comboxListUsers.Items.Count > 0) comboxListUsers.SelectedIndex = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
           string title = "מחיקת משתמש";
            string message = "?בטוח שאתה רוצה למחוק";
            if (new MessageUtils.MessageBoxText(message,title).YesorNoMessageBox() != DialogResult.Yes) return;
            using (var userService = new ServiceManager.ServiceSystemCompaniesClient())
            {
                try
                {
                    var user = new ServiceManager.Users();
                    user.UserId = Convert.ToInt16(UserID);
                    user.Method = "CheckUserId";
                    user = userService.ManageUsers(user);
                    if (!user.isBool)
                    {
                        user.Method = "Delete";
                        userService.ManageUsers(user);
                        MessageUtils.LogUtils.WriteToLog(" Delete User ");
                        MessageUtils.LogUtils.SystemEventLogsInformation(" Delete User");
                    }
                    else
                    {
                        MessageUtils.LogUtils.WriteToLog(" User doesn't exist ");
                        MessageUtils.LogUtils.SystemEventLogsWarning(" User doesn't exist");
                    }

                }
                catch (FaultException ex)
                {
                    MessageUtils.LogUtils.WriteToLog(string.Format(" Error Delete User. Exception: {0}.", ex.Message));
                    MessageUtils.LogUtils.SystemEventLogsError(string.Format(" Error Delete User. Exception: {0}.", ex.Message));
                }
            }
            this.Close();
        }

        private void comboxListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDToName users = (IDToName)this.comboxListUsers.SelectedItem;
            if (users == null) return;
            string userID = users.ID;
            this.UserID = userID;
        }
    }
}
