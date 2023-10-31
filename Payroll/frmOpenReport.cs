using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class frmOpenReport : Form
    {

        ReportsType _reporttype;
        public frmOpenReport(ReportsType rtp)
        {
            InitializeComponent();
            _reporttype = rtp;
            if (_reporttype == ReportsType.EmployeeList)
            {
                HideControls();
            }
        }

        void HideControls()
        {
            grpEmpID.Visible = false;
            grpEmpName.Visible = false;

        }
        private void frmOpenReport_Load(object sender, EventArgs e)
        {

        }

        private void txtFindID_TextChanged(object sender, EventArgs e)
        {
            SearchRecord(txtFindID.Text, "ID");
        }


        private void SearchRecord(string SearchText, string strMode)
        {

            dgvEmpList.Visible = false;
            List<Personal> PersonList = new List<Personal>();
            if (optCurrentYear.Checked == true)
            {
                PersonList = GlobalConfig.iDataConnection.GetAllEmployees(DateRange.StartDate, DateRange.EndtDate);
            }
            else
            {
                PersonList = GlobalConfig.iDataConnection.GetAllEmployees(dtFrom.Value, dtTo.Value);
            }
            if (strMode.ToLower() == "ID".ToLower()) //Search Employee ID
            {
                dgvEmpList.Visible = true;
                dgvEmpList.Location = new Point(grpEmpID.Left, grpEmpID.Top + grpEmpID.Height);
                PersonList = PersonList.Where(x => x.EmpCode.ToLower().Contains(SearchText.ToLower())).ToList();


            }

            else if (strMode.ToLower() == "Name".ToLower()) //Search Employee Name
            {
                dgvEmpList.Visible = true;
                dgvEmpList.Location = new Point(grpEmpID.Left, grpEmpID.Top + grpEmpName.Height);
                PersonList = PersonList.Where(x => x.EmpName.ToLower().Contains(SearchText.ToLower())).ToList();
            }


            dgvEmpList.DataSource = null;
            dgvEmpList.DataSource = PersonList;


        }

        private void txtFindName_TextChanged(object sender, EventArgs e)
        {
            SearchRecord(txtFindID.Text, "Name");
        }

        private void txtFindID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //if press Enter key
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
        }

        private void txtFindName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //if press Enter key
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
        }

        private void dgvEmpList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Personal p = dgvEmpList.SelectedRows[0].DataBoundItem as Personal;
                txtFindID.Text = p.EmpCode;
                txtFindName.Text = p.EmpName;
                dgvEmpList.Visible = false;
            }
        }

        private void dgvEmpList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            foreach (DataGridViewRow row in dgvEmpList.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", dgvEmpList.Rows.Count + 1);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {



            frmReport frm = new frmReport();
            if (_reporttype == ReportsType.LeaveDetails)
            {
                if (txtFindID.Text.Length == 0)
                {
                    MessageBox.Show("Employee Code Required", "Field Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFindID.Select();
                    return;
                        
            }
                try { 
                Personal p = new Personal();
                if (optCurrentYear.Checked == true)
                {

                    p = GlobalConfig.iDataConnection.GetAllEmployees(DateRange.StartDate, DateRange.EndtDate).Where(x => x.EmpCode.ToLower() == txtFindID.Text.ToLower()).Single();

                }
                else
                {
                    p = GlobalConfig.iDataConnection.GetAllEmployees(dtFrom.Value, dtTo.Value).Where(x => x.EmpCode.ToLower() == txtFindID.Text.ToLower()).Single();
                }
                frm = new frmReport(_reporttype, p);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (_reporttype == ReportsType.EmployeeList)
            {
                List<Personal> p = new List<Personal>();
                if (optCurrentYear.Checked == true)
                {
                    p = GlobalConfig.iDataConnection.GetAllEmployees(DateRange.StartDate, DateRange.EndtDate).ToList();
                }
                else
                {
                    p = GlobalConfig.iDataConnection.GetAllEmployees(dtFrom.Value, dtTo.Value).ToList();
                }
                frm = new frmReport(_reporttype, p);
            }
      
            frm.MdiParent = Program.formMain;
            frm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
