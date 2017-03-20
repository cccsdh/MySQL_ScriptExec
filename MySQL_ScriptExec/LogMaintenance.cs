using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

// namespaces...
namespace MySQL_ScriptExec
{
    // public classes...
    public partial class LogMaintenance : Form
    {
        // private fields...
        private string _ConnectionString = string.Empty;
        private bool _GridSetUp = false;

        // public constructors...
        public LogMaintenance()
        {
            InitializeComponent();
        }

        // private methods...
        private string BuildWhereClause()
        {
            var str = string.Empty;
            if (cbStatus.SelectedIndex == 0)
                str = " WHERE Status <> 'Success'";
            if (cbStatus.SelectedIndex == 1)
                str = " WHERE Status = 'Success'";
            var dataSource = (DataTable)cbRunNumber.DataSource;
            var item = dataSource.Rows[cbRunNumber.SelectedIndex];
            int num = 0;
            int.TryParse(item[0].ToString(), out num);
            if (num != 0)
                str = (!(str == string.Empty) ? string.Concat(str, " AND RunNumber = ", num.ToString()) : string.Concat(" WHERE RunNumber = ", num.ToString()));
            return str;
        }
        private void cmdDeleteSet_Click(object sender, EventArgs e)
        {
            if (_GridSetUp)
                if (((DataTable)dgvExecutionLog.DataSource).Rows.Count != 0)
                    if (MessageBox.Show("Do you want to delete selected records?", "MySQL_ScriptExec", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        try
                        {
                            try
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                var str = string.Concat("DELETE FROM ScriptExec_Log ", BuildWhereClause());
                                MySQL_ScriptExecCommon.ExecuteSQLStatement(_ConnectionString, str);
                                LoadData();
                            }
                            catch
                            {
                            }
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
        }
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    LoadData();
                }
                catch
                {
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            try
            {
                dgvExecutionLog.ClearSelection();
            }
            catch
            {
            }
        }
        private void frmLogMaintenance_Load(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip() { AutoPopDelay = 5000, InitialDelay = 1000, ReshowDelay = 500, ShowAlways = true };

            toolTip1.SetToolTip(btnGet, "Get Run information");
            toolTip1.SetToolTip(btnDelete, "Delete Run information");

            cbStatus.SelectedIndex = 0;
            LoadFilters();
        }

        private void grdExecutionLog_MouseUp(object sender, MouseEventArgs e)
        {
            var hitTestInfo = dgvExecutionLog.HitTest(e.X, e.Y);
            if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
            {
                dgvExecutionLog.CurrentCell = dgvExecutionLog[hitTestInfo.RowIndex, hitTestInfo.ColumnIndex];
                dgvExecutionLog.Rows[hitTestInfo.RowIndex].Selected = true;
            }
        }
        private void LoadData()
        {
            int count;
            var dataTable = new DataTable("ScriptExec_Log");
            try
            {
                var str = "SELECT RunNumber, FileName, SQLCommand, Status, FinishedDTTM FROM ScriptExec_Log  ";
                var str1 = BuildWhereClause();
                if (str1 != string.Empty)
                    str = string.Concat(str, str1);
                (new MySqlDataAdapter(str, _ConnectionString)).Fill(dataTable);
                dgvExecutionLog.DataSource = dataTable;
                try
                {
                    tbStatus.DataBindings.Clear();
                    rtbScript.DataBindings.Clear();
                    if (dataTable.Rows.Count != 0)
                    {
                        tbStatus.DataBindings.Add("Text", dataTable, "Status");
                        rtbScript.DataBindings.Add("Text", dataTable, "SQLCommand");
                    }
                    else
                    {
                        tbStatus.Text = string.Empty;
                        rtbScript.Text = string.Empty;
                    }
                    if (dataTable.Rows.Count == 1)
                    {
                        var label = this.lblRowCount;
                        count = dataTable.Rows.Count;
                        label.Text = string.Concat(count.ToString(), " row found");
                    }
                    else
                    {
                        var label1 = this.lblRowCount;
                        count = dataTable.Rows.Count;
                        label1.Text = string.Concat(count.ToString(), " rows found");
                    }
                    _GridSetUp = true;
                }
                catch
                {
                }
            }
            catch (MySqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void LoadFilters()
        {
            var dataTable = new DataTable();
            try
            {
                (new MySqlDataAdapter("SELECT Distinct RunNumber, CONCAT('RunNumber: ',RunNumber) AS RunNumberText FROM ScriptExec_Log  UNION SELECT 0, 'All'  ORDER BY RunNumber DESC", _ConnectionString)).Fill(dataTable);
                cbRunNumber.DataSource = dataTable;
                cbRunNumber.DisplayMember = "RunNumberText";
                cbRunNumber.ValueMember = "RunNumber";
                cbRunNumber.SelectedIndex = 0;
            }
            catch (MySqlException sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // public properties...
        public string ConnectionString
        {
            set
            {
                _ConnectionString = value;
            }
        }
    }
}
