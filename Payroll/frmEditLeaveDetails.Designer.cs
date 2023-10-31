namespace Payroll
{
    partial class frmEditLeaveDetails
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
            this.dgvLeaveDetails = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveDetailsExtraInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpCurrentYear = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStarttingYear = new System.Windows.Forms.DateTimePicker();
            this.optRangeYear = new System.Windows.Forms.RadioButton();
            this.grpDateRange = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.optCurrentYear = new System.Windows.Forms.RadioButton();
            this.lDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonofLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attachements = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDetailsExtraInfoBindingSource)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCurrentYear.SuspendLayout();
            this.grpDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLeaveDetails
            // 
            this.dgvLeaveDetails.AllowUserToAddRows = false;
            this.dgvLeaveDetails.AllowUserToDeleteRows = false;
            this.dgvLeaveDetails.AutoGenerateColumns = false;
            this.dgvLeaveDetails.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvLeaveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lDIDDataGridViewTextBoxColumn,
            this.empCodeDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.leaveTypeDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.totalLeaveDataGridViewTextBoxColumn,
            this.reasonofLeaveDataGridViewTextBoxColumn,
            this.FileName,
            this.Attachements});
            this.dgvLeaveDetails.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLeaveDetails.DataSource = this.leaveDetailsExtraInfoBindingSource;
            this.dgvLeaveDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaveDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvLeaveDetails.Name = "dgvLeaveDetails";
            this.dgvLeaveDetails.ReadOnly = true;
            this.dgvLeaveDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveDetails.Size = new System.Drawing.Size(784, 420);
            this.dgvLeaveDetails.TabIndex = 1;
            this.dgvLeaveDetails.DoubleClick += new System.EventHandler(this.dgvLeaveDetails_DoubleClick);
            this.dgvLeaveDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvLeaveDetails_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxEdit,
            this.cntxDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // cntxEdit
            // 
            this.cntxEdit.Name = "cntxEdit";
            this.cntxEdit.Size = new System.Drawing.Size(107, 22);
            this.cntxEdit.Text = "&Edit";
            this.cntxEdit.Click += new System.EventHandler(this.cntxEdit_Click);
            // 
            // cntxDelete
            // 
            this.cntxDelete.Name = "cntxDelete";
            this.cntxDelete.Size = new System.Drawing.Size(107, 22);
            this.cntxDelete.Text = "&Delete";
            this.cntxDelete.Click += new System.EventHandler(this.cntxDelete_Click);
            // 
            // leaveDetailsExtraInfoBindingSource
            // 
            this.leaveDetailsExtraInfoBindingSource.DataSource = typeof(BLL.LeaveDetailsExtraInfo);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.dgvLeaveDetails);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 142);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(784, 420);
            this.pnlBottom.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.grpCurrentYear);
            this.groupBox1.Controls.Add(this.optRangeYear);
            this.groupBox1.Controls.Add(this.grpDateRange);
            this.groupBox1.Controls.Add(this.optCurrentYear);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Payroll.Properties.Resources.Close_Window_20px;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(609, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 27);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = global::Payroll.Properties.Resources.Pencil_Drawing_20px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(445, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 27);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpCurrentYear
            // 
            this.grpCurrentYear.Controls.Add(this.label4);
            this.grpCurrentYear.Controls.Add(this.dtStarttingYear);
            this.grpCurrentYear.Location = new System.Drawing.Point(114, 6);
            this.grpCurrentYear.Name = "grpCurrentYear";
            this.grpCurrentYear.Size = new System.Drawing.Size(256, 46);
            this.grpCurrentYear.TabIndex = 12;
            this.grpCurrentYear.TabStop = false;
            this.grpCurrentYear.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Starting Date";
            // 
            // dtStarttingYear
            // 
            this.dtStarttingYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStarttingYear.Location = new System.Drawing.Point(108, 18);
            this.dtStarttingYear.Name = "dtStarttingYear";
            this.dtStarttingYear.Size = new System.Drawing.Size(119, 20);
            this.dtStarttingYear.TabIndex = 5;
            // 
            // optRangeYear
            // 
            this.optRangeYear.AutoSize = true;
            this.optRangeYear.Location = new System.Drawing.Point(24, 41);
            this.optRangeYear.Name = "optRangeYear";
            this.optRangeYear.Size = new System.Drawing.Size(82, 17);
            this.optRangeYear.TabIndex = 10;
            this.optRangeYear.Text = "Range Year";
            this.optRangeYear.UseVisualStyleBackColor = true;
            this.optRangeYear.CheckedChanged += new System.EventHandler(this.optRangeYear_CheckedChanged);
            // 
            // grpDateRange
            // 
            this.grpDateRange.Controls.Add(this.btnLoad);
            this.grpDateRange.Controls.Add(this.label2);
            this.grpDateRange.Controls.Add(this.dtFrom);
            this.grpDateRange.Controls.Add(this.dtTo);
            this.grpDateRange.Controls.Add(this.label3);
            this.grpDateRange.Enabled = false;
            this.grpDateRange.Location = new System.Drawing.Point(24, 58);
            this.grpDateRange.Name = "grpDateRange";
            this.grpDateRange.Size = new System.Drawing.Size(394, 69);
            this.grpDateRange.TabIndex = 11;
            this.grpDateRange.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Image = global::Payroll.Properties.Resources.Refresh_20px2;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(184, 35);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(204, 28);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(59, 18);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(119, 20);
            this.dtFrom.TabIndex = 5;
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(59, 43);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(119, 20);
            this.dtTo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "To";
            // 
            // optCurrentYear
            // 
            this.optCurrentYear.AutoSize = true;
            this.optCurrentYear.Checked = true;
            this.optCurrentYear.Location = new System.Drawing.Point(24, 18);
            this.optCurrentYear.Name = "optCurrentYear";
            this.optCurrentYear.Size = new System.Drawing.Size(84, 17);
            this.optCurrentYear.TabIndex = 9;
            this.optCurrentYear.TabStop = true;
            this.optCurrentYear.Text = "Current Year";
            this.optCurrentYear.UseVisualStyleBackColor = true;
            this.optCurrentYear.CheckedChanged += new System.EventHandler(this.optCurrentYear_CheckedChanged);
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
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "Employe Name";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // leaveTypeDataGridViewTextBoxColumn
            // 
            this.leaveTypeDataGridViewTextBoxColumn.DataPropertyName = "LeaveType";
            this.leaveTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.leaveTypeDataGridViewTextBoxColumn.Name = "leaveTypeDataGridViewTextBoxColumn";
            this.leaveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "From Date";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            this.fromDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "To Date";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            this.toDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalLeaveDataGridViewTextBoxColumn
            // 
            this.totalLeaveDataGridViewTextBoxColumn.DataPropertyName = "TotalLeave";
            this.totalLeaveDataGridViewTextBoxColumn.HeaderText = "Total Leave";
            this.totalLeaveDataGridViewTextBoxColumn.Name = "totalLeaveDataGridViewTextBoxColumn";
            this.totalLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonofLeaveDataGridViewTextBoxColumn
            // 
            this.reasonofLeaveDataGridViewTextBoxColumn.DataPropertyName = "ReasonofLeave";
            this.reasonofLeaveDataGridViewTextBoxColumn.HeaderText = "Reason of Leave";
            this.reasonofLeaveDataGridViewTextBoxColumn.Name = "reasonofLeaveDataGridViewTextBoxColumn";
            this.reasonofLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonofLeaveDataGridViewTextBoxColumn.Width = 120;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Visible = false;
            // 
            // Attachements
            // 
            this.Attachements.DataPropertyName = "Attachements";
            this.Attachements.HeaderText = "Attachements";
            this.Attachements.Name = "Attachements";
            this.Attachements.ReadOnly = true;
            this.Attachements.Visible = false;
            // 
            // frmEditLeaveDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditLeaveDetails";
            this.Text = "Open Leave";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEditLeaveDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaveDetailsExtraInfoBindingSource)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCurrentYear.ResumeLayout(false);
            this.grpCurrentYear.PerformLayout();
            this.grpDateRange.ResumeLayout(false);
            this.grpDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLeaveDetails;
        private System.Windows.Forms.BindingSource leaveDetailsExtraInfoBindingSource;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpCurrentYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtStarttingYear;
        private System.Windows.Forms.RadioButton optRangeYear;
        private System.Windows.Forms.GroupBox grpDateRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton optCurrentYear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntxEdit;
        private System.Windows.Forms.ToolStripMenuItem cntxDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
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