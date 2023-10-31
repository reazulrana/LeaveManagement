using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Payroll.InterfacerLibrary;
using ImageLibrary;
using Payroll.Properties;
using Payroll;
namespace Payroll
{
    public partial class frmLeave : Form
    {


        enum FindType
        {
            Code,
            Name

        }

        LeaveDetails _model;
        Personal _personal;
        RecordTypes _recordType;
        IRefreshEmpList _IrefreshempList;


        int PreserveLeave = 0;

        Image imgAttachment; // To Store Attachment File


        public frmLeave()
        {
            InitializeComponent();
            picEmployee.Image = Resources.portrait_blank_male;
            _recordType = RecordTypes.Add;
            dtStartingYear.Value = Convert.ToDateTime(DateRange.StartDate);
        }


        //its used for Update LeaveDetails
        public frmLeave(LeaveDetails model, IRefreshEmpList irefreshEmplist, RecordTypes rt)
        {
            InitializeComponent();
            picEmployee.Image = Resources.portrait_blank_male;
            _recordType = rt;
            _model = model;
            btnSave.Text = "&Update";
            this.Text = "Update Leave Details";
            PreserveLeave = _model.TotalLeave;//Hold Previous LeaveQty
            _IrefreshempList = irefreshEmplist;



            dtStartingYear.Value = DateRange.StartDate;

            

           Personal P = GlobalConfig.iDataConnection.GetAllEmployees(DateRange.StartDate, DateRange.EndtDate).Where(x => x.EmpCode.ToLower() == _model.EmpCode.ToLower()).Single();
            GetInformation(P);
        }


        //its used for Add New LeaveDetails
        public frmLeave(Personal model, IRefreshEmpList iRefreshemplist, RecordTypes rt)
        {
            InitializeComponent();
            picEmployee.Image = Resources.portrait_blank_male;
            dtStartingYear.Value = DateTime.Now;
            dtStartingYear.Value = Convert.ToDateTime("01-Jan" + dtStartingYear.Value.Year);
         
            _recordType = rt;
            _personal = model;
            _IrefreshempList = iRefreshemplist;
            DisabledField();
            GetInformation(_personal);
        }



        private void frmLeave_Load(object sender, EventArgs e)
        {



            if (_recordType == RecordTypes.Update)
            {
                DisabledField();    //if edit mode fire then method will call
            }




        }

        //if edit mode fire then method will call
        //Set Form LoadEvent;
        private void DisabledField()
        {
            txtFindCode.Enabled = false;
            txtFindName.Enabled = false;
            dtStartingYear.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Tuple<bool, string> _IsvalidLeave = IsvalidLeave();

                if (_recordType == RecordTypes.Add)
                {
                    if (_IsvalidLeave.Item1 == false)
                    {

                        MessageBox.Show(_IsvalidLeave.Item2 + " Leave is Exceeded the Limit", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTotalLeave.Select();
                        return;
                    }
                }

                if (_recordType == RecordTypes.Update)
                {
                    if (cmbTypeofLeave.Text.ToLower() == "CL".ToLower())
                    {
                        if (int.Parse(txtCL.Text) < 0)
                        {
                            MessageBox.Show("CL Leave is Negetive Value");
                            txtTotalLeave.Select();
                            return;
                        }
                        else if (int.Parse(txtPL.Text) < 0)
                        {
                            MessageBox.Show("PL Leave is Negetive Value");
                            txtTotalLeave.Select();
                            return;
                        }
                        else if (int.Parse(txtSL.Text) < 0)
                        {
                            MessageBox.Show("SL Leave is Negetive Value");
                            txtTotalLeave.Select();
                            return;
                        }
                    }
                }






                LeaveDetails _leaveDetails = new LeaveDetails();

                if (cmbTypeofLeave.Text.Length <= 0)
                {
                    MessageBox.Show("LeaveType field is required");
                    cmbTypeofLeave.Select();
                    return;
                }


                if (txtTotalLeave.Text.Length <= 0 || txtTotalLeave.Text == "0")
                {
                    MessageBox.Show("Leave field is set 0");
                    txtTotalLeave.Select();
                    return;
                }


                _leaveDetails.EmpCode = txtEmpCode.Text;
                _leaveDetails.EntryDate = dtEntryDate.Value;
                _leaveDetails.LeaveType = cmbTypeofLeave.Text;
                _leaveDetails.FromDate = dtFrom.Value;
                _leaveDetails.ToDate = dtTo.Value;
                _leaveDetails.TotalLeave = Convert.ToInt32(txtTotalLeave.Text);
                _leaveDetails.ReasonofLeave = txtCauseofLeave.Text;
                _leaveDetails.Attachements = null;
                _leaveDetails.FileName = lblFileAttachment.Text;
                if (lblFileAttachment.Text.Length > 0)
                {
                  
                    _leaveDetails.Attachements = ImageLibrary.CustomImage.ConvertImageToBinary(imgAttachment, 50);
                }


                if (_recordType == RecordTypes.Add)
                {
                    GlobalConfig.iDataConnection.CreateLeaveDetails(_leaveDetails);
                    MessageBox.Show("Record Save Successfully", "Insert Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    if (_IrefreshempList != null)
                    {
                        _IrefreshempList.RefreshEmpList();

                    }

                }
                if (_recordType == RecordTypes.Update)
                {
                    _leaveDetails.LDID = _model.LDID;
                    GlobalConfig.iDataConnection.UpdateLeaveDetails(_leaveDetails);
                    MessageBox.Show("Record Save Successfully", "Insert Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    if (_IrefreshempList != null)
                    {
                        _IrefreshempList.RefreshEmpList();

                    }

                }


                //_personal





                this.Close();
            }
            catch (Exception ex)
            {
                GlobalConfig.iDataConnection.ErrorMessage(ex);
            }
        }

        private Tuple<bool, string> IsvalidLeave()
        {


            bool b = true;
            string msg = "";
            if (cmbTypeofLeave.Text.ToLower() == "CL".ToLower())
            {
                if (Convert.ToInt32(txtTotalLeave.Text) > Convert.ToInt32(txtCL.Text))
                {
                    msg = "CL";
                    b = false;
                }
            }

            if (cmbTypeofLeave.Text.ToLower() == "PL".ToLower())
            {
                if (Convert.ToInt32(txtTotalLeave.Text) > Convert.ToInt32(txtPL.Text))
                {
                    msg = "PL";
                    b = false;
                }
            }

            if (cmbTypeofLeave.Text.ToLower() == "SL".ToLower())
            {
                if (Convert.ToInt32(txtTotalLeave.Text) > Convert.ToInt32(txtSL.Text))
                {
                    msg = "SL";
                    b = false;
                }
            }

            Tuple<bool, string> t = Tuple.Create(b, msg);
            return t;
        }

        private void cmbTypeofLeave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void txtFindCode_TextChanged(object sender, EventArgs e)
        {

            if (txtFindCode.Text.Length == 0)
            {
                dgvEmpList.DataSource = null;
                dgvEmpList.Visible = false;

                dgvEmpList.Location = new Point(txtFindCode.Left, grpSearchbox.Top + grpSearchbox.Height + 1);
            }
            else
            {
                dgvEmpList.Visible = true;
                dgvEmpList.Location = new Point(txtFindCode.Left, grpSearchbox.Top + grpSearchbox.Height + 1);
                BindDataGrid(FindType.Code);
            }
        }
        void BindDataGrid(FindType _findtype)
        {

            List<Personal> _personal = new List<Personal>();
            _personal = GlobalConfig.iDataConnection.GetAllEmployees(DateRange.StartDate, DateRange.EndtDate);
            if (_findtype == FindType.Code)
            {
                _personal = _personal.Where(x => x.EmpCode.ToLower().Contains(txtFindCode.Text.ToLower())).ToList();
            }
            if (_findtype == FindType.Name)
            {
                _personal = _personal.Where(x => x.EmpName.ToLower().Contains(txtFindName.Text.ToLower())).ToList();
            }

            dgvEmpList.DataSource = null;
            dgvEmpList.DataSource = _personal;

        }
        private void txtFindName_TextChanged(object sender, EventArgs e)
        {
            if (txtFindName.Text.Length == 0)
            {
                dgvEmpList.DataSource = null;
                dgvEmpList.Visible = false;
            }
            else
            {
                dgvEmpList.Visible = true;
                dgvEmpList.Location = new Point(txtFindName.Left, grpSearchbox.Top + grpSearchbox.Height + 1);
                BindDataGrid(FindType.Name);
            }
        }


        private void SelectDatagrid()
        {
            if (dgvEmpList.Visible == true)
            {
                if (dgvEmpList.Rows.Count > 0)
                {
                    dgvEmpList.Select();
                    dgvEmpList.Rows[0].Selected = true;


                }
            }

        }

        private void txtFindCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SelectDatagrid();
            }
        }

        private void txtFindName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SelectDatagrid();
            }
        }

        private void dgvEmpList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvEmpList.SelectedRows.Count > 0)
                {
                    Personal _personal = dgvEmpList.SelectedRows[0].DataBoundItem as Personal;
                    txtFindCode.Text = _personal.EmpCode;
                    txtFindName.Text = _personal.EmpName;
                    dgvEmpList.Visible = false;
                    GetInformation(_personal);

                }
            }
        }

        void GetInformation(Personal p)
        {
            //picEmployee.Image = Resources.portrait_blank_male;
            txtEmpCode.Text = p.EmpCode;
            txtName.Text = p.EmpName;
            txtDesignation.Text = p.Designation;
            txtBranch.Text = p.Branch;
            txtCL.Text = p.RemainingCL.ToString();
            txtPL.Text = p.RemainingPL.ToString();
            txtSL.Text = p.RemainingSL.ToString();
            if (p.Photo != null)
            {
                picEmployee.Image = CustomImage.ConvertBinaryToImage(p.Photo);
            }

            if (_recordType == RecordTypes.Update) // Status is Update Mode Then Trigger
            {
                dtEntryDate.Value = _model.EntryDate;
                cmbTypeofLeave.Text = _model.LeaveType;
                dtFrom.Value = _model.FromDate;
                dtTo.Value = _model.ToDate;
                txtTotalLeave.Text = _model.TotalLeave.ToString();
                txtCauseofLeave.Text = _model.ReasonofLeave;
                if (!string.IsNullOrEmpty(_model.FileName))
                {
                    lblFileAttachment.Text = _model.FileName;
                    imgAttachment = CustomImage.ConvertBinaryToImage(_model.Attachements);
                    lnkShow.Enabled = true;
                }


            }


        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try { 
            ClearField();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearField()
        {
            txtTotalLeave.Text = "0";
            cmbTypeofLeave.Text = "";
            txtCauseofLeave.Text = "";

        }

        private void txtTotalLeave_KeyUp(object sender, KeyEventArgs e)
        {

            if (txtTotalLeave.Text.Length == 0)
            {
                return;
            }
            if (_recordType == RecordTypes.Update)
            {


                if (cmbTypeofLeave.Text.ToLower() == "CL".ToLower())
                {
                    txtCL.Text = (string)(Convert.ToInt32(txtCL.Text) - (Convert.ToInt32(txtTotalLeave.Text) - PreserveLeave)).ToString();
                }

                if (cmbTypeofLeave.Text.ToLower() == "PL".ToLower())
                {
                    txtPL.Text = (string)(Convert.ToInt32(txtPL.Text) - (Convert.ToInt32(txtTotalLeave.Text) - PreserveLeave)).ToString();
                }

                if (cmbTypeofLeave.Text.ToLower() == "SL".ToLower())
                {
                    txtSL.Text = (string)(Convert.ToInt32(txtSL.Text) - (Convert.ToInt32(txtTotalLeave.Text) - PreserveLeave)).ToString();
                }
            }
        }

        private void txtTotalLeave_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTotalLeave.Text.Length == 0)
            {
                return;
            }

            if (_recordType == RecordTypes.Update)
            {
                PreserveLeave = (int.Parse(txtTotalLeave.Text)); // Preserve Previous value of txtTotalLeave
            }
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            try
            {

                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                //imgAttachment = Image.FromFile("");
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    lblFileAttachment.Text = System.IO.Path.GetFileName(ofd.FileName);
                    imgAttachment = Image.FromFile(ofd.FileName);
                    
                    lnkShow.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmShowImage frm = new frmShowImage(imgAttachment))
            {
                frm.ShowDialog();
            }

        }
    }
}
