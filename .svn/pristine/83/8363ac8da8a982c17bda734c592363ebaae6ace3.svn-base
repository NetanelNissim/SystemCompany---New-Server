using System;
using System.Windows.Forms;

namespace SystemCustomers
{
    public partial class Login : Form
    {
        public enum ResultLogin
        {
            Ok,
            Cancel
        };

        public Login()
        {
            InitializeComponent();
        }

        private ResultLogin dialogResult;
        /// <summary>
        /// return the Dialog Result
        /// </summary> 
        public ResultLogin LoginDialogResult
        {
            get { return this.dialogResult; }
        }

        private string userName = string.Empty;
        /// <summary>
        /// retrun the user name;
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
        }

        private string passWord = string.Empty;
        /// <summary>
        /// return the user password
        /// </summary>
        public string PassWord
        {
            get { return this.passWord; }
        }

        private void EnableConnect()
        {
            MyRegEx.Validate(txtBoxUserName.Text, MyRegEx.OnlyCharsPattern);
            buttonConnect.Enabled = txtBoxUserName.Text.Trim() != string.Empty && txtBoxPassWord.Text.Trim() != string.Empty;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            this.userName = this.txtBoxUserName.Text;
            this.passWord = this.txtBoxPassWord.Text;
            this.dialogResult = ResultLogin.Ok;
            this.Close();
        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {
            EnableConnect();
        }

        private void txtBoxPassWord_TextChanged(object sender, EventArgs e)
        {
            EnableConnect();
        }

        private void buttonCancelLogin_Click(object sender, EventArgs e)
        {
            this.dialogResult = ResultLogin.Cancel;
            this.Close();
        }
    }
}
