using System;
using System.Windows.Forms;

// namespaces...
namespace MySQL_ScriptExec
{
    // public classes...
    public partial class Options : Form
    {
        // public constructors...
        public Options()
        {
            InitializeComponent();
        }

        // private methods...
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Tag = "Cancel";
            base.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbScriptLogging.SelectedIndex == 1)
                LoginType = "ALL";
            else
                if (cbScriptLogging.SelectedIndex != 0)
                LoginType = "NONE";
            else
                LoginType = "ERRORSONLY";
            if (tbEmail.Text.Length == 0)
                tbSMTP.Text = string.Empty;
            base.Tag = "OK";
            base.Close();
        }
        private void btnTestEmail_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != string.Empty)
            {
                var str = MySQL_ScriptExecCommon.SendMail(tbEmail.Text, tbSMTP.Text, "ScriptExec Email Test", "ScriptExec Email Test");
                if (!(str == string.Empty))
                    MessageBox.Show(str, "ScriptExec Email Test");
                else
                    MessageBox.Show("Email sent successfully...", "ScriptExec Email Test");
            }
        }
        private void Options_Load(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip() { AutoPopDelay = 5000, InitialDelay = 1000, ReshowDelay = 500, ShowAlways = true };

            toolTip1.SetToolTip(btnTestEmail, "Test Email Settings");
            toolTip1.SetToolTip(btnCancel, "Cancel Options");
            toolTip1.SetToolTip(btnOK, "Set Options");

            if (LoginType.ToUpper() == "ALL")
                cbScriptLogging.SelectedIndex = 1;
            else
                if ((LoginType.ToUpper() == "ERRORSONLY" ? false : !(LoginType.ToUpper() == "ERRORS_ONLY")))
                cbScriptLogging.SelectedIndex = 2;
            else
                cbScriptLogging.SelectedIndex = 0;
            if (tbEmail.Text.Length == 0)
            {
                btnTestEmail.Enabled = false;
                tbSMTP.Enabled = false;
            }
        }
        private void txtEmailAddress_Leave(object sender, EventArgs e)
        {
            tbEmail.Text = tbEmail.Text.Trim();
        }
        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length != 0)
            {
                btnTestEmail.Enabled = true;
                tbSMTP.Enabled = true;
            }
            else
            {
                btnTestEmail.Enabled = false;
                tbSMTP.Enabled = false;
            }
        }
        private void txtNetSend_Leave(object sender, EventArgs e)
        {
            tbNetSend.Text = tbNetSend.Text.Trim();
        }
        private void txtSMTPServer_Leave(object sender, EventArgs e)
        {
            tbSMTP.Text = tbSMTP.Text.Trim();
        }

        // public properties...
        public string DropLogTableOnExit
        {
            get
            {
                return (!cbDropLogTable.Checked ? "NO" : "YES");
            }
            set
            {
                if (!(value == "YES"))
                    cbDropLogTable.Checked = false;
                else
                    cbDropLogTable.Checked = true;
            }
        }
        public string EmailAddress
        {
            get
            {
                return tbEmail.Text;
            }
            set
            {
                tbEmail.Text = value;
            }
        }
        public string LoginType { get; set; }
        public string NetSendAddress
        {
            get
            {
                return tbNetSend.Text;
            }
            set
            {
                tbNetSend.Text = value;
            }
        }
        public string SMTPServer
        {
            get
            {
                return tbSMTP.Text;
            }
            set
            {
                tbSMTP.Text = value;
            }
        }
    }
}
