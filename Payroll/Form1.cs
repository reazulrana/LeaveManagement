using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll.InterfacerLibrary;
using static Payroll.InterfacerLibrary.formEnums;
using BLL;
using DAL;
using System.Configuration;
namespace Payroll
{
    public partial class frmMain : Form, IMainFormFunction
    {
        public frmMain()
        {
            InitializeComponent();
        
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try {

                if (GlobalConfig.iDataConnection.CheckDatabaseExistng == false)
                {
                    mnuNew.Enabled = false;
                    mnuEdit.Enabled = false;
                    mnuInformation.Enabled = false;
                    mnuReport.Enabled = false;
                    mnuBackupDatabase.Enabled = false;
                    return;
                }

                frmLogin frm = new frmLogin(this);
            frm.ShowDialog();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewEmployee frm = new frmNewEmployee();
            frm.MdiParent = this;
                  frm.Show();
        }

        private void mnuLeave_Click(object sender, EventArgs e)
        {


            frmAddEdit frm = new frmAddEdit(FormTypeEnums.LeaveForm);
            frm.ShowDialog();
            //frmLeave frm = new frmLeave();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void mnuEmployeeList_Click(object sender, EventArgs e)
        {
       
        }

        private void mnuNewContact_Click(object sender, EventArgs e)
        {

            frmAddEdit frm = new frmAddEdit(FormTypeEnums.Contact);
            frm.ShowDialog();
            //frmContact frm = new frmContact();
            //frm.ShowDialog();
        }

        private void cardIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEdit frm = new frmAddEdit(FormTypeEnums.NIDDetails);
            frm.ShowDialog();
            //frmNIDDetails frm = new frmNIDDetails();
            //frm.ShowDialog();
        }

        private void cntxAll_Employee_Leave_Information_Click(object sender, EventArgs e)
        {
            frmEmpList frm = new frmEmpList();
            frm.MdiParent = this;
            frm.Show();
        }

        public void CloseLogin(frmLogin frm,Users user)
        {

            lblUser.Text = user.UserName + " (" + user.Type + ")";

            frm.Close();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEdit frm = new frmAddEdit(FormTypeEnums.EmployeeForm);
            frm.ShowDialog();
        }

        private void mnuUpdateLeave_Click(object sender, EventArgs e)
        {
            frmEditLeaveDetails frm = new frmEditLeaveDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuUpdateContact_Click(object sender, EventArgs e)
        {
            frmEditContact frm = new frmEditContact();
            frm.MdiParent = this;
            frm.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditNIDDetails frm = new frmEditNIDDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }

        private void mnuSendMail_Click(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            frm.ShowDialog();
        }

        private void mnuCreateMail_Click(object sender, EventArgs e)
        {
            frmAddEdit frm = new frmAddEdit(FormTypeEnums.Mail);
            frm.ShowDialog();
        }

        private void backUpDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupDatabase frm = new frmBackupDatabase();
            frm.ShowDialog();
        }

        private void mnuRestoreDatabase_Click(object sender, EventArgs e)
        {
            using (frmRestoreDatabase frm = new frmRestoreDatabase())
            {
                frm.ShowDialog();
            }
        }

        private void mnuIndividualLeave_Click(object sender, EventArgs e)
        {
            frmOpenReport frm = new frmOpenReport(ReportsType.LeaveDetails);
            frm.ShowDialog();

        }

        private void mnuAllLeaveSummery_Click(object sender, EventArgs e)
        {
            frmOpenReport frm = new frmOpenReport(ReportsType.EmployeeList);
            frm.ShowDialog();
        }
    }
}
