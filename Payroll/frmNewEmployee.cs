using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageLibrary;
using BLL;
using DAL;
using Payroll.InterfacerLibrary;
using Payroll.Properties;
using MyLibrary;
using Payroll;

namespace Payroll
{
    public partial class frmNewEmployee : Form, IRefreshEmpList
    {


 


        RecordTypes _recordType;
        private IRefreshEmpList _irefreshemplist;
        Personal _personal = new Personal();
        public frmNewEmployee()
        {
            InitializeComponent();
            _recordType = RecordTypes.Add;

            this.Size = new Size(700, 332);
            pnlBootm.Visible = false;

        }


        // Its Used for Update Employee Information
        public frmNewEmployee(Personal model, IRefreshEmpList Irefreshemplist,RecordTypes rt)
        {
            InitializeComponent();
            _recordType = rt;
            btnSave.Text = "Update";
            _personal = model;
            this.Text = "Update Employee Information";
            _irefreshemplist = Irefreshemplist;
            this.Size = new Size(700, 550);
            FilterLeave(); // this is called for update Leave Details Section;
            btnSave.Text = "&Update";
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try { 
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                    
                picEmpPhoto.Image = Image.FromFile(ofd.FileName);
               
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Open File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (isValid() == false)
            {
                MessageBox.Show("Code, Name, Designation, Branch Field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Personal personal = new Personal();

            personal.EmpCode = txtCode.Text;
            personal.EmpName = txtName.Text;
            personal.Designation = txtDesignation.Text;
            personal.Branch = txtBranch.Text;
            personal.Qualification = txtQualification.Text;
            if (chkBirthDate.Checked == true)
            {
                personal.DateOfBirth = dtBirthDate.Value;
            }
            if (chkAppointDate.Checked == true)
            {
                personal.AppointDate = dtAppontDate.Value;
            }

            personal.NIDNumber = txtNIDNumber.Text;
            if (chkIDCardAssignDate.Checked == true)
            {
                personal.IDAssignDate = dtIDCardAssignDate.Value;
            }
            personal.BloodGruop = txtBloodGroup.Text;
            if (chkJoiningDate.Checked == true)
            {
                personal.JoiningDate = dtJoiningDate.Value;
            }


            if (picEmpPhoto.Image != Resources.portrait_blank_male)
            {
                personal.Photo = CustomImage.ConvertImageToBinary(picEmpPhoto.Image,30);
                
            }
            else
            {
                personal.Photo = null;
            }
            try
            {
                if (_recordType == RecordTypes.Add)
                {
                    GlobalConfig.iDataConnection.CreateEmployee(personal);
                    MessageBox.Show("Record Saved Successfully");
                    AllClear();
                }
                else if (_recordType == RecordTypes.Update)
                {
                    GlobalConfig.iDataConnection.UpdateEmployee(personal);
                    MessageBox.Show("Record Update Successfully");
                    if (_irefreshemplist != null)
                    {
                        _irefreshemplist.RefreshEmpList();
                       
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool isValid()
        {
            bool msg = true;

            if (txtCode.Text.Length <= 0)
            {
                msg = false;
            }

            if (txtName.Text.Length <= 0)
            {
                msg = false;
            }

            if (txtDesignation.Text.Length <= 0)
            {
                msg = false;
            }

            if (txtBranch.Text.Length <= 0)
            {
                msg = false;
            }
            return msg;
        }

        private void chkAppointDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAppointDate.Checked == true)
            {
                dtAppontDate.Enabled = true;
            }
            else
            {
                dtAppontDate.Enabled = false;
            }
        }

        private void chkIDCardAssignDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIDCardAssignDate.Checked == true)
            {
                dtIDCardAssignDate.Enabled = true;
            }
            else
            {
                dtIDCardAssignDate.Enabled = false;
            }
        }

        private void chkJoiningDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJoiningDate.Checked == true)
            {
                dtJoiningDate.Enabled = true;
            }
            else
            {
                dtJoiningDate.Enabled = false;
            }
        }

        private void chkBirthDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBirthDate.Checked == true)
            {
                dtBirthDate.Enabled = true;
            }
            else
            {
                dtBirthDate.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void AllClear()
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtDesignation.Text = "";
            txtBranch.Text = "";
            txtQualification.Text = "";
            txtNIDNumber.Text = "";
            txtBloodGroup.Text = "";
            picEmpPhoto.Image = Resources.portrait_blank_male;
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            try
            {
                picEmpPhoto.Image = Resources.portrait_blank_male;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {




            picEmpPhoto.Image = Resources.portrait_blank_male;

            if (_recordType == RecordTypes.Update)
            {


                // Bind Datagrid Leave Detail List, Contact List,NIDDetails List,Mail List
                BindField();

            }
        }

        void BindField()
        {
            txtCode.Text = _personal.EmpCode;
            txtName.Text = _personal.EmpName;
            txtDesignation.Text = _personal.Designation;
            txtBranch.Text = _personal.Branch;
            txtQualification.Text = _personal.Qualification;
            txtNIDNumber.Text = _personal.NIDNumber;
            txtBloodGroup.Text = _personal.BloodGruop;
            if (_personal.DateOfBirth != null)
            {
                dtBirthDate.Value = Convert.ToDateTime(_personal.DateOfBirth);
            }

            if (_personal.AppointDate != null)
            {
                dtAppontDate.Value = Convert.ToDateTime(_personal.AppointDate);
            }
            if (_personal.IDAssignDate != null)
            {
                dtIDCardAssignDate.Value = Convert.ToDateTime(_personal.IDAssignDate);
            }

            if (_personal.JoiningDate != null)
            {
                dtJoiningDate.Value = Convert.ToDateTime(_personal.JoiningDate);
            }

            if (_personal.Photo != null)
            {
                picEmpPhoto.Image = CustomImage.ConvertBinaryToImage(_personal.Photo);
            }

            dgvLeaveDetails.DataSource = null;
            dgvLeaveDetails.DataSource = _personal.leavedetails;
            dgvContactNo.DataSource = null;
            dgvContactNo.DataSource = _personal.ContactList; ;
            dgvIdCardInformation.DataSource = null;
            dgvIdCardInformation.DataSource = _personal.NIDList;
            dgvMailList.DataSource = null;
            dgvMailList.DataSource = _personal.MailList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_irefreshemplist != null)
            {
                _irefreshemplist.RefreshEmpList();

            }
            this.Close();
        }

        private void tbEmpInfo_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {

            }
        }

        private void dgvLeaveDetails_MouseUp(object sender, MouseEventArgs e)
        {

            int intRowindex = dgvLeaveDetails.HitTest(e.X, e.Y).RowIndex;

            if (intRowindex == -1)
            {

                cntxEditLeave.Enabled = false;
                cntxDeleteLeave.Enabled = false;

            }
            else
            {

                cntxEditLeave.Enabled = true;
                cntxDeleteLeave.Enabled = true;
                dgvLeaveDetails.ClearSelection();
                dgvLeaveDetails.Rows[intRowindex].Selected = true;
            }
        }

        private void cntxAddNewLeave_Click(object sender, EventArgs e)
        {

            //RefreshEmpList() Method Update the _personal Class
            //Before Leave Form Show _personal Class will be updated

            RefreshEmpList(); 
            frmLeave frm = new frmLeave(_personal, this,RecordTypes.Add);

            frm.ShowDialog();
        }

        private void cntxEditLeave_Click(object sender, EventArgs e)
        {
            if (dgvLeaveDetails.SelectedRows.Count > 0)
            {
                LeaveDetails ld = dgvLeaveDetails.SelectedRows[0].DataBoundItem as LeaveDetails;
                frmLeave frm = new frmLeave(ld, this,RecordTypes.Update);
                frm.ShowDialog();
            }
        }


        // Update Employee LeaveDetails,Contactlist,NIDList,MailList
        public void RefreshEmpList()
        {



            List<Personal> Listp = GlobalConfig.iDataConnection.GetAllEmployees(DateRange.StartDate, DateRange.EndtDate).ToList();
            _personal = Listp.Where(x => x.EmpCode.ToLower() == txtCode.Text.ToLower()).Single();



            // Bind Datagrid Leave Detail List, Contact List,NIDDetails List,Mail List
            BindField() ;
            optAll.Checked = true;

            // Filter Leave CL,PL,SL,LWP,Maternity,Advance and Count Total Leave
            FilterLeave();

        }

        private void optCL_CheckedChanged(object sender, EventArgs e)
        {
            // Filter Leave CL,PL,SL,LWP,Maternity,Advance and Count Total Leave
            FilterLeave();
        }
        
        
        
        // Filter Leave CL,PL,SL,LWP,Maternity,Advance and Count Total Leave
        void FilterLeave()
        {

            List<LeaveDetails> _leaveDetails = new List<LeaveDetails>();
            int CountLeave = 0;
            _leaveDetails = _personal.leavedetails;



            if (optCL.Checked == true)
            {
                _leaveDetails = _leaveDetails.Where(x => x.LeaveType.ToLower() == "CL".ToLower()).ToList();
                CountLeave = _leaveDetails.Sum(x => x.TotalLeave);
            }
            else if (optPL.Checked == true)
            {
                _leaveDetails = _leaveDetails.Where(x => x.LeaveType.ToLower() == "PL".ToLower()).ToList();
                CountLeave = _leaveDetails.Sum(x => x.TotalLeave);
            }
            else if (optSL.Checked == true)
            {
                _leaveDetails = _leaveDetails.Where(x => x.LeaveType.ToLower() == "SL".ToLower()).ToList();
                CountLeave = _leaveDetails.Sum(x => x.TotalLeave);
            }

            else if (optLWP.Checked == true)
            {
                _leaveDetails = _leaveDetails.Where(x => x.LeaveType.ToLower() == "LWP".ToLower()).ToList();
                CountLeave = _leaveDetails.Sum(x => x.TotalLeave);
            }

            else if (optMaternity.Checked == true)
            {
                _leaveDetails = _leaveDetails.Where(x => x.LeaveType.ToLower() == "Maternity".ToLower()).ToList();
                CountLeave = _leaveDetails.Sum(x => x.TotalLeave);
            }
            else if (optAdvance.Checked == true)
            {
                _leaveDetails = _leaveDetails.Where(x => x.LeaveType.ToLower() == "Advance".ToLower()).ToList();
                CountLeave = _leaveDetails.Sum(x => x.TotalLeave);
            }
            else
            {
                CountLeave = _leaveDetails.Sum(x => x.TotalLeave);
            }


            dgvLeaveDetails.DataSource = null;
            dgvLeaveDetails.DataSource = _leaveDetails;
            lblLeaveCount.Text = CountLeave.ToString();

        }


        private void cntxDeleteLeave_Click(object sender, EventArgs e)
        {
            try { 
            if (dgvLeaveDetails.SelectedRows.Count > 0)
            {

                    if(MessageBox.Show("Do You Want To Delete The Record","Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                LeaveDetails _leavedetails = dgvLeaveDetails.SelectedRows[0].DataBoundItem as LeaveDetails;
                GlobalConfig.iDataConnection.DeleteLeaveDetailsByID(_leavedetails.LDID);
                RefreshEmpList(); // Update Employee LeaveDetails,Contactlist,NIDList,MailList
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void addContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContact frm = new frmContact(txtCode.Text, this,RecordTypes.Add);
            frm.ShowDialog();
        }

        private void cntxEditContact_Click(object sender, EventArgs e)
        {
            if (dgvContactNo.SelectedRows.Count > 0)
            {

                Contacts c = dgvContactNo.SelectedRows[0].DataBoundItem as Contacts;


                frmContact frm = new frmContact(c, this,RecordTypes.Update);
                frm.ShowDialog();

            }


        }

        private void dgvContactNo_MouseUp(object sender, MouseEventArgs e)
        {
            int intRowindex = dgvContactNo.HitTest(e.X, e.Y).RowIndex;

            if (intRowindex == -1)
            {
                cntxEditContact.Enabled = false;
                cntxDeleteContact.Enabled = false;
            }
            else
            {
                dgvContactNo.ClearSelection();
                dgvContactNo.Rows[intRowindex].Selected = true;
                cntxEditContact.Enabled = true;
                cntxDeleteContact.Enabled = true;

            }


        }

        private void cntxDeleteContact_Click(object sender, EventArgs e)
        {
            if (dgvContactNo.SelectedRows.Count > 0)
            {
                Contacts contact = dgvContactNo.SelectedRows[0].DataBoundItem as Contacts;

                int id = contact.ContactID;
                if (MessageBox.Show("Do You Want Delete Contact '" + contact.ContactNo + "'", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        GlobalConfig.iDataConnection.DeleteContact(id);
                        MessageBox.Show("'" + contact.ContactNo + "' Contact is Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RefreshEmpList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvIdCardInformation_MouseUp(object sender, MouseEventArgs e)
        {
            int rowindex = dgvIdCardInformation.HitTest(e.X, e.Y).RowIndex;
            if (rowindex == -1)
            {
                cntxEditCard.Enabled = false;
                cntxDeleteCard.Enabled = false;

            }
            else
            {
                cntxEditCard.Enabled = true;
                cntxDeleteCard.Enabled = true;
                dgvIdCardInformation.ClearSelection();
                dgvIdCardInformation.Rows[rowindex].Selected = true;
            }

        }

        private void cntxAddCard_Click(object sender, EventArgs e)
        {
            frmNIDDetails frm = new frmNIDDetails(txtCode.Text, this,RecordTypes.Add);
            frm.ShowDialog();
        }

        private void cntxEditCard_Click(object sender, EventArgs e)
        {
            if (dgvIdCardInformation.SelectedRows.Count > 0)
            {
                NIDDetails m = dgvIdCardInformation.SelectedRows[0].DataBoundItem as NIDDetails;
                frmNIDDetails frm = new frmNIDDetails(m, this,RecordTypes.Update);
                frm.ShowDialog();

            }
        }

        private void cntxDeleteCard_Click(object sender, EventArgs e)
        {
            if (dgvIdCardInformation.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Do You Want To Delete Record","Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { 
                int m =((NIDDetails)dgvIdCardInformation.SelectedRows[0].DataBoundItem).NIDID;
                GlobalConfig.iDataConnection.DeleteNIDDetails(m);
                    MessageBox.Show("Record Deleted Successfully");
                    RefreshEmpList();
                        }
            }
        }

        private void optAll_CheckedChanged(object sender, EventArgs e)
        {
            FilterLeave();
        }

        private void optPL_CheckedChanged(object sender, EventArgs e)
        {
            FilterLeave();
        }

        private void optSL_CheckedChanged(object sender, EventArgs e)
        {
            FilterLeave();
        }

        private void optLWP_CheckedChanged(object sender, EventArgs e)
        {
            FilterLeave();
        }

        private void optMaternity_CheckedChanged(object sender, EventArgs e)
        {
            FilterLeave();
        }

        private void optAdvance_CheckedChanged(object sender, EventArgs e)
        {
            FilterLeave();
        }

        private void cntxAddMail_Click(object sender, EventArgs e)
        {
            frmCreateMail frm = new frmCreateMail(txtCode.Text, txtName.Text,txtDesignation.Text,txtBranch.Text,this, RecordTypes.Add);
            frm.ShowDialog();
        }

        private void dgvMailList_MouseUp(object sender, MouseEventArgs e)
        {
            int introwindex = dgvMailList.HitTest(e.X, e.Y).RowIndex;

            if (introwindex == -1)
            {
                cntxEditmail.Enabled = false;
                cntxDeleteMail.Enabled = false;
                cntxSendMail.Enabled = false;
            }
            else
            {
                dgvMailList.ClearSelection();
                cntxEditmail.Enabled = true;
                cntxDeleteMail.Enabled = true;
                cntxSendMail.Enabled = true;
                dgvMailList.Rows[introwindex].Selected = true;
            }


        }

        private void cntxEditmail_Click(object sender, EventArgs e)
        {
            if (dgvMailList.SelectedRows.Count > 0)
            {
                MailList m = dgvMailList.SelectedRows[0].DataBoundItem as MailList;
                 frmCreateMail frm = new frmCreateMail(m, txtName.Text,txtDesignation.Text,txtBranch.Text, this, RecordTypes.Update);
                frm.ShowDialog();

            }
        }

        private void cntxDeleteMail_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Delete Record","Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            if (dgvMailList.SelectedRows.Count > 0)
            {
                MailList p = dgvMailList.SelectedRows[0].DataBoundItem as MailList;

                GlobalConfig.iDataConnection.DeleteMail(p.MailID);
                MessageBox.Show("Record Deleted Sucessfully", "Delete Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshEmpList();  // Update Employee LeaveDetails,Contactlist,NIDList,MailList
            }

        }

        private void cntxSendMail_Click(object sender, EventArgs e)
        {

            string m = ((MailList)dgvMailList.SelectedRows[0].DataBoundItem).EmailNo;

            frmMail frm = new frmMail(m);
            frm.ShowDialog();
        }

        private void frmNewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_irefreshemplist != null)
            {
                _irefreshemplist.RefreshEmpList();

            }
            
        }

        private void cntxPrintLeaveReport_Click(object sender, EventArgs e)
        {
           
            RefreshEmpList();
            frmReport frm = new frmReport(ReportsType.LeaveDetails, _personal);
            frm.MdiParent = Program.formMain;
            frm.Show();

        }
    }
}
