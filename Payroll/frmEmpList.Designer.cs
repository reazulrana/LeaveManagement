namespace Payroll
{
    partial class frmEmpList
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
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
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
            this.TotalLWP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maternity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxAddNewLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxEditPersonalInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxReport = new System.Windows.Forms.ToolStripMenuItem();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.cntxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.AutoGenerateColumns = false;
            this.dgvEmployeeList.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.TotalLWP,
            this.Advance,
            this.Maternity,
            this.RemainingCL,
            this.RemainingPL,
            this.RemainingSL});
            this.dgvEmployeeList.ContextMenuStrip = this.cntxMenu;
            this.dgvEmployeeList.DataSource = this.personalBindingSource;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeList.Size = new System.Drawing.Size(784, 509);
            this.dgvEmployeeList.TabIndex = 0;
            this.dgvEmployeeList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmployeeList_DataBindingComplete);
            this.dgvEmployeeList.DoubleClick += new System.EventHandler(this.dgvEmployeeList_DoubleClick);
            this.dgvEmployeeList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvEmployeeList_MouseUp);
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
            this.empNameDataGridViewTextBoxColumn.Width = 220;
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
            this.photoDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            this.photoDataGridViewImageColumn.Visible = false;
            // 
            // totalCLDataGridViewTextBoxColumn
            // 
            this.totalCLDataGridViewTextBoxColumn.DataPropertyName = "TotalCL";
            this.totalCLDataGridViewTextBoxColumn.HeaderText = "CL";
            this.totalCLDataGridViewTextBoxColumn.Name = "totalCLDataGridViewTextBoxColumn";
            this.totalCLDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCLDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalPLDataGridViewTextBoxColumn
            // 
            this.totalPLDataGridViewTextBoxColumn.DataPropertyName = "TotalPL";
            this.totalPLDataGridViewTextBoxColumn.HeaderText = "PL";
            this.totalPLDataGridViewTextBoxColumn.Name = "totalPLDataGridViewTextBoxColumn";
            this.totalPLDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPLDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalSLDataGridViewTextBoxColumn
            // 
            this.totalSLDataGridViewTextBoxColumn.DataPropertyName = "TotalSL";
            this.totalSLDataGridViewTextBoxColumn.HeaderText = "SL";
            this.totalSLDataGridViewTextBoxColumn.Name = "totalSLDataGridViewTextBoxColumn";
            this.totalSLDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSLDataGridViewTextBoxColumn.Width = 60;
            // 
            // TotalLWP
            // 
            this.TotalLWP.DataPropertyName = "TotalLWP";
            this.TotalLWP.HeaderText = "LWP";
            this.TotalLWP.Name = "TotalLWP";
            this.TotalLWP.ReadOnly = true;
            // 
            // Advance
            // 
            this.Advance.DataPropertyName = "Advance";
            this.Advance.HeaderText = "Advance";
            this.Advance.Name = "Advance";
            this.Advance.ReadOnly = true;
            // 
            // Maternity
            // 
            this.Maternity.DataPropertyName = "Maternity";
            this.Maternity.HeaderText = "Maternity";
            this.Maternity.Name = "Maternity";
            this.Maternity.ReadOnly = true;
            // 
            // RemainingCL
            // 
            this.RemainingCL.DataPropertyName = "RemainingCL";
            this.RemainingCL.HeaderText = "Rem.CL";
            this.RemainingCL.Name = "RemainingCL";
            this.RemainingCL.ReadOnly = true;
            // 
            // RemainingPL
            // 
            this.RemainingPL.DataPropertyName = "RemainingPL";
            this.RemainingPL.HeaderText = "Rem.PL";
            this.RemainingPL.Name = "RemainingPL";
            this.RemainingPL.ReadOnly = true;
            // 
            // RemainingSL
            // 
            this.RemainingSL.DataPropertyName = "RemainingSL";
            this.RemainingSL.HeaderText = "Rem.SL";
            this.RemainingSL.Name = "RemainingSL";
            this.RemainingSL.ReadOnly = true;
            // 
            // cntxMenu
            // 
            this.cntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxAddNewLeave,
            this.cntxEditPersonalInformation,
            this.cntxDeleteEmployee,
            this.cntxReport});
            this.cntxMenu.Name = "cntxMenu";
            this.cntxMenu.Size = new System.Drawing.Size(209, 92);
            // 
            // cntxAddNewLeave
            // 
            this.cntxAddNewLeave.Name = "cntxAddNewLeave";
            this.cntxAddNewLeave.Size = new System.Drawing.Size(208, 22);
            this.cntxAddNewLeave.Text = "&Add New Leave";
            this.cntxAddNewLeave.Click += new System.EventHandler(this.cntxAddNewLeave_Click);
            // 
            // cntxEditPersonalInformation
            // 
            this.cntxEditPersonalInformation.Name = "cntxEditPersonalInformation";
            this.cntxEditPersonalInformation.Size = new System.Drawing.Size(208, 22);
            this.cntxEditPersonalInformation.Text = "&Edit Personal Information";
            this.cntxEditPersonalInformation.Click += new System.EventHandler(this.cntxEditPersonalInformation_Click);
            // 
            // cntxDeleteEmployee
            // 
            this.cntxDeleteEmployee.Name = "cntxDeleteEmployee";
            this.cntxDeleteEmployee.Size = new System.Drawing.Size(208, 22);
            this.cntxDeleteEmployee.Text = "&Delete Employee";
            this.cntxDeleteEmployee.Click += new System.EventHandler(this.cntxDeleteEmployee_Click);
            // 
            // cntxReport
            // 
            this.cntxReport.Name = "cntxReport";
            this.cntxReport.Size = new System.Drawing.Size(208, 22);
            this.cntxReport.Text = "&Report";
            this.cntxReport.Click += new System.EventHandler(this.cntxReport_Click);
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(BLL.Personal);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEmployeeList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 509);
            this.panel1.TabIndex = 1;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(67, 22);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(170, 20);
            this.dtFrom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.dtFrom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 53);
            this.panel2.TabIndex = 7;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Image = global::Payroll.Properties.Resources.Expand_Arrow_32px;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(416, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(149, 25);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Image = global::Payroll.Properties.Resources.Refresh_20px2;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(261, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 25);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmEmpList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.cntxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cntxMenu;
        private System.Windows.Forms.ToolStripMenuItem cntxAddNewLeave;
        private System.Windows.Forms.ToolStripMenuItem cntxEditPersonalInformation;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ToolStripMenuItem cntxDeleteEmployee;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLWP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maternity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingSL;
        private System.Windows.Forms.ToolStripMenuItem cntxReport;
    }
}