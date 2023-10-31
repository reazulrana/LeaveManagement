namespace Payroll
{
    partial class frmNewEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNIDNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.dtAppontDate = new System.Windows.Forms.DateTimePicker();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.dtIDCardAssignDate = new System.Windows.Forms.DateTimePicker();
            this.chkAppointDate = new System.Windows.Forms.CheckBox();
            this.chkIDCardAssignDate = new System.Windows.Forms.CheckBox();
            this.chkBirthDate = new System.Windows.Forms.CheckBox();
            this.chkJoiningDate = new System.Windows.Forms.CheckBox();
            this.pnlBootm = new System.Windows.Forms.Panel();
            this.tbEmpInfo = new System.Windows.Forms.TabControl();
            this.tbLeaveInformation = new System.Windows.Forms.TabPage();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvLeaveDetails = new System.Windows.Forms.DataGridView();
            this.cntxLeaveDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxAddNewLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxEditLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDeleteLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxPrintLeaveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.optAdvance = new System.Windows.Forms.RadioButton();
            this.optMaternity = new System.Windows.Forms.RadioButton();
            this.optLWP = new System.Windows.Forms.RadioButton();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.lblLeaveCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.optSL = new System.Windows.Forms.RadioButton();
            this.optPL = new System.Windows.Forms.RadioButton();
            this.optCL = new System.Windows.Forms.RadioButton();
            this.tbContactNo = new System.Windows.Forms.TabPage();
            this.dgvContactNo = new System.Windows.Forms.DataGridView();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxContactNo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxEditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDeleteContact = new System.Windows.Forms.ToolStripMenuItem();
            this.tbIDCardInformation = new System.Windows.Forms.TabPage();
            this.dgvIdCardInformation = new System.Windows.Forms.DataGridView();
            this.cntxNational_ID_Card_Information = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxAddCard = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxEditCard = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDeleteCard = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMailList = new System.Windows.Forms.TabPage();
            this.dgvMailList = new System.Windows.Forms.DataGridView();
            this.cntxMailList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxAddMail = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxEditmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDeleteMail = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxSendMail = new System.Windows.Forms.ToolStripMenuItem();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.leaveDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nIDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCodeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardAssignDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCodeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picEmpPhoto = new System.Windows.Forms.PictureBox();
            this.lDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonofLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attachements = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBootm.SuspendLayout();
            this.tbEmpInfo.SuspendLayout();
            this.tbLeaveInformation.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).BeginInit();
            this.cntxLeaveDetails.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tbContactNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactNo)).BeginInit();
            this.cntxContactNo.SuspendLayout();
            this.tbIDCardInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdCardInformation)).BeginInit();
            this.cntxNational_ID_Card_Information.SuspendLayout();
            this.tblMailList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMailList)).BeginInit();
            this.cntxMailList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIDDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(24, 37);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(194, 20);
            this.txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(298, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(24, 78);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(194, 20);
            this.txtDesignation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Designation";
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(298, 78);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(194, 20);
            this.txtBranch.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Branch";
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(24, 119);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(194, 20);
            this.txtQualification.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Qualification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Appoint Date";
            // 
            // txtNIDNumber
            // 
            this.txtNIDNumber.Location = new System.Drawing.Point(298, 160);
            this.txtNIDNumber.Name = "txtNIDNumber";
            this.txtNIDNumber.Size = new System.Drawing.Size(194, 20);
            this.txtNIDNumber.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "NID Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID Card Assign Date";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(298, 200);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(194, 20);
            this.txtBloodGroup.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Blood Gruop";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Joining Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(518, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Photo";
            // 
            // dtAppontDate
            // 
            this.dtAppontDate.CustomFormat = "dd-MMM-yyyy";
            this.dtAppontDate.Enabled = false;
            this.dtAppontDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAppontDate.Location = new System.Drawing.Point(24, 160);
            this.dtAppontDate.Name = "dtAppontDate";
            this.dtAppontDate.Size = new System.Drawing.Size(193, 20);
            this.dtAppontDate.TabIndex = 29;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CustomFormat = "dd-MMM-yyyy";
            this.dtBirthDate.Enabled = false;
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthDate.Location = new System.Drawing.Point(298, 119);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(193, 20);
            this.dtBirthDate.TabIndex = 30;
            // 
            // dtJoiningDate
            // 
            this.dtJoiningDate.CustomFormat = "dd-MMM-yyyy";
            this.dtJoiningDate.Enabled = false;
            this.dtJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtJoiningDate.Location = new System.Drawing.Point(24, 239);
            this.dtJoiningDate.Name = "dtJoiningDate";
            this.dtJoiningDate.Size = new System.Drawing.Size(193, 20);
            this.dtJoiningDate.TabIndex = 31;
            // 
            // dtIDCardAssignDate
            // 
            this.dtIDCardAssignDate.CustomFormat = "dd-MMM-yyyy";
            this.dtIDCardAssignDate.Enabled = false;
            this.dtIDCardAssignDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIDCardAssignDate.Location = new System.Drawing.Point(24, 200);
            this.dtIDCardAssignDate.Name = "dtIDCardAssignDate";
            this.dtIDCardAssignDate.Size = new System.Drawing.Size(193, 20);
            this.dtIDCardAssignDate.TabIndex = 32;
            // 
            // chkAppointDate
            // 
            this.chkAppointDate.AutoSize = true;
            this.chkAppointDate.Location = new System.Drawing.Point(220, 164);
            this.chkAppointDate.Name = "chkAppointDate";
            this.chkAppointDate.Size = new System.Drawing.Size(15, 14);
            this.chkAppointDate.TabIndex = 33;
            this.chkAppointDate.UseVisualStyleBackColor = true;
            this.chkAppointDate.CheckedChanged += new System.EventHandler(this.chkAppointDate_CheckedChanged);
            // 
            // chkIDCardAssignDate
            // 
            this.chkIDCardAssignDate.AutoSize = true;
            this.chkIDCardAssignDate.Location = new System.Drawing.Point(220, 203);
            this.chkIDCardAssignDate.Name = "chkIDCardAssignDate";
            this.chkIDCardAssignDate.Size = new System.Drawing.Size(15, 14);
            this.chkIDCardAssignDate.TabIndex = 35;
            this.chkIDCardAssignDate.UseVisualStyleBackColor = true;
            this.chkIDCardAssignDate.CheckedChanged += new System.EventHandler(this.chkIDCardAssignDate_CheckedChanged);
            // 
            // chkBirthDate
            // 
            this.chkBirthDate.AutoSize = true;
            this.chkBirthDate.Location = new System.Drawing.Point(493, 123);
            this.chkBirthDate.Name = "chkBirthDate";
            this.chkBirthDate.Size = new System.Drawing.Size(15, 14);
            this.chkBirthDate.TabIndex = 36;
            this.chkBirthDate.UseVisualStyleBackColor = true;
            this.chkBirthDate.CheckedChanged += new System.EventHandler(this.chkBirthDate_CheckedChanged);
            // 
            // chkJoiningDate
            // 
            this.chkJoiningDate.AutoSize = true;
            this.chkJoiningDate.Location = new System.Drawing.Point(220, 242);
            this.chkJoiningDate.Name = "chkJoiningDate";
            this.chkJoiningDate.Size = new System.Drawing.Size(15, 14);
            this.chkJoiningDate.TabIndex = 37;
            this.chkJoiningDate.UseVisualStyleBackColor = true;
            this.chkJoiningDate.CheckedChanged += new System.EventHandler(this.chkJoiningDate_CheckedChanged);
            // 
            // pnlBootm
            // 
            this.pnlBootm.Controls.Add(this.tbEmpInfo);
            this.pnlBootm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBootm.Location = new System.Drawing.Point(0, 296);
            this.pnlBootm.Name = "pnlBootm";
            this.pnlBootm.Size = new System.Drawing.Size(717, 216);
            this.pnlBootm.TabIndex = 38;
            // 
            // tbEmpInfo
            // 
            this.tbEmpInfo.Controls.Add(this.tbLeaveInformation);
            this.tbEmpInfo.Controls.Add(this.tbContactNo);
            this.tbEmpInfo.Controls.Add(this.tbIDCardInformation);
            this.tbEmpInfo.Controls.Add(this.tblMailList);
            this.tbEmpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEmpInfo.Location = new System.Drawing.Point(0, 0);
            this.tbEmpInfo.Name = "tbEmpInfo";
            this.tbEmpInfo.SelectedIndex = 0;
            this.tbEmpInfo.Size = new System.Drawing.Size(717, 216);
            this.tbEmpInfo.TabIndex = 0;
            this.tbEmpInfo.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbEmpInfo_Selected);
            // 
            // tbLeaveInformation
            // 
            this.tbLeaveInformation.Controls.Add(this.pnlBody);
            this.tbLeaveInformation.Controls.Add(this.pnlTop);
            this.tbLeaveInformation.Location = new System.Drawing.Point(4, 22);
            this.tbLeaveInformation.Name = "tbLeaveInformation";
            this.tbLeaveInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tbLeaveInformation.Size = new System.Drawing.Size(709, 190);
            this.tbLeaveInformation.TabIndex = 0;
            this.tbLeaveInformation.Text = "Leave Information";
            this.tbLeaveInformation.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvLeaveDetails);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(3, 33);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(703, 154);
            this.pnlBody.TabIndex = 2;
            // 
            // dgvLeaveDetails
            // 
            this.dgvLeaveDetails.AllowUserToDeleteRows = false;
            this.dgvLeaveDetails.AutoGenerateColumns = false;
            this.dgvLeaveDetails.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvLeaveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lDIDDataGridViewTextBoxColumn,
            this.empCodeDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.leaveTypeDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.totalLeaveDataGridViewTextBoxColumn,
            this.reasonofLeaveDataGridViewTextBoxColumn,
            this.FileName,
            this.Attachements});
            this.dgvLeaveDetails.ContextMenuStrip = this.cntxLeaveDetails;
            this.dgvLeaveDetails.DataSource = this.leaveDetailsBindingSource;
            this.dgvLeaveDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaveDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvLeaveDetails.Name = "dgvLeaveDetails";
            this.dgvLeaveDetails.ReadOnly = true;
            this.dgvLeaveDetails.Size = new System.Drawing.Size(703, 154);
            this.dgvLeaveDetails.TabIndex = 0;
            this.dgvLeaveDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvLeaveDetails_MouseUp);
            // 
            // cntxLeaveDetails
            // 
            this.cntxLeaveDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxAddNewLeave,
            this.cntxEditLeave,
            this.cntxDeleteLeave,
            this.cntxPrintLeaveReport});
            this.cntxLeaveDetails.Name = "cntxLeaveDetails";
            this.cntxLeaveDetails.Size = new System.Drawing.Size(141, 92);
            // 
            // cntxAddNewLeave
            // 
            this.cntxAddNewLeave.Name = "cntxAddNewLeave";
            this.cntxAddNewLeave.Size = new System.Drawing.Size(140, 22);
            this.cntxAddNewLeave.Text = "Add &Leave";
            this.cntxAddNewLeave.Click += new System.EventHandler(this.cntxAddNewLeave_Click);
            // 
            // cntxEditLeave
            // 
            this.cntxEditLeave.Name = "cntxEditLeave";
            this.cntxEditLeave.Size = new System.Drawing.Size(140, 22);
            this.cntxEditLeave.Text = "&Edit Leave";
            this.cntxEditLeave.Click += new System.EventHandler(this.cntxEditLeave_Click);
            // 
            // cntxDeleteLeave
            // 
            this.cntxDeleteLeave.Name = "cntxDeleteLeave";
            this.cntxDeleteLeave.Size = new System.Drawing.Size(140, 22);
            this.cntxDeleteLeave.Text = "&Delete Leave";
            this.cntxDeleteLeave.Click += new System.EventHandler(this.cntxDeleteLeave_Click);
            // 
            // cntxPrintLeaveReport
            // 
            this.cntxPrintLeaveReport.Name = "cntxPrintLeaveReport";
            this.cntxPrintLeaveReport.Size = new System.Drawing.Size(140, 22);
            this.cntxPrintLeaveReport.Text = "&Print Report";
            this.cntxPrintLeaveReport.Click += new System.EventHandler(this.cntxPrintLeaveReport_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.OldLace;
            this.pnlTop.Controls.Add(this.optAdvance);
            this.pnlTop.Controls.Add(this.optMaternity);
            this.pnlTop.Controls.Add(this.optLWP);
            this.pnlTop.Controls.Add(this.optAll);
            this.pnlTop.Controls.Add(this.lblLeaveCount);
            this.pnlTop.Controls.Add(this.label13);
            this.pnlTop.Controls.Add(this.optSL);
            this.pnlTop.Controls.Add(this.optPL);
            this.pnlTop.Controls.Add(this.optCL);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(703, 30);
            this.pnlTop.TabIndex = 1;
            // 
            // optAdvance
            // 
            this.optAdvance.AutoSize = true;
            this.optAdvance.Location = new System.Drawing.Point(331, 6);
            this.optAdvance.Name = "optAdvance";
            this.optAdvance.Size = new System.Drawing.Size(68, 17);
            this.optAdvance.TabIndex = 9;
            this.optAdvance.TabStop = true;
            this.optAdvance.Text = "Advance";
            this.optAdvance.UseVisualStyleBackColor = true;
            this.optAdvance.CheckedChanged += new System.EventHandler(this.optAdvance_CheckedChanged);
            // 
            // optMaternity
            // 
            this.optMaternity.AutoSize = true;
            this.optMaternity.Location = new System.Drawing.Point(245, 6);
            this.optMaternity.Name = "optMaternity";
            this.optMaternity.Size = new System.Drawing.Size(68, 17);
            this.optMaternity.TabIndex = 8;
            this.optMaternity.TabStop = true;
            this.optMaternity.Text = "Maternity";
            this.optMaternity.UseVisualStyleBackColor = true;
            this.optMaternity.CheckedChanged += new System.EventHandler(this.optMaternity_CheckedChanged);
            // 
            // optLWP
            // 
            this.optLWP.AutoSize = true;
            this.optLWP.Location = new System.Drawing.Point(190, 6);
            this.optLWP.Name = "optLWP";
            this.optLWP.Size = new System.Drawing.Size(49, 17);
            this.optLWP.TabIndex = 7;
            this.optLWP.TabStop = true;
            this.optLWP.Text = "LWP";
            this.optLWP.UseVisualStyleBackColor = true;
            this.optLWP.CheckedChanged += new System.EventHandler(this.optLWP_CheckedChanged);
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.BackColor = System.Drawing.Color.OldLace;
            this.optAll.Checked = true;
            this.optAll.Location = new System.Drawing.Point(9, 6);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(36, 17);
            this.optAll.TabIndex = 6;
            this.optAll.TabStop = true;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = false;
            this.optAll.CheckedChanged += new System.EventHandler(this.optAll_CheckedChanged);
            // 
            // lblLeaveCount
            // 
            this.lblLeaveCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeaveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveCount.Location = new System.Drawing.Point(530, 4);
            this.lblLeaveCount.Name = "lblLeaveCount";
            this.lblLeaveCount.Size = new System.Drawing.Size(133, 21);
            this.lblLeaveCount.TabIndex = 4;
            this.lblLeaveCount.Text = "0";
            this.lblLeaveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(456, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Leave Count";
            // 
            // optSL
            // 
            this.optSL.AutoSize = true;
            this.optSL.Location = new System.Drawing.Point(140, 6);
            this.optSL.Name = "optSL";
            this.optSL.Size = new System.Drawing.Size(38, 17);
            this.optSL.TabIndex = 2;
            this.optSL.TabStop = true;
            this.optSL.Text = "SL";
            this.optSL.UseVisualStyleBackColor = true;
            this.optSL.CheckedChanged += new System.EventHandler(this.optSL_CheckedChanged);
            // 
            // optPL
            // 
            this.optPL.AutoSize = true;
            this.optPL.BackColor = System.Drawing.Color.OldLace;
            this.optPL.Location = new System.Drawing.Point(96, 6);
            this.optPL.Name = "optPL";
            this.optPL.Size = new System.Drawing.Size(38, 17);
            this.optPL.TabIndex = 1;
            this.optPL.TabStop = true;
            this.optPL.Text = "PL";
            this.optPL.UseVisualStyleBackColor = false;
            this.optPL.CheckedChanged += new System.EventHandler(this.optPL_CheckedChanged);
            // 
            // optCL
            // 
            this.optCL.AutoSize = true;
            this.optCL.BackColor = System.Drawing.Color.OldLace;
            this.optCL.Location = new System.Drawing.Point(52, 6);
            this.optCL.Name = "optCL";
            this.optCL.Size = new System.Drawing.Size(38, 17);
            this.optCL.TabIndex = 0;
            this.optCL.TabStop = true;
            this.optCL.Text = "CL";
            this.optCL.UseVisualStyleBackColor = false;
            this.optCL.CheckedChanged += new System.EventHandler(this.optCL_CheckedChanged);
            // 
            // tbContactNo
            // 
            this.tbContactNo.Controls.Add(this.dgvContactNo);
            this.tbContactNo.Location = new System.Drawing.Point(4, 22);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Padding = new System.Windows.Forms.Padding(3);
            this.tbContactNo.Size = new System.Drawing.Size(709, 190);
            this.tbContactNo.TabIndex = 1;
            this.tbContactNo.Text = "Contact List";
            this.tbContactNo.UseVisualStyleBackColor = true;
            // 
            // dgvContactNo
            // 
            this.dgvContactNo.AllowUserToDeleteRows = false;
            this.dgvContactNo.AutoGenerateColumns = false;
            this.dgvContactNo.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvContactNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.empCodeDataGridViewTextBoxColumn1,
            this.contactNoDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.Remarks});
            this.dgvContactNo.ContextMenuStrip = this.cntxContactNo;
            this.dgvContactNo.DataSource = this.contactsBindingSource;
            this.dgvContactNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContactNo.Location = new System.Drawing.Point(3, 3);
            this.dgvContactNo.Name = "dgvContactNo";
            this.dgvContactNo.ReadOnly = true;
            this.dgvContactNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactNo.Size = new System.Drawing.Size(703, 184);
            this.dgvContactNo.TabIndex = 0;
            this.dgvContactNo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvContactNo_MouseUp);
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 250;
            // 
            // cntxContactNo
            // 
            this.cntxContactNo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactsToolStripMenuItem,
            this.cntxEditContact,
            this.cntxDeleteContact});
            this.cntxContactNo.Name = "cntxContactNo";
            this.cntxContactNo.Size = new System.Drawing.Size(153, 70);
            // 
            // addContactsToolStripMenuItem
            // 
            this.addContactsToolStripMenuItem.Name = "addContactsToolStripMenuItem";
            this.addContactsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addContactsToolStripMenuItem.Text = "&Add Contact";
            this.addContactsToolStripMenuItem.Click += new System.EventHandler(this.addContactsToolStripMenuItem_Click);
            // 
            // cntxEditContact
            // 
            this.cntxEditContact.Name = "cntxEditContact";
            this.cntxEditContact.Size = new System.Drawing.Size(152, 22);
            this.cntxEditContact.Text = "&Edit Contact";
            this.cntxEditContact.Click += new System.EventHandler(this.cntxEditContact_Click);
            // 
            // cntxDeleteContact
            // 
            this.cntxDeleteContact.Name = "cntxDeleteContact";
            this.cntxDeleteContact.Size = new System.Drawing.Size(152, 22);
            this.cntxDeleteContact.Text = "&Delete Contact";
            this.cntxDeleteContact.Click += new System.EventHandler(this.cntxDeleteContact_Click);
            // 
            // tbIDCardInformation
            // 
            this.tbIDCardInformation.Controls.Add(this.dgvIdCardInformation);
            this.tbIDCardInformation.Location = new System.Drawing.Point(4, 22);
            this.tbIDCardInformation.Name = "tbIDCardInformation";
            this.tbIDCardInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tbIDCardInformation.Size = new System.Drawing.Size(709, 190);
            this.tbIDCardInformation.TabIndex = 2;
            this.tbIDCardInformation.Text = "ID Card List";
            this.tbIDCardInformation.UseVisualStyleBackColor = true;
            // 
            // dgvIdCardInformation
            // 
            this.dgvIdCardInformation.AllowUserToDeleteRows = false;
            this.dgvIdCardInformation.AutoGenerateColumns = false;
            this.dgvIdCardInformation.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvIdCardInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdCardInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIDIDDataGridViewTextBoxColumn,
            this.empCodeDataGridViewTextBoxColumn2,
            this.cardAssignDateDataGridViewTextBoxColumn,
            this.nIDNumberDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dgvIdCardInformation.ContextMenuStrip = this.cntxNational_ID_Card_Information;
            this.dgvIdCardInformation.DataSource = this.nIDDetailsBindingSource;
            this.dgvIdCardInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIdCardInformation.Location = new System.Drawing.Point(3, 3);
            this.dgvIdCardInformation.Name = "dgvIdCardInformation";
            this.dgvIdCardInformation.ReadOnly = true;
            this.dgvIdCardInformation.Size = new System.Drawing.Size(703, 184);
            this.dgvIdCardInformation.TabIndex = 0;
            this.dgvIdCardInformation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvIdCardInformation_MouseUp);
            // 
            // cntxNational_ID_Card_Information
            // 
            this.cntxNational_ID_Card_Information.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxAddCard,
            this.cntxEditCard,
            this.cntxDeleteCard});
            this.cntxNational_ID_Card_Information.Name = "cntxNational_ID_Card_Information";
            this.cntxNational_ID_Card_Information.Size = new System.Drawing.Size(136, 70);
            // 
            // cntxAddCard
            // 
            this.cntxAddCard.Name = "cntxAddCard";
            this.cntxAddCard.Size = new System.Drawing.Size(135, 22);
            this.cntxAddCard.Text = "&Add Card";
            this.cntxAddCard.Click += new System.EventHandler(this.cntxAddCard_Click);
            // 
            // cntxEditCard
            // 
            this.cntxEditCard.Name = "cntxEditCard";
            this.cntxEditCard.Size = new System.Drawing.Size(135, 22);
            this.cntxEditCard.Text = "&Edit Card";
            this.cntxEditCard.Click += new System.EventHandler(this.cntxEditCard_Click);
            // 
            // cntxDeleteCard
            // 
            this.cntxDeleteCard.Name = "cntxDeleteCard";
            this.cntxDeleteCard.Size = new System.Drawing.Size(135, 22);
            this.cntxDeleteCard.Text = "&Delete Card";
            this.cntxDeleteCard.Click += new System.EventHandler(this.cntxDeleteCard_Click);
            // 
            // tblMailList
            // 
            this.tblMailList.Controls.Add(this.dgvMailList);
            this.tblMailList.Location = new System.Drawing.Point(4, 22);
            this.tblMailList.Name = "tblMailList";
            this.tblMailList.Padding = new System.Windows.Forms.Padding(3);
            this.tblMailList.Size = new System.Drawing.Size(709, 190);
            this.tblMailList.TabIndex = 3;
            this.tblMailList.Text = "Mail List";
            this.tblMailList.UseVisualStyleBackColor = true;
            // 
            // dgvMailList
            // 
            this.dgvMailList.AllowUserToAddRows = false;
            this.dgvMailList.AllowUserToDeleteRows = false;
            this.dgvMailList.AutoGenerateColumns = false;
            this.dgvMailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mailIDDataGridViewTextBoxColumn,
            this.empCodeDataGridViewTextBoxColumn3,
            this.emailNoDataGridViewTextBoxColumn});
            this.dgvMailList.ContextMenuStrip = this.cntxMailList;
            this.dgvMailList.DataSource = this.mailListBindingSource;
            this.dgvMailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMailList.Location = new System.Drawing.Point(3, 3);
            this.dgvMailList.Name = "dgvMailList";
            this.dgvMailList.ReadOnly = true;
            this.dgvMailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMailList.Size = new System.Drawing.Size(703, 184);
            this.dgvMailList.TabIndex = 0;
            this.dgvMailList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvMailList_MouseUp);
            // 
            // cntxMailList
            // 
            this.cntxMailList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxAddMail,
            this.cntxEditmail,
            this.cntxDeleteMail,
            this.cntxSendMail});
            this.cntxMailList.Name = "cntxMailList";
            this.cntxMailList.Size = new System.Drawing.Size(134, 92);
            // 
            // cntxAddMail
            // 
            this.cntxAddMail.Name = "cntxAddMail";
            this.cntxAddMail.Size = new System.Drawing.Size(133, 22);
            this.cntxAddMail.Text = "Add &Mail";
            this.cntxAddMail.Click += new System.EventHandler(this.cntxAddMail_Click);
            // 
            // cntxEditmail
            // 
            this.cntxEditmail.Name = "cntxEditmail";
            this.cntxEditmail.Size = new System.Drawing.Size(133, 22);
            this.cntxEditmail.Text = "&Edit Mail";
            this.cntxEditmail.Click += new System.EventHandler(this.cntxEditmail_Click);
            // 
            // cntxDeleteMail
            // 
            this.cntxDeleteMail.Name = "cntxDeleteMail";
            this.cntxDeleteMail.Size = new System.Drawing.Size(133, 22);
            this.cntxDeleteMail.Text = "&Delete Mail";
            this.cntxDeleteMail.Click += new System.EventHandler(this.cntxDeleteMail_Click);
            // 
            // cntxSendMail
            // 
            this.cntxSendMail.Name = "cntxSendMail";
            this.cntxSendMail.Size = new System.Drawing.Size(133, 22);
            this.cntxSendMail.Text = "&Send Mail";
            this.cntxSendMail.Click += new System.EventHandler(this.cntxSendMail_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(278, 239);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 41;
            this.dtStartDate.Visible = false;
            // 
            // leaveDetailsBindingSource
            // 
            this.leaveDetailsBindingSource.DataSource = typeof(BLL.LeaveDetails);
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            this.contactIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empCodeDataGridViewTextBoxColumn1
            // 
            this.empCodeDataGridViewTextBoxColumn1.DataPropertyName = "EmpCode";
            this.empCodeDataGridViewTextBoxColumn1.HeaderText = "Code";
            this.empCodeDataGridViewTextBoxColumn1.Name = "empCodeDataGridViewTextBoxColumn1";
            this.empCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.empCodeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operators";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataSource = typeof(BLL.Contacts);
            // 
            // nIDIDDataGridViewTextBoxColumn
            // 
            this.nIDIDDataGridViewTextBoxColumn.DataPropertyName = "NIDID";
            this.nIDIDDataGridViewTextBoxColumn.HeaderText = "NIDID";
            this.nIDIDDataGridViewTextBoxColumn.Name = "nIDIDDataGridViewTextBoxColumn";
            this.nIDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIDIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empCodeDataGridViewTextBoxColumn2
            // 
            this.empCodeDataGridViewTextBoxColumn2.DataPropertyName = "EmpCode";
            this.empCodeDataGridViewTextBoxColumn2.HeaderText = "Code";
            this.empCodeDataGridViewTextBoxColumn2.Name = "empCodeDataGridViewTextBoxColumn2";
            this.empCodeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.empCodeDataGridViewTextBoxColumn2.Visible = false;
            // 
            // cardAssignDateDataGridViewTextBoxColumn
            // 
            this.cardAssignDateDataGridViewTextBoxColumn.DataPropertyName = "CardAssignDate";
            this.cardAssignDateDataGridViewTextBoxColumn.HeaderText = "Assign Date";
            this.cardAssignDateDataGridViewTextBoxColumn.Name = "cardAssignDateDataGridViewTextBoxColumn";
            this.cardAssignDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardAssignDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // nIDNumberDataGridViewTextBoxColumn
            // 
            this.nIDNumberDataGridViewTextBoxColumn.DataPropertyName = "NIDNumber";
            this.nIDNumberDataGridViewTextBoxColumn.HeaderText = "ID Number";
            this.nIDNumberDataGridViewTextBoxColumn.Name = "nIDNumberDataGridViewTextBoxColumn";
            this.nIDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIDNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 320;
            // 
            // nIDDetailsBindingSource
            // 
            this.nIDDetailsBindingSource.DataSource = typeof(BLL.NIDDetails);
            // 
            // mailIDDataGridViewTextBoxColumn
            // 
            this.mailIDDataGridViewTextBoxColumn.DataPropertyName = "MailID";
            this.mailIDDataGridViewTextBoxColumn.HeaderText = "MailID";
            this.mailIDDataGridViewTextBoxColumn.Name = "mailIDDataGridViewTextBoxColumn";
            this.mailIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empCodeDataGridViewTextBoxColumn3
            // 
            this.empCodeDataGridViewTextBoxColumn3.DataPropertyName = "EmpCode";
            this.empCodeDataGridViewTextBoxColumn3.HeaderText = "EmpCode";
            this.empCodeDataGridViewTextBoxColumn3.Name = "empCodeDataGridViewTextBoxColumn3";
            this.empCodeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.empCodeDataGridViewTextBoxColumn3.Visible = false;
            // 
            // emailNoDataGridViewTextBoxColumn
            // 
            this.emailNoDataGridViewTextBoxColumn.DataPropertyName = "EmailNo";
            this.emailNoDataGridViewTextBoxColumn.HeaderText = "Email Description";
            this.emailNoDataGridViewTextBoxColumn.Name = "emailNoDataGridViewTextBoxColumn";
            this.emailNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailNoDataGridViewTextBoxColumn.Width = 650;
            // 
            // mailListBindingSource
            // 
            this.mailListBindingSource.DataSource = typeof(BLL.MailList);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Payroll.Properties.Resources.Close_Window_20px;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(410, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(193, 25);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClearImage
            // 
            this.btnClearImage.BackColor = System.Drawing.Color.White;
            this.btnClearImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearImage.ForeColor = System.Drawing.Color.Black;
            this.btnClearImage.Image = global::Payroll.Properties.Resources.Broom_20px;
            this.btnClearImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearImage.Location = new System.Drawing.Point(521, 217);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(150, 25);
            this.btnClearImage.TabIndex = 27;
            this.btnClearImage.Text = "Clear &Image";
            this.btnClearImage.UseVisualStyleBackColor = false;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::Payroll.Properties.Resources.Broom_20px;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(211, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 25);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::Payroll.Properties.Resources.Save_20px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(12, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 25);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Image = global::Payroll.Properties.Resources.Open_in_Browser_20px;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(521, 190);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(150, 26);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picEmpPhoto
            // 
            this.picEmpPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEmpPhoto.Location = new System.Drawing.Point(520, 34);
            this.picEmpPhoto.Name = "picEmpPhoto";
            this.picEmpPhoto.Size = new System.Drawing.Size(150, 150);
            this.picEmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmpPhoto.TabIndex = 23;
            this.picEmpPhoto.TabStop = false;
            // 
            // lDIDDataGridViewTextBoxColumn
            // 
            this.lDIDDataGridViewTextBoxColumn.DataPropertyName = "LDID";
            this.lDIDDataGridViewTextBoxColumn.HeaderText = "LDID";
            this.lDIDDataGridViewTextBoxColumn.Name = "lDIDDataGridViewTextBoxColumn";
            this.lDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lDIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empCodeDataGridViewTextBoxColumn
            // 
            this.empCodeDataGridViewTextBoxColumn.DataPropertyName = "EmpCode";
            this.empCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.empCodeDataGridViewTextBoxColumn.Name = "empCodeDataGridViewTextBoxColumn";
            this.empCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.empCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "Entry Date";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leaveTypeDataGridViewTextBoxColumn
            // 
            this.leaveTypeDataGridViewTextBoxColumn.DataPropertyName = "LeaveType";
            this.leaveTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.leaveTypeDataGridViewTextBoxColumn.Name = "leaveTypeDataGridViewTextBoxColumn";
            this.leaveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaveTypeDataGridViewTextBoxColumn.Width = 50;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            this.fromDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            this.toDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.toDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalLeaveDataGridViewTextBoxColumn
            // 
            this.totalLeaveDataGridViewTextBoxColumn.DataPropertyName = "TotalLeave";
            this.totalLeaveDataGridViewTextBoxColumn.HeaderText = "Leaves";
            this.totalLeaveDataGridViewTextBoxColumn.Name = "totalLeaveDataGridViewTextBoxColumn";
            this.totalLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalLeaveDataGridViewTextBoxColumn.Width = 50;
            // 
            // reasonofLeaveDataGridViewTextBoxColumn
            // 
            this.reasonofLeaveDataGridViewTextBoxColumn.DataPropertyName = "ReasonofLeave";
            this.reasonofLeaveDataGridViewTextBoxColumn.HeaderText = "ReasonofLeave";
            this.reasonofLeaveDataGridViewTextBoxColumn.Name = "reasonofLeaveDataGridViewTextBoxColumn";
            this.reasonofLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonofLeaveDataGridViewTextBoxColumn.Width = 200;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // Attachements
            // 
            this.Attachements.DataPropertyName = "Attachements";
            this.Attachements.HeaderText = "Attachements";
            this.Attachements.Name = "Attachements";
            this.Attachements.ReadOnly = true;
            this.Attachements.Visible = false;
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(717, 512);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.pnlBootm);
            this.Controls.Add(this.chkJoiningDate);
            this.Controls.Add(this.chkBirthDate);
            this.Controls.Add(this.chkIDCardAssignDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkAppointDate);
            this.Controls.Add(this.dtIDCardAssignDate);
            this.Controls.Add(this.dtJoiningDate);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.dtAppontDate);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picEmpPhoto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNIDNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNewEmployee_FormClosed);
            this.Load += new System.EventHandler(this.frmNewEmployee_Load);
            this.pnlBootm.ResumeLayout(false);
            this.tbEmpInfo.ResumeLayout(false);
            this.tbLeaveInformation.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).EndInit();
            this.cntxLeaveDetails.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tbContactNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactNo)).EndInit();
            this.cntxContactNo.ResumeLayout(false);
            this.tbIDCardInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdCardInformation)).EndInit();
            this.cntxNational_ID_Card_Information.ResumeLayout(false);
            this.tblMailList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMailList)).EndInit();
            this.cntxMailList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaveDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIDDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNIDNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picEmpPhoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.DateTimePicker dtAppontDate;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.DateTimePicker dtJoiningDate;
        private System.Windows.Forms.DateTimePicker dtIDCardAssignDate;
        private System.Windows.Forms.CheckBox chkAppointDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkIDCardAssignDate;
        private System.Windows.Forms.CheckBox chkBirthDate;
        private System.Windows.Forms.CheckBox chkJoiningDate;
        private System.Windows.Forms.Panel pnlBootm;
        private System.Windows.Forms.TabControl tbEmpInfo;
        private System.Windows.Forms.TabPage tbLeaveInformation;
        private System.Windows.Forms.DataGridView dgvLeaveDetails;
        private System.Windows.Forms.BindingSource leaveDetailsBindingSource;
        private System.Windows.Forms.TabPage tbContactNo;
        private System.Windows.Forms.DataGridView dgvContactNo;
        private System.Windows.Forms.TabPage tbIDCardInformation;
        private System.Windows.Forms.ContextMenuStrip cntxLeaveDetails;
        private System.Windows.Forms.ContextMenuStrip cntxContactNo;
        private System.Windows.Forms.DataGridView dgvIdCardInformation;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.BindingSource nIDDetailsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem cntxAddNewLeave;
        private System.Windows.Forms.ToolStripMenuItem cntxEditLeave;
        private System.Windows.Forms.ToolStripMenuItem cntxDeleteLeave;
        public System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblLeaveCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton optSL;
        private System.Windows.Forms.RadioButton optPL;
        private System.Windows.Forms.RadioButton optCL;
        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.RadioButton optLWP;
        private System.Windows.Forms.ToolStripMenuItem addContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cntxEditContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardAssignDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem cntxDeleteContact;
        private System.Windows.Forms.ContextMenuStrip cntxNational_ID_Card_Information;
        private System.Windows.Forms.ToolStripMenuItem cntxAddCard;
        private System.Windows.Forms.ToolStripMenuItem cntxEditCard;
        private System.Windows.Forms.ToolStripMenuItem cntxDeleteCard;
        private System.Windows.Forms.RadioButton optAdvance;
        private System.Windows.Forms.RadioButton optMaternity;
        private System.Windows.Forms.TabPage tblMailList;
        private System.Windows.Forms.DataGridView dgvMailList;
        private System.Windows.Forms.BindingSource mailListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cntxMailList;
        private System.Windows.Forms.ToolStripMenuItem cntxAddMail;
        private System.Windows.Forms.ToolStripMenuItem cntxEditmail;
        private System.Windows.Forms.ToolStripMenuItem cntxDeleteMail;
        private System.Windows.Forms.ToolStripMenuItem cntxSendMail;
        private System.Windows.Forms.ToolStripMenuItem cntxPrintLeaveReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonofLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewImageColumn Attachements;
    }
}