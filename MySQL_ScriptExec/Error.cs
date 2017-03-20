using System;
using System.Windows.Forms;

// namespaces...
namespace MySQL_ScriptExec
{
    // public classes...
    public partial class Error : Form
    {
        // public constructors...
        public Error()
        {
            InitializeComponent();
        }

        // private methods...
        private void btnNextFile_Click(object sender, EventArgs e)
        {
            NextAction = "NEXT_FILE";
            Close();
        }
        private void btnNextStatement_Click(object sender, EventArgs e)
        {
            NextAction = "NEXT_STATEMENT";
            Close();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            NextAction = "STOP";
            Close();
        }
        private void Error_Load(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip() { AutoPopDelay = 5000, InitialDelay = 1000, ReshowDelay = 500, ShowAlways = true };

            toolTip1.SetToolTip(btnNextFile, "Run Next script file");
            toolTip1.SetToolTip(btnCancel, "Cancel Run of Scripts");
            toolTip1.SetToolTip(btnNextStatement, "Run Next statement");
        }

        // public properties...
        public string ErrorText
        {
            set
            {
                tbErrorMessages.Text = value;
            }
        }
        public bool IgnoreErrors
        {
            get
            {
                return cbIgnore.Checked;
            }
        }
        public string NextAction { get; private set; }
        public string SQLScript
        {
            set
            {
                rtbScript.Text = value;
            }
        }
    }
}
