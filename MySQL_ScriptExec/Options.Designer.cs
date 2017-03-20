namespace MySQL_ScriptExec
{
    partial class Options
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestEmail = new System.Windows.Forms.Button();
            this.tbSMTP = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNetSend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbScriptLogging = new System.Windows.Forms.ComboBox();
            this.cbDropLogTable = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTestEmail);
            this.groupBox1.Controls.Add(this.tbSMTP);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbNetSend);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Notification";
            // 
            // btnTestEmail
            // 
            this.btnTestEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnTestEmail.Image")));
            this.btnTestEmail.Location = new System.Drawing.Point(379, 127);
            this.btnTestEmail.Name = "btnTestEmail";
            this.btnTestEmail.Size = new System.Drawing.Size(44, 41);
            this.btnTestEmail.TabIndex = 6;
            this.btnTestEmail.UseVisualStyleBackColor = true;
            this.btnTestEmail.Click += new System.EventHandler(this.btnTestEmail_Click);
            // 
            // tbSMTP
            // 
            this.tbSMTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSMTP.Location = new System.Drawing.Point(113, 148);
            this.tbSMTP.Name = "tbSMTP";
            this.tbSMTP.Size = new System.Drawing.Size(245, 20);
            this.tbSMTP.TabIndex = 5;
            this.tbSMTP.MouseLeave += new System.EventHandler(this.txtSMTPServer_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(113, 86);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(310, 20);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            this.tbEmail.MouseLeave += new System.EventHandler(this.txtEmailAddress_Leave);
            // 
            // tbNetSend
            // 
            this.tbNetSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNetSend.Location = new System.Drawing.Point(113, 24);
            this.tbNetSend.Name = "tbNetSend";
            this.tbNetSend.Size = new System.Drawing.Size(310, 20);
            this.tbNetSend.TabIndex = 3;
            this.tbNetSend.MouseLeave += new System.EventHandler(this.txtNetSend_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SMTP Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Net Send Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Script Logging";
            // 
            // cbScriptLogging
            // 
            this.cbScriptLogging.FormattingEnabled = true;
            this.cbScriptLogging.Items.AddRange(new object[] {
            "Errors Only",
            "All statements",
            "None"});
            this.cbScriptLogging.Location = new System.Drawing.Point(113, 199);
            this.cbScriptLogging.Name = "cbScriptLogging";
            this.cbScriptLogging.Size = new System.Drawing.Size(310, 21);
            this.cbScriptLogging.TabIndex = 4;
            // 
            // cbDropLogTable
            // 
            this.cbDropLogTable.AutoSize = true;
            this.cbDropLogTable.Location = new System.Drawing.Point(22, 258);
            this.cbDropLogTable.Name = "cbDropLogTable";
            this.cbDropLogTable.Size = new System.Drawing.Size(135, 17);
            this.cbDropLogTable.TabIndex = 5;
            this.cbDropLogTable.Text = "Drop Log Table on Exit";
            this.cbDropLogTable.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(379, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(297, 283);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(44, 41);
            this.btnOK.TabIndex = 7;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 336);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbDropLogTable);
            this.Controls.Add(this.cbScriptLogging);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSMTP;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNetSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTestEmail;
        private System.Windows.Forms.ComboBox cbScriptLogging;
        private System.Windows.Forms.CheckBox cbDropLogTable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}