using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

// namespaces...
namespace MySQL_ScriptExec
{
    // public classes...
    public partial class MySQL_ScripExecMain : Form
    {
        // private fields...
        private bool _blnCancel = false;
        private MySqlCommand _cmd = new MySqlCommand();
        private MySqlConnection _cn = new MySqlConnection();
        private string _CnString;
        private string _DropLogTableOnExit;
        private string _EmailAddress = string.Empty;
        private string _LastFileLocation = string.Empty;
        private string _LoginType = string.Empty;
        private string _NetSendAddress = string.Empty;
        private string _Password;
        private int _RunNumber = 0;
        private string _SMTPServer = string.Empty;
        private string _SQLDatabase;
        private string _SQLServer;
        private string _UserID;
        private bool bInitialLoad = true;
        private string strCrLf = Environment.NewLine;
        private ToolTip toolTip1;

        // public constructors...
        public MySQL_ScripExecMain()
        {
            InitializeComponent();
        }

        // private methods...
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _blnCancel = true;
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                if ((clbScriptList.SelectedIndex == -1 ? false : clbScriptList.SelectedIndex != clbScriptList.Items.Count - 1))
                {
                    var selectedIndex = clbScriptList.SelectedIndex;
                    var num = clbScriptList.SelectedIndex + 1;
                    var str = clbScriptList.Items[selectedIndex].ToString();
                    var str1 = clbScriptList.Items[num].ToString();
                    var itemChecked = clbScriptList.GetItemChecked(selectedIndex);
                    var flag = clbScriptList.GetItemChecked(num);
                    clbScriptList.Items[selectedIndex] = str1;
                    clbScriptList.SetItemChecked(selectedIndex, flag);
                    clbScriptList.Items[num] = str;
                    clbScriptList.SetItemChecked(num, itemChecked);
                    clbScriptList.SelectedIndex = num;
                }
                else
                    return;
            }
            catch
            {
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (clbScriptList.CheckedItems.Count != 0)
            {
                EnterRunMode();
                try
                {
                    try
                    {
                        if (_cn.State != ConnectionState.Closed)
                            _cn.Close();
                        _cn.ConnectionString = _CnString;
                        _cn.Open();
                        _cmd.Connection = _cn;
                        _cmd.CommandTimeout = 360000000;
                        SetUpLogTable();
                        for (var i = 0; i <= clbScriptList.Items.Count - 1; i++)
                            if (clbScriptList.GetItemChecked(i))
                            {
                                clbScriptList.SelectedIndex = i;
                                lbInfoMessages.Items.Add(string.Concat(" ***  Executing ", clbScriptList.Items[i].ToString(), "  ***"));
                                tsStatusLabel.Text = string.Concat("Executing ", clbScriptList.Items[i].ToString(), "...");
                                Application.DoEvents();
                                ExecuteSQLFile(clbScriptList.Items[i].ToString());
                                if ((tsStatusLabel.Text == "Script Error" ? false : !_blnCancel))
                                    clbScriptList.SetItemChecked(i, false);
                                else
                                {
                                    ExitRunMode();
                                    _cn.Close();
                                    return;
                                }
                            }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                finally
                {
                    ExitRunMode();
                    _cn.Close();
                }
            }
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if ((clbScriptList.SelectedIndex == -1 ? false : clbScriptList.SelectedIndex != 0))
                {
                    var selectedIndex = clbScriptList.SelectedIndex;
                    var num = clbScriptList.SelectedIndex - 1;
                    var str = clbScriptList.Items[selectedIndex].ToString();
                    var str1 = clbScriptList.Items[num].ToString();
                    var itemChecked = clbScriptList.GetItemChecked(selectedIndex);
                    var flag = clbScriptList.GetItemChecked(num);
                    clbScriptList.Items[selectedIndex] = str1;
                    clbScriptList.SetItemChecked(selectedIndex, flag);
                    clbScriptList.Items[num] = str;
                    clbScriptList.SetItemChecked(num, itemChecked);
                    clbScriptList.SelectedIndex = num;
                }
                else
                    return;
            }
            catch
            {
            }
        }
        private void cbScriptSelect_CheckedChanged(object sender, EventArgs e)
        {
            for (var i = 0; i <= clbScriptList.Items.Count - 1; i++)
                clbScriptList.SetItemChecked(i, cbScriptSelect.Checked);
            if (!cbScriptSelect.Checked)
                cbScriptSelect.Text = "Select All";
            else
                cbScriptSelect.Text = "Deselect All";
        }
        private void clbScriptList_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(clbScriptList, string.Empty);
        }
        private void clbScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toolTip1.SetToolTip(clbScriptList, clbScriptList.SelectedItem.ToString());
            }
            catch
            {
                toolTip1.SetToolTip(clbScriptList, string.Empty);
            }
        }
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm(_SQLServer, _SQLDatabase, _UserID, _Password);
        }
        private void EnterRunMode()
        {
            btnRun.Enabled = false;
            btnCancel.Enabled = true;
            btnDown.Enabled = false;
            btnUp.Enabled = false;
            cbScriptSelect.Enabled = false;
            tbScriptDirectory.Enabled = false;
            fileToolStripMenuItem.Enabled = false;
            toolsToolStripMenuItem.Enabled = false;
            databaseToolStripMenuItem.Enabled = false;
            _blnCancel = false;
            lbInfoMessages.Items.Clear();
        }
        private void ExecuteSQLFile(string strFileName)
        {
            var stringBuilder = new StringBuilder();
            var str = string.Empty;
            var flag = false;
            try
            {
                var streamReader = File.OpenText(string.Concat(tbScriptDirectory.Text, strFileName));
                while (true)
                {
                    if ((streamReader.Peek() < 0 ? true : _blnCancel))
                        break;
                    var str1 = streamReader.ReadLine();
                    if (!(MySQL_ScriptExecCommon.IsGoStatement(str1) ? false : streamReader.Peek() >= 0))
                    {
                        if (streamReader.Peek() < 0)
                            if (!MySQL_ScriptExecCommon.IsGoStatement(str1))
                                if (str1.Trim() != string.Empty)
                                    stringBuilder.Append(string.Concat(str1, strCrLf));
                        var str2 = stringBuilder.ToString();
                        if (str2 != string.Empty)
                        {
                            rtbScriptView.Text = str2;
                            Application.DoEvents();
                            var str3 = ExecuteSQLStatement(str2);
                            if (_LoginType.ToUpper() == "ALL")
                                LogSQLStatement(strFileName, str2, str3, _SQLDatabase);
                            else
                                if ((_LoginType.ToUpper() == "ERRORSONLY" ? true : _LoginType.ToUpper() == "ERRORS_ONLY"))
                                if (str3 != "Success")
                                    LogSQLStatement(strFileName, str2, str3, _SQLDatabase);
                            if (str3 != "Success")
                                if (str != strFileName)
                                {
                                    if (_NetSendAddress != string.Empty)
                                        NetSend(str3);
                                    if (_EmailAddress != string.Empty)
                                        MySQL_ScriptExecCommon.SendMail(_EmailAddress, _SMTPServer, "MySQL_ScriptExec: SQL Script Error", str3);
                                    var _frmError = new Error()
                                    {
                                        SQLScript = str2,
                                        ErrorText = str3
                                    };
                                    _frmError.ShowDialog();
                                    if (_frmError.NextAction == "STOP")
                                    {
                                        tsStatusLabel.Text = "Script Error";
                                        streamReader.Close();
                                        return;
                                    }
                                    if (_frmError.NextAction == "NEXT_STATEMENT")
                                    {
                                        if (_frmError.IgnoreErrors)
                                            str = strFileName;
                                    }
                                    else
                                        if (_frmError.NextAction == "NEXT_FILE")
                                    {
                                        streamReader.Close();
                                        return;
                                    }
                                    _frmError = null;
                                }
                        }
                        stringBuilder = new StringBuilder();
                        flag = false;
                    }
                    else
                        if (str1.Trim() != string.Empty)
                    {
                        stringBuilder.Append(string.Concat(str1, strCrLf));
                        flag = true;
                    }
                    else
                            if (flag)
                        stringBuilder.Append(string.Concat(str1, strCrLf));
                }
                streamReader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private string ExecuteSQLStatement(string strSQL)
        {
            string message;
            try
            {
                strSQL = strSQL.Trim();
                if (strSQL != string.Empty)
                {
                    _cmd.CommandText = strSQL;
                    _cmd.ExecuteNonQuery();
                }
                message = "Success";
            }
            catch (MySqlException sqlException)
            {
                message = sqlException.Message;
            }
            return message;
        }
        private void ExitRunMode()
        {
            btnRun.Enabled = true;
            btnCancel.Enabled = false;
            btnDown.Enabled = true;
            btnUp.Enabled = true;
            cbScriptSelect.Enabled = true;
            tbScriptDirectory.Enabled = true;
            fileToolStripMenuItem.Enabled = true;
            databaseToolStripMenuItem.Enabled = true;
            toolsToolStripMenuItem.Enabled = true;
            clbScriptList.SelectedIndex = -1;
            rtbScriptView.Text = string.Empty;
            tsStatusLabel.Text = string.Empty;
            if (clbScriptList.CheckedItems.Count == 0)
                cbScriptSelect.Checked = false;
            _blnCancel = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        private void exportFileListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clbScriptList.Items.Count != 0 && clbScriptList.CheckedItems.Count != 0)
            {
                diagExportFile.ShowDialog();
                if (!string.IsNullOrWhiteSpace(diagExportFile.FileName))
                {
                    var streamWriter = new StreamWriter(diagExportFile.FileName);
                    try
                    {
                        for (var i = 0; i <= clbScriptList.Items.Count - 1; i++)
                            if (clbScriptList.GetItemChecked(i))
                                streamWriter.WriteLine(clbScriptList.Items[i].ToString());
                    }
                    finally
                    {
                        if (streamWriter != null)
                            ((IDisposable)streamWriter).Dispose();
                    }
                }
            }
            else
                MessageBox.Show("There are no files in the list or no files are selected for exporting");
        }
        private void InfoMessageHandler(object sender, MySqlInfoMessageEventArgs e)
        {
            foreach (MySqlError error in e.errors)
                lbInfoMessages.Items.Add(error.Message);
        }
        private void LoadConfigFile()
        {
            var dataSet = new DataSet("MySQL_ScriptExecConfiguration");
            var str = string.Concat(Application.StartupPath, "\\MySQL_ScriptExec.xml");
            try
            {
                dataSet.ReadXml(str);
            }
            catch
            {
                var dataTable = new DataTable("Database");
                dataTable.Columns.Add("Server", Type.GetType("System.String"));
                dataTable.Columns.Add("Database", Type.GetType("System.String"));
                dataTable.Columns.Add("UserName", Type.GetType("System.String"));
                var startupPath = dataTable.NewRow();
                startupPath["Server"] = "(local)";
                startupPath["Database"] = "world";
                startupPath["UserName"] = string.Empty;
                dataTable.Rows.Add(startupPath);
                dataSet.Tables.Add(dataTable);
                var dataTable1 = new DataTable("Options");
                dataTable1.Columns.Add("NetSendAddress", Type.GetType("System.String"));
                dataTable1.Columns.Add("EmailAddress", Type.GetType("System.String"));
                dataTable1.Columns.Add("EmailServer", Type.GetType("System.String"));
                dataTable1.Columns.Add("LoggingType", Type.GetType("System.String"));
                dataTable1.Columns.Add("DropLogTableOnExit", Type.GetType("System.String"));
                dataTable1.Columns.Add("LastFileLocation", Type.GetType("System.String"));
                startupPath = dataTable1.NewRow();
                startupPath["NetSendAddress"] = string.Empty;
                startupPath["EmailAddress"] = string.Empty;
                startupPath["EmailServer"] = string.Empty;
                startupPath["LoggingType"] = "ERRORSONLY";
                startupPath["DropLogTableOnExit"] = "NO";
                startupPath["LastFileLocation"] = Application.StartupPath;
                dataTable1.Rows.Add(startupPath);
                dataSet.Tables.Add(dataTable1);
                dataSet.WriteXml(str, XmlWriteMode.WriteSchema);
            }
            _SQLServer = dataSet.Tables["Database"].Rows[0]["Server"].ToString();
            _SQLDatabase = dataSet.Tables["Database"].Rows[0]["Database"].ToString();
            _UserID = dataSet.Tables["Database"].Rows[0]["UserName"].ToString();
            _LastFileLocation = dataSet.Tables["Options"].Rows[0]["LastFileLocation"].ToString();
            if (_LastFileLocation == string.Empty)
                _LastFileLocation = Application.StartupPath;
            _LoginType = dataSet.Tables["Options"].Rows[0]["LoggingType"].ToString();
            if (_LoginType == string.Empty)
                _LoginType = "ERRORSONLY";
            if (!(dataSet.Tables["Options"].Rows[0]["DropLogTableOnExit"].ToString().ToUpper() == "YES"))
                _DropLogTableOnExit = "NO";
            else
                _DropLogTableOnExit = "YES";
            _NetSendAddress = dataSet.Tables["Options"].Rows[0]["NetSendAddress"].ToString();
            _EmailAddress = dataSet.Tables["Options"].Rows[0]["EmailAddress"].ToString();
            _SMTPServer = dataSet.Tables["Options"].Rows[0]["EmailServer"].ToString();
        }
        private void LoadEmbeddedTextFileScripts(string embeddedTextFile)
        {
            var fileName = embeddedTextFile.Substring(2, embeddedTextFile.Length - 2);
            using (var streamReader = File.OpenText(string.Concat(tbScriptDirectory.Text, fileName)))
            {
                while (streamReader.Peek() >= 0)
                {
                    var str = streamReader.ReadLine();
                    if (str.Trim() != string.Empty)
                        if (str.StartsWith(">>"))
                            LoadEmbeddedTextFileScripts(str);
                        else
                            clbScriptList.Items.Add(str);
                }
                streamReader.Close();
            }
        }
        private void LogSQLStatement(string strFileName, string strSQLCommand, string strStatus, string strDatabase)
        {
            try
            {
                var objArray = new object[] { "Insert Into ", strDatabase, ".ScriptExec_Log (RunNumber, FileName, SQLCommand, Status, FinishedDTTM) Values (", _RunNumber, ", '", strFileName, "', '", strSQLCommand.Replace("'", "''"), "', '", strStatus.Replace("'", "''"), "', Now())" };
                ExecuteSQLStatement(string.Concat(objArray));
            }
            catch
            {
            }
        }
        private void manageExecutionLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnection = new MySqlConnection(_CnString);
                sqlConnection.Open();
                var result = (new MySqlCommand("select count(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='ScriptExec_Log'", sqlConnection)).ExecuteScalar();
                var num = 0;
                if (result != DBNull.Value)
                    num = 1; sqlConnection.Close();
                if (num != 1)
                    MessageBox.Show("There is no execution log in the current database.", "MySQL_ScriptExec");
                else
                    using (var _frmLogMaintenance = new LogMaintenance() { ConnectionString = _CnString })
                        _frmLogMaintenance.ShowDialog();
            }
            catch (MySqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
        }
        private void NetSend(string strMessage)
        {
            try
            {
                Process.Start("net", string.Concat("send ", _NetSendAddress, " ", strMessage));
            }
            catch
            {
            }
        }
        private void openFileListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            try
            {
                openFileDialog.InitialDirectory = _LastFileLocation;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFileDialog.FileName;
                    fileName = fileName.Substring(0, fileName.LastIndexOf("\\") + 1);
                    tbScriptDirectory.Text = fileName;
                    _LastFileLocation = fileName;

                    using (var streamReader = File.OpenText(openFileDialog.FileName))
                    {
                        clbScriptList.Items.Clear();
                        cbScriptSelect.Checked = false;
                        while (streamReader.Peek() >= 0)
                        {
                            var str = streamReader.ReadLine();
                            if (str.Trim() != string.Empty)
                                if (str.StartsWith(">>"))
                                    LoadEmbeddedTextFileScripts(str);
                                else
                                    clbScriptList.Items.Add(str);
                        }
                        streamReader.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void OpenLoginForm(string SQLServer, string SQLDB, string LoginName, string Password)
        {
            try
            {
                var _frmLogin = new Login()
                {
                    Server = SQLServer,
                    Database = SQLDB,
                    LoginName = LoginName,
                    Password = Password
                };
                _frmLogin.ShowDialog(this);
                if (_frmLogin.Tag.ToString() == "OK")
                {
                    SetConnectionString(_frmLogin.Server, _frmLogin.Database, _frmLogin.LoginName, _frmLogin.Password);
                    tsStatusLabel.Text = string.Concat("Current database: ", _frmLogin.Database, " on ", _frmLogin.Server);
                    bInitialLoad = false;
                }
                else
                    if (bInitialLoad)
                    Application.Exit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dataSet = new DataSet("MySQL_ScriptExecConfiguration");
            var str = string.Concat(Application.StartupPath, "\\ScriptExec.xml");
            dataSet.ReadXml(str);
            var frmOption = new Options()
            {
                LoginType = dataSet.Tables["Options"].Rows[0]["LoggingType"].ToString(),
                NetSendAddress = dataSet.Tables["Options"].Rows[0]["NetSendAddress"].ToString(),
                EmailAddress = dataSet.Tables["Options"].Rows[0]["EmailAddress"].ToString(),
                SMTPServer = dataSet.Tables["Options"].Rows[0]["EmailServer"].ToString(),
                DropLogTableOnExit = dataSet.Tables["Options"].Rows[0]["DropLogTableOnExit"].ToString()
            };
            frmOption.ShowDialog();
            if ((string)frmOption.Tag == "OK")
            {
                dataSet.Tables["Options"].Rows[0]["LoggingType"] = frmOption.LoginType;
                dataSet.Tables["Options"].Rows[0]["NetSendAddress"] = frmOption.NetSendAddress;
                dataSet.Tables["Options"].Rows[0]["EmailAddress"] = frmOption.EmailAddress;
                dataSet.Tables["Options"].Rows[0]["EmailServer"] = frmOption.SMTPServer;
                dataSet.Tables["Options"].Rows[0]["DropLogTableOnExit"] = frmOption.DropLogTableOnExit;
                dataSet.WriteXml(str, XmlWriteMode.WriteSchema);
                _LoginType = frmOption.LoginType;
                _NetSendAddress = frmOption.NetSendAddress;
                _EmailAddress = frmOption.EmailAddress;
                _SMTPServer = frmOption.SMTPServer;
                _DropLogTableOnExit = frmOption.DropLogTableOnExit;
            }
        }
        private void ScriptExecMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var dataSet = new DataSet())
            {
                var str = string.Concat(Application.StartupPath, "\\MySQL_ScriptExec.xml");
                try
                {
                    dataSet.ReadXml(str);
                    dataSet.Tables[0].Rows[0][0] = _SQLServer;
                    dataSet.Tables[0].Rows[0][1] = _SQLDatabase;
                    dataSet.Tables[0].Rows[0][2] = _UserID;
                    dataSet.Tables["Options"].Rows[0][5] = _LastFileLocation;
                    dataSet.WriteXml(str, XmlWriteMode.WriteSchema);
                }
                catch
                {
                }
            }
            try
            {
                if (_DropLogTableOnExit == "YES")
                    MySQL_ScriptExecCommon.ExecuteSQLStatement(_CnString, "DROP TABLE `ScriptExec_Log`");
            }
            catch
            {
            }
        }
        private void ScriptExecMain_Load(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip() { AutoPopDelay = 5000, InitialDelay = 1000, ReshowDelay = 500, ShowAlways = true };

            toolTip1.SetToolTip(btnRun, "Run Selected Scripts");
            toolTip1.SetToolTip(btnCancel, "Cancel Run of Scripts");
            toolTip1.SetToolTip(btnUp, "Move Script up in list");
            toolTip1.SetToolTip(btnDown, "Move Script down in list");

            LoadConfigFile();
            OpenLoginForm(_SQLServer, _SQLDatabase, _UserID, _Password);
            _cn.InfoMessage += InfoMessageHandler;
        }
        private void selectSQLFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            try
            {
                openFileDialog.InitialDirectory = _LastFileLocation;
                openFileDialog.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    clbScriptList.Items.Clear();
                    cbScriptSelect.Checked = false;
                    var fileName = openFileDialog.FileName;
                    fileName = fileName.Substring(0, fileName.LastIndexOf("\\") + 1);
                    tbScriptDirectory.Text = fileName;
                    _LastFileLocation = fileName;
                    var fileNames = openFileDialog.FileNames;
                    for (var i = 0; i < fileNames.Length; i++)
                    {
                        var str = fileNames[i];
                        clbScriptList.Items.Add(str.Substring(fileName.Length, str.Length - fileName.Length));
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void SetConnectionString(string SQLServer, string SQLDatabase, string UserID, string Password)
        {
            string[] sQLServer;
            _SQLServer = SQLServer;
            _SQLDatabase = SQLDatabase;
            _UserID = UserID;
            _Password = Password;
            if (!(UserID != string.Empty))
            {
                sQLServer = new string[] { "Data Source=", SQLServer, ";Initial Catalog=", SQLDatabase, ";Integrated Security=SSPI;" };
                _CnString = string.Concat(sQLServer);
            }
            else
            {
                sQLServer = new string[] { "Data Source=", SQLServer, ";Initial Catalog=", SQLDatabase, ";User ID=", UserID, ";Password=", Password, ";" };
                _CnString = string.Concat(sQLServer);
            }
        }
        private void SetUpLogTable()
        {
            ExecuteSQLStatement("CREATE TABLE if not exists `ScriptExec_Log` (`ID` int NOT NULL AUTO_INCREMENT,`RunNumber` SMALLINT NOT NULL, `FileName` varchar(255) NOT NULL, `SQLCommand` text NOT NULL,  `Status` VarChar(1000) NOT NULL, `FinishedDTTM` datetime NOT NULL,  PRIMARY KEY (`ID`))");

            var sqlDataReader = (new MySqlCommand("select MAX(`RunNumber`)  As RunNumber from `ScriptExec_Log`", _cn)).ExecuteReader();
            sqlDataReader.Read();
            if (sqlDataReader[0] != DBNull.Value)
                _RunNumber = (int)sqlDataReader["RunNumber"] + 1;
            else
                _RunNumber = 1;
            sqlDataReader.Close();
            if (_RunNumber == 1)
                ExecuteSQLStatement("ALTER TABLE ScriptExec_Log AUTO_INCREMENT = 0");
        }
    }
}
