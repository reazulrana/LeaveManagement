namespace Payroll
{
    partial class frmRestoreDatabase
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
            this.tblRestore = new System.Windows.Forms.TabControl();
            this.tbNewDatabaseRestore = new System.Windows.Forms.TabPage();
            this.pnlNewDatabaseRestore = new System.Windows.Forms.Panel();
            this.txtNewDatabaseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRestoreName = new System.Windows.Forms.CheckBox();
            this.txtRestoreDatabaseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExistingDatabaseRestore = new System.Windows.Forms.TabPage();
            this.pnlExistingDatabaseRestore = new System.Windows.Forms.Panel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.tblRestore.SuspendLayout();
            this.tbNewDatabaseRestore.SuspendLayout();
            this.pnlNewDatabaseRestore.SuspendLayout();
            this.tbExistingDatabaseRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblRestore
            // 
            this.tblRestore.Controls.Add(this.tbNewDatabaseRestore);
            this.tblRestore.Controls.Add(this.tbExistingDatabaseRestore);
            this.tblRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRestore.Location = new System.Drawing.Point(0, 0);
            this.tblRestore.Name = "tblRestore";
            this.tblRestore.SelectedIndex = 0;
            this.tblRestore.Size = new System.Drawing.Size(512, 278);
            this.tblRestore.TabIndex = 0;
            // 
            // tbNewDatabaseRestore
            // 
            this.tbNewDatabaseRestore.Controls.Add(this.pnlNewDatabaseRestore);
            this.tbNewDatabaseRestore.Location = new System.Drawing.Point(4, 22);
            this.tbNewDatabaseRestore.Name = "tbNewDatabaseRestore";
            this.tbNewDatabaseRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tbNewDatabaseRestore.Size = new System.Drawing.Size(504, 252);
            this.tbNewDatabaseRestore.TabIndex = 0;
            this.tbNewDatabaseRestore.Text = "New Database Restore";
            this.tbNewDatabaseRestore.UseVisualStyleBackColor = true;
            // 
            // pnlNewDatabaseRestore
            // 
            this.pnlNewDatabaseRestore.BackColor = System.Drawing.Color.OldLace;
            this.pnlNewDatabaseRestore.Controls.Add(this.txtNewDatabaseName);
            this.pnlNewDatabaseRestore.Controls.Add(this.label4);
            this.pnlNewDatabaseRestore.Controls.Add(this.btnClose);
            this.pnlNewDatabaseRestore.Controls.Add(this.btnRestore);
            this.pnlNewDatabaseRestore.Controls.Add(this.btnOpenFolder);
            this.pnlNewDatabaseRestore.Controls.Add(this.txtTargetPath);
            this.pnlNewDatabaseRestore.Controls.Add(this.label3);
            this.pnlNewDatabaseRestore.Controls.Add(this.chkRestoreName);
            this.pnlNewDatabaseRestore.Controls.Add(this.txtRestoreDatabaseName);
            this.pnlNewDatabaseRestore.Controls.Add(this.label2);
            this.pnlNewDatabaseRestore.Controls.Add(this.btnOpenFile);
            this.pnlNewDatabaseRestore.Controls.Add(this.txtRestorePath);
            this.pnlNewDatabaseRestore.Controls.Add(this.label1);
            this.pnlNewDatabaseRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNewDatabaseRestore.Location = new System.Drawing.Point(3, 3);
            this.pnlNewDatabaseRestore.Name = "pnlNewDatabaseRestore";
            this.pnlNewDatabaseRestore.Size = new System.Drawing.Size(498, 246);
            this.pnlNewDatabaseRestore.TabIndex = 0;
            // 
            // txtNewDatabaseName
            // 
            this.txtNewDatabaseName.Enabled = false;
            this.txtNewDatabaseName.Location = new System.Drawing.Point(151, 93);
            this.txtNewDatabaseName.Name = "txtNewDatabaseName";
            this.txtNewDatabaseName.Size = new System.Drawing.Size(278, 20);
            this.txtNewDatabaseName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "New Database Name";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Payroll.Properties.Resources.Delete_32px;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(294, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 37);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.White;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Image = global::Payroll.Properties.Resources.Database_32px;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(151, 186);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(135, 37);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.White;
            this.btnOpenFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Location = new System.Drawing.Point(430, 119);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(28, 23);
            this.btnOpenFolder.TabIndex = 8;
            this.btnOpenFolder.Text = "...";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Enabled = false;
            this.txtTargetPath.Location = new System.Drawing.Point(151, 121);
            this.txtTargetPath.Multiline = true;
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(278, 59);
            this.txtTargetPath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target Path";
            // 
            // chkRestoreName
            // 
            this.chkRestoreName.AutoSize = true;
            this.chkRestoreName.Location = new System.Drawing.Point(430, 96);
            this.chkRestoreName.Name = "chkRestoreName";
            this.chkRestoreName.Size = new System.Drawing.Size(15, 14);
            this.chkRestoreName.TabIndex = 5;
            this.chkRestoreName.UseVisualStyleBackColor = true;
            this.chkRestoreName.CheckedChanged += new System.EventHandler(this.chkRestoreName_CheckedChanged);
            // 
            // txtRestoreDatabaseName
            // 
            this.txtRestoreDatabaseName.Enabled = false;
            this.txtRestoreDatabaseName.Location = new System.Drawing.Point(151, 68);
            this.txtRestoreDatabaseName.Name = "txtRestoreDatabaseName";
            this.txtRestoreDatabaseName.Size = new System.Drawing.Size(278, 20);
            this.txtRestoreDatabaseName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restore Database  Name";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.White;
            this.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(430, 21);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(28, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Enabled = false;
            this.txtRestorePath.Location = new System.Drawing.Point(151, 21);
            this.txtRestorePath.Multiline = true;
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.Size = new System.Drawing.Size(278, 41);
            this.txtRestorePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restore Path";
            // 
            // tbExistingDatabaseRestore
            // 
            this.tbExistingDatabaseRestore.Controls.Add(this.pnlExistingDatabaseRestore);
            this.tbExistingDatabaseRestore.Location = new System.Drawing.Point(4, 22);
            this.tbExistingDatabaseRestore.Name = "tbExistingDatabaseRestore";
            this.tbExistingDatabaseRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tbExistingDatabaseRestore.Size = new System.Drawing.Size(504, 252);
            this.tbExistingDatabaseRestore.TabIndex = 1;
            this.tbExistingDatabaseRestore.Text = "Existing Database Restore";
            this.tbExistingDatabaseRestore.UseVisualStyleBackColor = true;
            // 
            // pnlExistingDatabaseRestore
            // 
            this.pnlExistingDatabaseRestore.BackColor = System.Drawing.Color.OldLace;
            this.pnlExistingDatabaseRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExistingDatabaseRestore.Location = new System.Drawing.Point(3, 3);
            this.pnlExistingDatabaseRestore.Name = "pnlExistingDatabaseRestore";
            this.pnlExistingDatabaseRestore.Size = new System.Drawing.Size(498, 246);
            this.pnlExistingDatabaseRestore.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.Filter = "Text files (*.bak)|*.bak\"";
            // 
            // frmRestoreDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(512, 278);
            this.Controls.Add(this.tblRestore);
            this.Name = "frmRestoreDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Database";
            this.Load += new System.EventHandler(this.frmRestoreDatabase_Load);
            this.tblRestore.ResumeLayout(false);
            this.tbNewDatabaseRestore.ResumeLayout(false);
            this.pnlNewDatabaseRestore.ResumeLayout(false);
            this.pnlNewDatabaseRestore.PerformLayout();
            this.tbExistingDatabaseRestore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tblRestore;
        private System.Windows.Forms.TabPage tbNewDatabaseRestore;
        private System.Windows.Forms.Panel pnlNewDatabaseRestore;
        private System.Windows.Forms.TextBox txtRestorePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbExistingDatabaseRestore;
        private System.Windows.Forms.Panel pnlExistingDatabaseRestore;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.CheckBox chkRestoreName;
        private System.Windows.Forms.TextBox txtRestoreDatabaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtNewDatabaseName;
        private System.Windows.Forms.Label label4;
    }
}