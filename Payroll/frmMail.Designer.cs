namespace Payroll
{
    partial class frmMail
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
            this.lstMailList = new System.Windows.Forms.ListBox();
            this.pnlLeftbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.lblColorShow = new System.Windows.Forms.Label();
            this.rtxBody = new System.Windows.Forms.RichTextBox();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlLeftbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMailList
            // 
            this.lstMailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMailList.FormattingEnabled = true;
            this.lstMailList.Location = new System.Drawing.Point(0, 0);
            this.lstMailList.Name = "lstMailList";
            this.lstMailList.Size = new System.Drawing.Size(163, 462);
            this.lstMailList.TabIndex = 1;
            this.lstMailList.SelectedIndexChanged += new System.EventHandler(this.lstMailList_SelectedIndexChanged);
            this.lstMailList.DoubleClick += new System.EventHandler(this.lstMailList_DoubleClick);
            // 
            // pnlLeftbar
            // 
            this.pnlLeftbar.Controls.Add(this.lstMailList);
            this.pnlLeftbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftbar.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftbar.Name = "pnlLeftbar";
            this.pnlLeftbar.Size = new System.Drawing.Size(163, 462);
            this.pnlLeftbar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mail Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.lblAttachment);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblColorShow);
            this.panel1.Controls.Add(this.rtxBody);
            this.panel1.Controls.Add(this.txtAttachment);
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(163, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 462);
            this.panel1.TabIndex = 5;
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.Location = new System.Drawing.Point(44, 222);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(30, 25);
            this.lblAttachment.TabIndex = 18;
            this.lblAttachment.Text = "...";
            this.toolTip1.SetToolTip(this.lblAttachment, "Attachment");
            this.lblAttachment.Click += new System.EventHandler(this.lblAttachment_Click);
            // 
            // lblColorShow
            // 
            this.lblColorShow.BackColor = System.Drawing.Color.White;
            this.lblColorShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorShow.Location = new System.Drawing.Point(57, 308);
            this.lblColorShow.Name = "lblColorShow";
            this.lblColorShow.Size = new System.Drawing.Size(15, 15);
            this.lblColorShow.TabIndex = 16;
            this.lblColorShow.Click += new System.EventHandler(this.lblColorShow_Click);
            // 
            // rtxBody
            // 
            this.rtxBody.Location = new System.Drawing.Point(83, 278);
            this.rtxBody.Name = "rtxBody";
            this.rtxBody.Size = new System.Drawing.Size(378, 152);
            this.rtxBody.TabIndex = 15;
            this.rtxBody.Text = "";
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(83, 197);
            this.txtAttachment.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtAttachment.Multiline = true;
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.ReadOnly = true;
            this.txtAttachment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAttachment.Size = new System.Drawing.Size(379, 72);
            this.txtAttachment.TabIndex = 14;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(83, 171);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(379, 20);
            this.txtSubject.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(379, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(83, 76);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTo.Size = new System.Drawing.Size(379, 63);
            this.txtTo.TabIndex = 11;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(83, 50);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(379, 20);
            this.txtFrom.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Attachment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            this.OFD.Multiselect = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Payroll.Properties.Resources.Close_Window_20px;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(278, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 26);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Image = global::Payroll.Properties.Resources.Send_Email1_20px_;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(83, 432);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(183, 26);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeftbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.pnlLeftbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstMailList;
        private System.Windows.Forms.Panel pnlLeftbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxBody;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblColorShow;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}