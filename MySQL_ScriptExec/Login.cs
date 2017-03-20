using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

// namespaces...
namespace MySQL_ScriptExec
{
    // public classes...
    public partial class Login : Form
    {
        // public constructors...
        public Login()
        {
            InitializeComponent();
        }

        // private methods...
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                if ((!string.IsNullOrWhiteSpace(tbLoginName.Text)) && (!string.IsNullOrWhiteSpace(tbPassword.Text)))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    TestConnection();
                    Cursor.Current = Cursors.Default;
                    Tag = "OK";
                    Close();
                }
            }
            catch (Exception exception1)
            {
                var exception = exception1;
                Cursor.Current = Cursors.Default;
                MessageBox.Show(exception.Message);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Tag = string.Empty;
        }
        private void TestConnection()
        {
            string str;
            string[] text;
            if (tbServer.Text.Trim() == ".")
                tbServer.Text = "(local)";

            text = new string[] { "Data Source=", tbServer.Text, ";Initial Catalog=", tbDatabase.Text, ";User ID=", tbLoginName.Text, ";Password=", tbPassword.Text, ";" };
            str = string.Concat(text);

            using (var sqlConnection = new MySqlConnection(str))
            {
                sqlConnection.Open();
                sqlConnection.Close();
            }
        }
        private void txtDatabase_Leave(object sender, EventArgs e)
        {
            tbDatabase.Text = tbDatabase.Text.Trim();
        }
        private void txtLoginName_Leave(object sender, EventArgs e)
        {
            tbLoginName.Text = tbLoginName.Text.Trim();
        }
        private void txtServer_Leave(object sender, EventArgs e)
        {
            tbServer.Text = tbServer.Text.Trim();
        }

        // public properties...
        public string Database
        {
            get
            {
                return tbDatabase.Text;
            }
            set
            {
                tbDatabase.Text = value;
            }
        }
        public string LoginName
        {
            get
            {
                return tbLoginName.Text;
            }
            set
            {
                tbLoginName.Text = value;

            }
        }
        public string Password
        {
            get
            {
                return tbPassword.Text;
            }
            set
            {
                tbPassword.Text = value;
            }
        }
        public string Server
        {
            get
            {
                return tbServer.Text;
            }
            set
            {
                tbServer.Text = value;
            }
        }
    }
}
