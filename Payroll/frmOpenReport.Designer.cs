namespace Payroll
{
    partial class frmOpenReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optCurrentYear = new System.Windows.Forms.RadioButton();
            this.optDateRange = new System.Windows.Forms.RadioButton();
            this.grpEmpID = new System.Windows.Forms.GroupBox();
            this.txtFindID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvEmpList = new System.Windows.Forms.DataGridView();
            this.grpEmpName = new System.Windows.Forms.GroupBox();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.totalLWPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maternityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingCLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingSLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.grpEmpID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).BeginInit();
            this.grpEmpName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(57, 13);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(173, 20);
            this.dtFrom.TabIndex = 2;
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(265, 13);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(173, 20);
            this.dtTo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // optCurrentYear
            // 
            this.optCurrentYear.AutoSize = true;
            this.optCurrentYear.Checked = true;
            this.optCurrentYear.Location = new System.Drawing.Point(12, 12);
            this.optCurrentYear.Name = "optCurrentYear";
            this.optCurrentYear.Size = new System.Drawing.Size(84, 17);
            this.optCurrentYear.TabIndex = 5;
            this.optCurrentYear.TabStop = true;
            this.optCurrentYear.Text = "Current Year";
            this.optCurrentYear.UseVisualStyleBackColor = true;
            // 
            // optDateRange
            // 
            this.optDateRange.AutoSize = true;
            this.optDateRange.Location = new System.Drawing.Point(13, 35);
            this.optDateRange.Name = "optDateRange";
            this.optDateRange.Size = new System.Drawing.Size(83, 17);
            this.optDateRange.TabIndex = 6;
            this.optDateRange.Text = "Date Range";
            this.optDateRange.UseVisualStyleBackColor = true;
            // 
            // grpEmpID
            // 
            this.grpEmpID.Controls.Add(this.txtFindID);
            this.grpEmpID.Controls.Add(this.label3);
            this.grpEmpID.Location = new System.Drawing.Point(12, 94);
            this.grpEmpID.Name = "grpEmpID";
            this.grpEmpID.Size = new System.Drawing.Size(446, 39);
            this.grpEmpID.TabIndex = 5;
            this.grpEmpID.TabStop = false;
            // 
            // txtFindID
            // 
            this.txtFindID.Location = new System.Drawing.Point(73, 13);
            this.txtFindID.Name = "txtFindID";
            this.txtFindID.Size = new System.Drawing.Size(367, 20);
            this.txtFindID.TabIndex = 1;
            this.txtFindID.TextChanged += new System.EventHandler(this.txtFindID_TextChanged);
            this.txtFindID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Find ID";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(84, 178);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(158, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(245, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvEmpList
            // 
            this.dgvEmpList.AllowUserToAddRows = false;
            this.dgvEmpList.AllowUserToDeleteRows = false;
            this.dgvEmpList.AutoGenerateColumns = false;
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
            this.totalSLDataGridViewTextBoxColumn,
            this.totalLWPDataGridViewTextBoxColumn,
            this.advanceDataGridViewTextBoxColumn,
            this.maternityDataGridViewTextBoxColumn,
            this.remainingCLDataGridViewTextBoxColumn,
            this.remainingPLDataGridViewTextBoxColumn,
            this.remainingSLDataGridViewTextBoxColumn});
            this.dgvEmpList.DataSource = this.personalBindingSource;
            this.dgvEmpList.Location = new System.Drawing.Point(42, 193);
            this.dgvEmpList.Name = "dgvEmpList";
            this.dgvEmpList.ReadOnly = true;
            this.dgvEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpList.Size = new System.Drawing.Size(446, 115);
            this.dgvEmpList.TabIndex = 9;
            this.dgvEmpList.Visible = false;
            this.dgvEmpList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmpList_DataBindingComplete);
            this.dgvEmpList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEmpList_KeyDown);
            // 
            // grpEmpName
            // 
            this.grpEmpName.Controls.Add(this.txtFindName);
            this.grpEmpName.Controls.Add(this.label4);
            this.grpEmpName.Location = new System.Drawing.Point(12, 133);
            this.grpEmpName.Name = "grpEmpName";
            this.grpEmpName.Size = new System.Drawing.Size(446, 39);
            this.grpEmpName.TabIndex = 6;
            this.grpEmpName.TabStop = false;
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(73, 13);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(367, 20);
            this.txtFindName.TabIndex = 1;
            this.txtFindName.TextChanged += new System.EventHandler(this.txtFindName_TextChanged);
            this.txtFindName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Find Name";
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
            this.empCodeDataGridViewTextBoxColumn.HeaderText = "Employee ID";
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
            // totalLWPDataGridViewTextBoxColumn
            // 
            this.totalLWPDataGridViewTextBoxColumn.DataPropertyName = "TotalLWP";
            this.totalLWPDataGridViewTextBoxColumn.HeaderText = "TotalLWP";
            this.totalLWPDataGridViewTextBoxColumn.Name = "totalLWPDataGridViewTextBoxColumn";
            this.totalLWPDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalLWPDataGridViewTextBoxColumn.Visible = false;
            // 
            // advanceDataGridViewTextBoxColumn
            // 
            this.advanceDataGridViewTextBoxColumn.DataPropertyName = "Advance";
            this.advanceDataGridViewTextBoxColumn.HeaderText = "Advance";
            this.advanceDataGridViewTextBoxColumn.Name = "advanceDataGridViewTextBoxColumn";
            this.advanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.advanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // maternityDataGridViewTextBoxColumn
            // 
            this.maternityDataGridViewTextBoxColumn.DataPropertyName = "Maternity";
            this.maternityDataGridViewTextBoxColumn.HeaderText = "Maternity";
            this.maternityDataGridViewTextBoxColumn.Name = "maternityDataGridViewTextBoxColumn";
            this.maternityDataGridViewTextBoxColumn.ReadOnly = true;
            this.maternityDataGridViewTextBoxColumn.Visible = false;
            // 
            // remainingCLDataGridViewTextBoxColumn
            // 
            this.remainingCLDataGridViewTextBoxColumn.DataPropertyName = "RemainingCL";
            this.remainingCLDataGridViewTextBoxColumn.HeaderText = "RemainingCL";
            this.remainingCLDataGridViewTextBoxColumn.Name = "remainingCLDataGridViewTextBoxColumn";
            this.remainingCLDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainingCLDataGridViewTextBoxColumn.Visible = false;
            // 
            // remainingPLDataGridViewTextBoxColumn
            // 
            this.remainingPLDataGridViewTextBoxColumn.DataPropertyName = "RemainingPL";
            this.remainingPLDataGridViewTextBoxColumn.HeaderText = "RemainingPL";
            this.remainingPLDataGridViewTextBoxColumn.Name = "remainingPLDataGridViewTextBoxColumn";
            this.remainingPLDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainingPLDataGridViewTextBoxColumn.Visible = false;
            // 
            // remainingSLDataGridViewTextBoxColumn
            // 
            this.remainingSLDataGridViewTextBoxColumn.DataPropertyName = "RemainingSL";
            this.remainingSLDataGridViewTextBoxColumn.HeaderText = "RemainingSL";
            this.remainingSLDataGridViewTextBoxColumn.Name = "remainingSLDataGridViewTextBoxColumn";
            this.remainingSLDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainingSLDataGridViewTextBoxColumn.Visible = false;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(BLL.Personal);
            // 
            // frmOpenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(475, 263);
            this.Controls.Add(this.dgvEmpList);
            this.Controls.Add(this.grpEmpName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.grpEmpID);
            this.Controls.Add(this.optDateRange);
            this.Controls.Add(this.optCurrentYear);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpenReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Report";
            this.Load += new System.EventHandler(this.frmOpenReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpEmpID.ResumeLayout(false);
            this.grpEmpID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).EndInit();
            this.grpEmpName.ResumeLayout(false);
            this.grpEmpName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optCurrentYear;
        private System.Windows.Forms.RadioButton optDateRange;
        private System.Windows.Forms.GroupBox grpEmpID;
        private System.Windows.Forms.TextBox txtFindID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvEmpList;
        private System.Windows.Forms.GroupBox grpEmpName;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource personalBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLWPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maternityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingCLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingSLDataGridViewTextBoxColumn;
    }
}