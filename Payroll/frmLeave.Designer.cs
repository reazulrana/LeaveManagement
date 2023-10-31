namespace Payroll
{
    partial class frmLeave
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
            this.txtFindCode = new System.Windows.Forms.TextBox();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSearchbox = new System.Windows.Forms.GroupBox();
            this.dtStartingYear = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTypeofLeave = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalLeave = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.txtCauseofLeave = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCL = new System.Windows.Forms.TextBox();
            this.txtPL = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dgvEmpList = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAssignDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGruopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.totalCLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.lblFileAttachment = new System.Windows.Forms.Label();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lnkShow = new System.Windows.Forms.LinkLabel();
            this.grpSearchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txtFindCode
            // 
            this.txtFindCode.Location = new System.Drawing.Point(44, 13);
            this.txtFindCode.Name = "txtFindCode";
            this.txtFindCode.Size = new System.Drawing.Size(149, 20);
            this.txtFindCode.TabIndex = 1;
            this.txtFindCode.TextChanged += new System.EventHandler(this.txtFindCode_TextChanged);
            this.txtFindCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindCode_KeyPress);
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(239, 13);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(215, 20);
            this.txtFindName.TabIndex = 3;
            this.txtFindName.TextChanged += new System.EventHandler(this.txtFindName_TextChanged);
            this.txtFindName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // grpSearchbox
            // 
            this.grpSearchbox.Controls.Add(this.dtStartingYear);
            this.grpSearchbox.Controls.Add(this.label20);
            this.grpSearchbox.Controls.Add(this.txtFindCode);
            this.grpSearchbox.Controls.Add(this.label1);
            this.grpSearchbox.Controls.Add(this.txtFindName);
            this.grpSearchbox.Controls.Add(this.label2);
            this.grpSearchbox.Location = new System.Drawing.Point(12, 6);
            this.grpSearchbox.Name = "grpSearchbox";
            this.grpSearchbox.Size = new System.Drawing.Size(655, 38);
            this.grpSearchbox.TabIndex = 5;
            this.grpSearchbox.TabStop = false;
            this.grpSearchbox.Text = "Search Box";
            // 
            // dtStartingYear
            // 
            this.dtStartingYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartingYear.Location = new System.Drawing.Point(495, 12);
            this.dtStartingYear.Name = "dtStartingYear";
            this.dtStartingYear.Size = new System.Drawing.Size(150, 20);
            this.dtStartingYear.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(460, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Designation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Branch";
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.Enabled = false;
            this.txtEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCode.Location = new System.Drawing.Point(80, 76);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Size = new System.Drawing.Size(184, 23);
            this.txtEmpCode.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(80, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 23);
            this.txtName.TabIndex = 11;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Enabled = false;
            this.txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(80, 153);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(401, 23);
            this.txtDesignation.TabIndex = 12;
            // 
            // txtBranch
            // 
            this.txtBranch.Enabled = false;
            this.txtBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranch.Location = new System.Drawing.Point(81, 191);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(400, 23);
            this.txtBranch.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 46);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(699, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Employee Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-2, 279);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(702, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Leave Information";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtEntryDate
            // 
            this.dtEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEntryDate.Location = new System.Drawing.Point(107, 308);
            this.dtEntryDate.Name = "dtEntryDate";
            this.dtEntryDate.Size = new System.Drawing.Size(214, 20);
            this.dtEntryDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date of Entry";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Type of Leave";
            // 
            // cmbTypeofLeave
            // 
            this.cmbTypeofLeave.FormattingEnabled = true;
            this.cmbTypeofLeave.Items.AddRange(new object[] {
            "CL",
            "PL",
            "SL",
            "LWP",
            "Advance",
            "Maternity",
            "Short"});
            this.cmbTypeofLeave.Location = new System.Drawing.Point(424, 308);
            this.cmbTypeofLeave.Name = "cmbTypeofLeave";
            this.cmbTypeofLeave.Size = new System.Drawing.Size(224, 21);
            this.cmbTypeofLeave.TabIndex = 19;
            this.cmbTypeofLeave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTypeofLeave_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Leave";
            // 
            // txtTotalLeave
            // 
            this.txtTotalLeave.Location = new System.Drawing.Point(107, 360);
            this.txtTotalLeave.Name = "txtTotalLeave";
            this.txtTotalLeave.Size = new System.Drawing.Size(214, 20);
            this.txtTotalLeave.TabIndex = 21;
            this.txtTotalLeave.Text = "0";
            this.txtTotalLeave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalLeave_KeyDown);
            this.txtTotalLeave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalLeave_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "From";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(107, 334);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(214, 20);
            this.dtFrom.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(398, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(424, 334);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(224, 20);
            this.dtTo.TabIndex = 24;
            // 
            // txtCauseofLeave
            // 
            this.txtCauseofLeave.Location = new System.Drawing.Point(107, 386);
            this.txtCauseofLeave.Multiline = true;
            this.txtCauseofLeave.Name = "txtCauseofLeave";
            this.txtCauseofLeave.Size = new System.Drawing.Size(541, 40);
            this.txtCauseofLeave.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cause of Leave";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(504, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Maximum Size 100 Character";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1, 224);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label16.Size = new System.Drawing.Size(699, 21);
            this.label16.TabIndex = 32;
            this.label16.Text = "Remaining Leave";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "CL:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(250, 255);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "PL:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(446, 255);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "SL:";
            // 
            // txtCL
            // 
            this.txtCL.Enabled = false;
            this.txtCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCL.Location = new System.Drawing.Point(81, 250);
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(163, 23);
            this.txtCL.TabIndex = 36;
            // 
            // txtPL
            // 
            this.txtPL.Enabled = false;
            this.txtPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPL.Location = new System.Drawing.Point(278, 250);
            this.txtPL.Name = "txtPL";
            this.txtPL.Size = new System.Drawing.Size(163, 23);
            this.txtPL.TabIndex = 37;
            // 
            // txtSL
            // 
            this.txtSL.Enabled = false;
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(475, 250);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(163, 23);
            this.txtSL.TabIndex = 38;
            // 
            // dgvEmpList
            // 
            this.dgvEmpList.AllowUserToDeleteRows = false;
            this.dgvEmpList.AutoGenerateColumns = false;
            this.dgvEmpList.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.empCodeDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.appointDateDataGridViewTextBoxColumn,
            this.nIDNumberDataGridViewTextBoxColumn,
            this.iDAssignDateDataGridViewTextBoxColumn,
            this.bloodGruopDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.totalCLDataGridViewTextBoxColumn,
            this.totalPLDataGridViewTextBoxColumn,
            this.totalSLDataGridViewTextBoxColumn});
            this.dgvEmpList.DataSource = this.personalBindingSource;
            this.dgvEmpList.Location = new System.Drawing.Point(19, 97);
            this.dgvEmpList.Name = "dgvEmpList";
            this.dgvEmpList.ReadOnly = true;
            this.dgvEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpList.Size = new System.Drawing.Size(447, 70);
            this.dgvEmpList.TabIndex = 6;
            this.dgvEmpList.Visible = false;
            this.dgvEmpList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEmpList_KeyDown);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // empCodeDataGridViewTextBoxColumn
            // 
            this.empCodeDataGridViewTextBoxColumn.DataPropertyName = "EmpCode";
            this.empCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.empCodeDataGridViewTextBoxColumn.Name = "empCodeDataGridViewTextBoxColumn";
            this.empCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            this.qualificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualificationDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Visible = false;
            // 
            // appointDateDataGridViewTextBoxColumn
            // 
            this.appointDateDataGridViewTextBoxColumn.DataPropertyName = "AppointDate";
            this.appointDateDataGridViewTextBoxColumn.HeaderText = "AppointDate";
            this.appointDateDataGridViewTextBoxColumn.Name = "appointDateDataGridViewTextBoxColumn";
            this.appointDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // nIDNumberDataGridViewTextBoxColumn
            // 
            this.nIDNumberDataGridViewTextBoxColumn.DataPropertyName = "NIDNumber";
            this.nIDNumberDataGridViewTextBoxColumn.HeaderText = "NIDNumber";
            this.nIDNumberDataGridViewTextBoxColumn.Name = "nIDNumberDataGridViewTextBoxColumn";
            this.nIDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIDNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDAssignDateDataGridViewTextBoxColumn
            // 
            this.iDAssignDateDataGridViewTextBoxColumn.DataPropertyName = "IDAssignDate";
            this.iDAssignDateDataGridViewTextBoxColumn.HeaderText = "IDAssignDate";
            this.iDAssignDateDataGridViewTextBoxColumn.Name = "iDAssignDateDataGridViewTextBoxColumn";
            this.iDAssignDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAssignDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // bloodGruopDataGridViewTextBoxColumn
            // 
            this.bloodGruopDataGridViewTextBoxColumn.DataPropertyName = "BloodGruop";
            this.bloodGruopDataGridViewTextBoxColumn.HeaderText = "BloodGruop";
            this.bloodGruopDataGridViewTextBoxColumn.Name = "bloodGruopDataGridViewTextBoxColumn";
            this.bloodGruopDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloodGruopDataGridViewTextBoxColumn.Visible = false;
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "JoiningDate";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "JoiningDate";
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            this.joiningDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.joiningDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            this.photoDataGridViewImageColumn.Visible = false;
            // 
            // totalCLDataGridViewTextBoxColumn
            // 
            this.totalCLDataGridViewTextBoxColumn.DataPropertyName = "TotalCL";
            this.totalCLDataGridViewTextBoxColumn.HeaderText = "TotalCL";
            this.totalCLDataGridViewTextBoxColumn.Name = "totalCLDataGridViewTextBoxColumn";
            this.totalCLDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCLDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalPLDataGridViewTextBoxColumn
            // 
            this.totalPLDataGridViewTextBoxColumn.DataPropertyName = "TotalPL";
            this.totalPLDataGridViewTextBoxColumn.HeaderText = "TotalPL";
            this.totalPLDataGridViewTextBoxColumn.Name = "totalPLDataGridViewTextBoxColumn";
            this.totalPLDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPLDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalSLDataGridViewTextBoxColumn
            // 
            this.totalSLDataGridViewTextBoxColumn.DataPropertyName = "TotalSL";
            this.totalSLDataGridViewTextBoxColumn.HeaderText = "TotalSL";
            this.totalSLDataGridViewTextBoxColumn.Name = "totalSLDataGridViewTextBoxColumn";
            this.totalSLDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSLDataGridViewTextBoxColumn.Visible = false;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(BLL.Personal);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 436);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "File Attachment";
            // 
            // lblFileAttachment
            // 
            this.lblFileAttachment.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblFileAttachment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileAttachment.Location = new System.Drawing.Point(107, 432);
            this.lblFileAttachment.Name = "lblFileAttachment";
            this.lblFileAttachment.Size = new System.Drawing.Size(535, 20);
            this.lblFileAttachment.TabIndex = 41;
            // 
            // btnAttachment
            // 
            this.btnAttachment.BackColor = System.Drawing.Color.White;
            this.btnAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachment.ForeColor = System.Drawing.Color.Black;
            this.btnAttachment.Image = global::Payroll.Properties.Resources.Open_in_Browser_20px1;
            this.btnAttachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttachment.Location = new System.Drawing.Point(646, 432);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(30, 20);
            this.btnAttachment.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btnAttachment, "Attache File");
            this.btnAttachment.UseVisualStyleBackColor = false;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // picEmployee
            // 
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEmployee.Location = new System.Drawing.Point(507, 70);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(150, 150);
            this.picEmployee.TabIndex = 39;
            this.picEmployee.TabStop = false;
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.White;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.ForeColor = System.Drawing.Color.Black;
            this.btnCLose.Image = global::Payroll.Properties.Resources.Close_Window_20px;
            this.btnCLose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCLose.Location = new System.Drawing.Point(434, 457);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(157, 23);
            this.btnCLose.TabIndex = 30;
            this.btnCLose.Text = "C&lose";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::Payroll.Properties.Resources.Refresh_20px2;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(270, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "&Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::Payroll.Properties.Resources.Save_20px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(107, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lnkShow
            // 
            this.lnkShow.BackColor = System.Drawing.Color.Transparent;
            this.lnkShow.Enabled = false;
            this.lnkShow.Location = new System.Drawing.Point(604, 433);
            this.lnkShow.Name = "lnkShow";
            this.lnkShow.Size = new System.Drawing.Size(34, 16);
            this.lnkShow.TabIndex = 43;
            this.lnkShow.TabStop = true;
            this.lnkShow.Text = "Show";
            this.lnkShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShow_LinkClicked);
            // 
            // frmLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(684, 485);
            this.Controls.Add(this.lnkShow);
            this.Controls.Add(this.btnAttachment);
            this.Controls.Add(this.lblFileAttachment);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dgvEmpList);
            this.Controls.Add(this.picEmployee);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtPL);
            this.Controls.Add(this.txtCL);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCauseofLeave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.txtTotalLeave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbTypeofLeave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtEntryDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpSearchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave";
            this.Load += new System.EventHandler(this.frmLeave_Load);
            this.grpSearchbox.ResumeLayout(false);
            this.grpSearchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindCode;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSearchbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtEntryDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTypeofLeave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalLeave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.TextBox txtCauseofLeave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCL;
        private System.Windows.Forms.TextBox txtPL;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.DateTimePicker dtStartingYear;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvEmpList;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAssignDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGruopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblFileAttachment;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.LinkLabel lnkShow;
    }
}