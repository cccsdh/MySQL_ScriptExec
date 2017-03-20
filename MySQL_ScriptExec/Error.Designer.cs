namespace MySQL_ScriptExec
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbErrorMessages = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtbScript = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNextFile = new System.Windows.Forms.Button();
            this.btnNextStatement = new System.Windows.Forms.Button();
            this.cbIgnore = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbErrorMessages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(515, 354);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbErrorMessages
            // 
            this.tbErrorMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbErrorMessages.Location = new System.Drawing.Point(0, 0);
            this.tbErrorMessages.Multiline = true;
            this.tbErrorMessages.Name = "tbErrorMessages";
            this.tbErrorMessages.Size = new System.Drawing.Size(515, 106);
            this.tbErrorMessages.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.rtbScript);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer2.Panel2.Controls.Add(this.btnNextFile);
            this.splitContainer2.Panel2.Controls.Add(this.btnNextStatement);
            this.splitContainer2.Panel2.Controls.Add(this.cbIgnore);
            this.splitContainer2.Size = new System.Drawing.Size(515, 244);
            this.splitContainer2.SplitterDistance = 152;
            this.splitContainer2.TabIndex = 0;
            // 
            // rtbScript
            // 
            this.rtbScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbScript.Location = new System.Drawing.Point(0, 0);
            this.rtbScript.Name = "rtbScript";
            this.rtbScript.Size = new System.Drawing.Size(515, 152);
            this.rtbScript.TabIndex = 0;
            this.rtbScript.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(362, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNextFile
            // 
            this.btnNextFile.Image = ((System.Drawing.Image)(resources.GetObject("btnNextFile.Image")));
            this.btnNextFile.Location = new System.Drawing.Point(299, 24);
            this.btnNextFile.Name = "btnNextFile";
            this.btnNextFile.Size = new System.Drawing.Size(44, 41);
            this.btnNextFile.TabIndex = 4;
            this.btnNextFile.UseVisualStyleBackColor = true;
            this.btnNextFile.Click += new System.EventHandler(this.btnNextFile_Click);
            // 
            // btnNextStatement
            // 
            this.btnNextStatement.Image = ((System.Drawing.Image)(resources.GetObject("btnNextStatement.Image")));
            this.btnNextStatement.Location = new System.Drawing.Point(235, 24);
            this.btnNextStatement.Name = "btnNextStatement";
            this.btnNextStatement.Size = new System.Drawing.Size(44, 41);
            this.btnNextStatement.TabIndex = 3;
            this.btnNextStatement.UseVisualStyleBackColor = true;
            this.btnNextStatement.Click += new System.EventHandler(this.btnNextStatement_Click);
            // 
            // cbIgnore
            // 
            this.cbIgnore.AutoSize = true;
            this.cbIgnore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIgnore.Location = new System.Drawing.Point(13, 15);
            this.cbIgnore.Name = "cbIgnore";
            this.cbIgnore.Size = new System.Drawing.Size(198, 17);
            this.cbIgnore.TabIndex = 0;
            this.cbIgnore.Text = "Ignore further errors in this file";
            this.cbIgnore.UseVisualStyleBackColor = true;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 354);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Error";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbErrorMessages;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox cbIgnore;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNextFile;
        private System.Windows.Forms.Button btnNextStatement;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox rtbScript;
    }
}