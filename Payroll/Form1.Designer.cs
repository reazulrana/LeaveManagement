namespace Payroll
{
    partial class frmMain
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewContact = new System.Windows.Forms.ToolStripMenuItem();
            this.cardIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateMail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateContact = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatetUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxAll_Employee_Leave_Information = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackupDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestoreDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMailSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSendMail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIndividualLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllLeaveSummery = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.AutoSize = false;
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuEdit,
            this.mnuInformation,
            this.mnuSetting,
            this.mnuMailSMS,
            this.mnuReport});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(784, 40);
            this.mnuFile.TabIndex = 3;
            // 
            // mnuNew
            // 
            this.mnuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.mnuLeave,
            this.mnuNewContact,
            this.cardIssueToolStripMenuItem,
            this.userToolStripMenuItem,
            this.mnuCreateMail});
            this.mnuNew.Image = global::Payroll.Properties.Resources.add_Plus_Sign;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(59, 36);
            this.mnuNew.Text = "New";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Image = global::Payroll.Properties.Resources.new_userNew;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.employeeToolStripMenuItem.Text = "Create &Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // mnuLeave
            // 
            this.mnuLeave.Image = global::Payroll.Properties.Resources.leave_form_Icon;
            this.mnuLeave.Name = "mnuLeave";
            this.mnuLeave.Size = new System.Drawing.Size(165, 22);
            this.mnuLeave.Text = "Create &Leave";
            this.mnuLeave.Click += new System.EventHandler(this.mnuLeave_Click);
            // 
            // mnuNewContact
            // 
            this.mnuNewContact.Image = global::Payroll.Properties.Resources.Contact_Icon;
            this.mnuNewContact.Name = "mnuNewContact";
            this.mnuNewContact.Size = new System.Drawing.Size(165, 22);
            this.mnuNewContact.Text = "Create &Contact";
            this.mnuNewContact.Click += new System.EventHandler(this.mnuNewContact_Click);
            // 
            // cardIssueToolStripMenuItem
            // 
            this.cardIssueToolStripMenuItem.Image = global::Payroll.Properties.Resources.id_card_icon_png_transparent_png;
            this.cardIssueToolStripMenuItem.Name = "cardIssueToolStripMenuItem";
            this.cardIssueToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cardIssueToolStripMenuItem.Text = "Create C&ard Issue";
            this.cardIssueToolStripMenuItem.Click += new System.EventHandler(this.cardIssueToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Image = global::Payroll.Properties.Resources._13698388621005230997add_business_user1;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.userToolStripMenuItem.Text = "Create &User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // mnuCreateMail
            // 
            this.mnuCreateMail.Image = global::Payroll.Properties.Resources.Email1;
            this.mnuCreateMail.Name = "mnuCreateMail";
            this.mnuCreateMail.Size = new System.Drawing.Size(165, 22);
            this.mnuCreateMail.Text = "Create Mail";
            this.mnuCreateMail.Click += new System.EventHandler(this.mnuCreateMail_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateEmployeeToolStripMenuItem,
            this.mnuUpdateLeave,
            this.mnuUpdateContact,
            this.updateToolStripMenuItem,
            this.updatetUserToolStripMenuItem});
            this.mnuEdit.Image = global::Payroll.Properties.Resources.Edit_File_64px;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(55, 36);
            this.mnuEdit.Text = "Edit";
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Image = global::Payroll.Properties.Resources.Registration_64px;
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateEmployeeToolStripMenuItem.Text = "Update &Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // mnuUpdateLeave
            // 
            this.mnuUpdateLeave.Image = global::Payroll.Properties.Resources.leave_form_Icon;
            this.mnuUpdateLeave.Name = "mnuUpdateLeave";
            this.mnuUpdateLeave.Size = new System.Drawing.Size(167, 22);
            this.mnuUpdateLeave.Text = "Update &Leave";
            this.mnuUpdateLeave.Click += new System.EventHandler(this.mnuUpdateLeave_Click);
            // 
            // mnuUpdateContact
            // 
            this.mnuUpdateContact.Image = global::Payroll.Properties.Resources.Update_Contact_Icon;
            this.mnuUpdateContact.Name = "mnuUpdateContact";
            this.mnuUpdateContact.Size = new System.Drawing.Size(167, 22);
            this.mnuUpdateContact.Text = "Update &Contact";
            this.mnuUpdateContact.Click += new System.EventHandler(this.mnuUpdateContact_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::Payroll.Properties.Resources.employee_id_card1;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateToolStripMenuItem.Text = "Update C&ard Info";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // updatetUserToolStripMenuItem
            // 
            this.updatetUserToolStripMenuItem.Image = global::Payroll.Properties.Resources.user_edit;
            this.updatetUserToolStripMenuItem.Name = "updatetUserToolStripMenuItem";
            this.updatetUserToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updatetUserToolStripMenuItem.Text = "Updatet &User";
            // 
            // mnuInformation
            // 
            this.mnuInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxAll_Employee_Leave_Information});
            this.mnuInformation.Image = global::Payroll.Properties.Resources.status;
            this.mnuInformation.Name = "mnuInformation";
            this.mnuInformation.Size = new System.Drawing.Size(98, 36);
            this.mnuInformation.Text = "Information";
            // 
            // cntxAll_Employee_Leave_Information
            // 
            this.cntxAll_Employee_Leave_Information.Image = global::Payroll.Properties.Resources.user_icon;
            this.cntxAll_Employee_Leave_Information.Name = "cntxAll_Employee_Leave_Information";
            this.cntxAll_Employee_Leave_Information.Size = new System.Drawing.Size(242, 22);
            this.cntxAll_Employee_Leave_Information.Text = "All Employee Leave Information";
            this.cntxAll_Employee_Leave_Information.Click += new System.EventHandler(this.cntxAll_Employee_Leave_Information_Click);
            // 
            // mnuSetting
            // 
            this.mnuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackupDatabase,
            this.mnuRestoreDatabase});
            this.mnuSetting.Image = global::Payroll.Properties.Resources.icons8_Settings_64px;
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(77, 36);
            this.mnuSetting.Text = "Settings";
            // 
            // mnuBackupDatabase
            // 
            this.mnuBackupDatabase.Image = global::Payroll.Properties.Resources.Backup_Database_1;
            this.mnuBackupDatabase.Name = "mnuBackupDatabase";
            this.mnuBackupDatabase.Size = new System.Drawing.Size(167, 22);
            this.mnuBackupDatabase.Text = "&Back up Database";
            this.mnuBackupDatabase.Click += new System.EventHandler(this.backUpDatabaseToolStripMenuItem_Click);
            // 
            // mnuRestoreDatabase
            // 
            this.mnuRestoreDatabase.Image = global::Payroll.Properties.Resources.database_restore;
            this.mnuRestoreDatabase.Name = "mnuRestoreDatabase";
            this.mnuRestoreDatabase.Size = new System.Drawing.Size(167, 22);
            this.mnuRestoreDatabase.Text = "&Restore Databas";
            this.mnuRestoreDatabase.Click += new System.EventHandler(this.mnuRestoreDatabase_Click);
            // 
            // mnuMailSMS
            // 
            this.mnuMailSMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSendMail});
            this.mnuMailSMS.Image = global::Payroll.Properties.Resources.Email;
            this.mnuMailSMS.Name = "mnuMailSMS";
            this.mnuMailSMS.Size = new System.Drawing.Size(86, 36);
            this.mnuMailSMS.Text = "Mail/SMS";
            // 
            // mnuSendMail
            // 
            this.mnuSendMail.Image = global::Payroll.Properties.Resources.SendEmail2;
            this.mnuSendMail.Name = "mnuSendMail";
            this.mnuSendMail.ShowShortcutKeys = false;
            this.mnuSendMail.Size = new System.Drawing.Size(152, 22);
            this.mnuSendMail.Text = "&Send Mail";
            this.mnuSendMail.Click += new System.EventHandler(this.mnuSendMail_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIndividualLeave,
            this.mnuAllLeaveSummery});
            this.mnuReport.Image = global::Payroll.Properties.Resources.Pass_Fail_64px;
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(70, 36);
            this.mnuReport.Text = "&Report";
            // 
            // mnuIndividualLeave
            // 
            this.mnuIndividualLeave.Image = global::Payroll.Properties.Resources.user_icon;
            this.mnuIndividualLeave.Name = "mnuIndividualLeave";
            this.mnuIndividualLeave.Size = new System.Drawing.Size(175, 22);
            this.mnuIndividualLeave.Text = "&Individual Leave";
            this.mnuIndividualLeave.Click += new System.EventHandler(this.mnuIndividualLeave_Click);
            // 
            // mnuAllLeaveSummery
            // 
            this.mnuAllLeaveSummery.Image = global::Payroll.Properties.Resources.User_Groups_32px;
            this.mnuAllLeaveSummery.Name = "mnuAllLeaveSummery";
            this.mnuAllLeaveSummery.Size = new System.Drawing.Size(175, 22);
            this.mnuAllLeaveSummery.Text = "&All Leave Summery";
            this.mnuAllLeaveSummery.Click += new System.EventHandler(this.mnuAllLeaveSummery_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(489, 4);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(295, 29);
            this.lblUser.TabIndex = 5;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mnuFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLeave;
        private System.Windows.Forms.ToolStripMenuItem mnuNewContact;
        private System.Windows.Forms.ToolStripMenuItem cardIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuInformation;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuMailSMS;
        private System.Windows.Forms.ToolStripMenuItem cntxAll_Employee_Leave_Information;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateLeave;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateContact;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatetUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSendMail;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateMail;
        private System.Windows.Forms.ToolStripMenuItem mnuBackupDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuRestoreDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuIndividualLeave;
        private System.Windows.Forms.ToolStripMenuItem mnuAllLeaveSummery;
    }
}

