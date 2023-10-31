namespace Payroll
{
    partial class frmAddEdit
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStartingYear = new System.Windows.Forms.DateTimePicker();
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
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(55, 46);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(228, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(504, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(593, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
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
            this.totalLWPDataGridViewTextBoxColumn,
            this.advanceDataGridViewTextBoxColumn,
            this.maternityDataGridViewTextBoxColumn,
            this.remainingCLDataGridViewTextBoxColumn,
            this.remainingPLDataGridViewTextBoxColumn,
            this.remainingSLDataGridViewTextBoxColumn});
            this.dgvEmployeeList.DataSource = this.personalBindingSource;
            this.dgvEmployeeList.Location = new System.Drawing.Point(55, 159);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeList.Size = new System.Drawing.Size(504, 186);
            this.dgvEmployeeList.TabIndex = 5;
            this.dgvEmployeeList.Visible = false;
            this.dgvEmployeeList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEmployeeList_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Payroll.Properties.Resources.Close_Window_20px;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(224, 98);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Starting Year";
            // 
            // dtStartingYear
            // 
            this.dtStartingYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartingYear.Location = new System.Drawing.Point(362, 46);
            this.dtStartingYear.Name = "dtStartingYear";
            this.dtStartingYear.Size = new System.Drawing.Size(197, 20);
            this.dtStartingYear.TabIndex = 10;
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
            this.empNameDataGridViewTextBoxColumn.HeaderText = "Emplyee Name";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNameDataGridViewTextBoxColumn.Width = 150;
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
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Image = global::Payroll.Properties.Resources.Open_in_Browser_20px;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(55, 98);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(166, 23);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(593, 357);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.dtStartingYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Employee";
            this.Load += new System.EventHandler(this.frmAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtStartingYear;
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