namespace MySQL_ScriptExec
{
    partial class MySQL_ScripExecMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySQL_ScripExecMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSQLFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExecutionLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.clbScriptList = new System.Windows.Forms.CheckedListBox();
            this.cbScriptSelect = new System.Windows.Forms.CheckBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbScriptDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInfoMessages = new System.Windows.Forms.ListBox();
            this.diagExportFile = new System.Windows.Forms.SaveFileDialog();
            this.rtbScriptView = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileListToolStripMenuItem,
            this.selectSQLFilesToolStripMenuItem,
            this.exportFileListToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileListToolStripMenuItem
            // 
            this.openFileListToolStripMenuItem.Name = "openFileListToolStripMenuItem";
            this.openFileListToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openFileListToolStripMenuItem.Text = "Open File List";
            this.openFileListToolStripMenuItem.Click += new System.EventHandler(this.openFileListToolStripMenuItem_Click);
            // 
            // selectSQLFilesToolStripMenuItem
            // 
            this.selectSQLFilesToolStripMenuItem.Name = "selectSQLFilesToolStripMenuItem";
            this.selectSQLFilesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.selectSQLFilesToolStripMenuItem.Text = "Select SQL Files";
            this.selectSQLFilesToolStripMenuItem.Click += new System.EventHandler(this.selectSQLFilesToolStripMenuItem_Click);
            // 
            // exportFileListToolStripMenuItem
            // 
            this.exportFileListToolStripMenuItem.Name = "exportFileListToolStripMenuItem";
            this.exportFileListToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportFileListToolStripMenuItem.Text = "Export File List";
            this.exportFileListToolStripMenuItem.Click += new System.EventHandler(this.exportFileListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageExecutionLogsToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // manageExecutionLogsToolStripMenuItem
            // 
            this.manageExecutionLogsToolStripMenuItem.Name = "manageExecutionLogsToolStripMenuItem";
            this.manageExecutionLogsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.manageExecutionLogsToolStripMenuItem.Text = "Manage Execution Logs";
            this.manageExecutionLogsToolStripMenuItem.Click += new System.EventHandler(this.manageExecutionLogsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(58, 17);
            this.tsStatusLabel.Text = "Database:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbInfoMessages);
            this.splitContainer1.Size = new System.Drawing.Size(769, 390);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer2.Panel2.Controls.Add(this.btnRun);
            this.splitContainer2.Panel2.Controls.Add(this.tbScriptDirectory);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(769, 257);
            this.splitContainer2.SplitterDistance = 197;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.clbScriptList);
            this.splitContainer3.Panel1.Controls.Add(this.cbScriptSelect);
            this.splitContainer3.Panel1.Controls.Add(this.btnDown);
            this.splitContainer3.Panel1.Controls.Add(this.btnUp);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.rtbScriptView);
            this.splitContainer3.Size = new System.Drawing.Size(769, 197);
            this.splitContainer3.SplitterDistance = 333;
            this.splitContainer3.TabIndex = 0;
            // 
            // clbScriptList
            // 
            this.clbScriptList.FormattingEnabled = true;
            this.clbScriptList.Location = new System.Drawing.Point(4, 4);
            this.clbScriptList.Name = "clbScriptList";
            this.clbScriptList.Size = new System.Drawing.Size(326, 139);
            this.clbScriptList.TabIndex = 6;
            this.clbScriptList.SelectedIndexChanged += new System.EventHandler(this.clbScriptList_SelectedIndexChanged);
            this.clbScriptList.Leave += new System.EventHandler(this.clbScriptList_MouseLeave);
            // 
            // cbScriptSelect
            // 
            this.cbScriptSelect.AutoSize = true;
            this.cbScriptSelect.Location = new System.Drawing.Point(13, 161);
            this.cbScriptSelect.Name = "cbScriptSelect";
            this.cbScriptSelect.Size = new System.Drawing.Size(70, 17);
            this.cbScriptSelect.TabIndex = 5;
            this.cbScriptSelect.Text = "Select All";
            this.cbScriptSelect.UseVisualStyleBackColor = true;
            this.cbScriptSelect.CheckedChanged += new System.EventHandler(this.cbScriptSelect_CheckedChanged);
            // 
            // btnDown
            // 
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(277, 148);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(44, 41);
            this.btnDown.TabIndex = 4;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(227, 148);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(44, 41);
            this.btnUp.TabIndex = 3;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(696, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.Location = new System.Drawing.Point(620, 8);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(44, 41);
            this.btnRun.TabIndex = 2;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbScriptDirectory
            // 
            this.tbScriptDirectory.Enabled = false;
            this.tbScriptDirectory.Location = new System.Drawing.Point(101, 18);
            this.tbScriptDirectory.Name = "tbScriptDirectory";
            this.tbScriptDirectory.Size = new System.Drawing.Size(495, 20);
            this.tbScriptDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Script Directory:";
            // 
            // lbInfoMessages
            // 
            this.lbInfoMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInfoMessages.FormattingEnabled = true;
            this.lbInfoMessages.Location = new System.Drawing.Point(0, 0);
            this.lbInfoMessages.Name = "lbInfoMessages";
            this.lbInfoMessages.Size = new System.Drawing.Size(769, 129);
            this.lbInfoMessages.TabIndex = 0;
            // 
            // rtbScriptView
            // 
            this.rtbScriptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbScriptView.Location = new System.Drawing.Point(0, 0);
            this.rtbScriptView.Name = "rtbScriptView";
            this.rtbScriptView.Size = new System.Drawing.Size(432, 197);
            this.rtbScriptView.TabIndex = 0;
            this.rtbScriptView.Text = "";
            // 
            // MySQL_ScripExecMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 436);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MySQL_ScripExecMain";
            this.Text = "MySQL_ScriptExec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScriptExecMain_FormClosing);
            this.Load += new System.EventHandler(this.ScriptExecMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSQLFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageExecutionLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.CheckBox cbScriptSelect;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbScriptDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbScriptList;

        private System.Windows.Forms.ListBox lbInfoMessages;
        private System.Windows.Forms.SaveFileDialog diagExportFile;
        private System.Windows.Forms.RichTextBox rtbScriptView;
    }
}

