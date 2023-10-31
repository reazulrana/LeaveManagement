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
using Payroll;
using static Payroll.InterfacerLibrary.formEnums;

namespace Payroll
{
    public partial class frmAddEdit : Form
    {
        public frmAddEdit()
        {
            InitializeComponent();
        }


        FormTypeEnums _formtypeenums;

        public frmAddEdit(FormTypeEnums formtypeenums)
        {
            InitializeComponent();
            _formtypeenums = formtypeenums;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            dtStartingYear.Value = DateTime.Now;
            bindDatagrid();
        }




        private void ShowForm()
        {

        }


        private void bindDatagrid()
        {
            dgvEmployeeList.DataSource = null;
            dgvEmployeeList.DataSource = GetAllEmployeeList;
        }
        private List<Personal> GetAllEmployeeList
        {
            get
            {



                List<Personal> GetEmployees = GlobalConfig.iDataConnection.GetAllEmployees(DateRange.StartDate, DateRange.EndtDate).ToList();


                return GetEmployees;
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Employee Id is not matched", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Personal p = GlobalConfig.iDataConnection.GetAllEmployees(DateRange.StartDate, DateRange.EndtDate).Where(x => x.EmpCode.ToLower() == txtCode.Text.ToLower()).Single();


                if (_formtypeenums == FormTypeEnums.EmployeeForm)
                {
                    frmNewEmployee frm = new frmNewEmployee(p, null, RecordTypes.Update);
                    frm.ShowDialog();
                }


                if (_formtypeenums == FormTypeEnums.LeaveForm)
                {
                    frmLeave frm = new frmLeave(p, null, RecordTypes.Add);
                    frm.ShowDialog();
                }

                if (_formtypeenums == FormTypeEnums.Contact)
                {

                    frmContact frm = new frmContact(p.EmpCode, null, RecordTypes.Update);
                    frm.ShowDialog();


                }

                if (_formtypeenums == FormTypeEnums.NIDDetails)
                {
                    frmNIDDetails frm = new frmNIDDetails(p.EmpCode, null, RecordTypes.Add);
                    frm.ShowDialog();
                }

                if (_formtypeenums == FormTypeEnums.Mail)
                {
                    frmCreateMail frm = new frmCreateMail(p.EmpCode, p.EmpName, p.Designation, p.Branch, null, RecordTypes.Add);
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                GlobalConfig.iDataConnection.ErrorMessage(ex);
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Length == 0)
            {
                dgvEmployeeList.DataSource = null;
                dgvEmployeeList.Visible = false;
                return;
            }
            filterList(txtCode.Text, "C");
        }


        private void filterList(string SearchCriteria, string SearchType)
        {
            dgvEmployeeList.DataSource = null;
            dgvEmployeeList.Visible = false;
            List<Personal> ListofEmployee = GetAllEmployeeList;
            if (SearchType.ToLower() == "C".ToLower())
            {
                ListofEmployee = ListofEmployee.Where(x => x.EmpCode.ToLower().Contains(SearchCriteria.ToLower())).ToList();
                dgvEmployeeList.Location = new Point(txtCode.Left, txtCode.Top + txtCode.Height);
            }

            else if (SearchType.ToLower() == "N".ToLower())
            {
                ListofEmployee = ListofEmployee.Where(x => x.EmpName.ToLower().Contains(SearchCriteria.ToLower())).ToList();
                dgvEmployeeList.Location = new Point(txtName.Left, txtName.Top + txtName.Height);
            }

            dgvEmployeeList.DataSource = ListofEmployee;
            if (dgvEmployeeList.Rows.Count > 0)
            {
                dgvEmployeeList.Visible = true;
            }


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                dgvEmployeeList.DataSource = null;
                dgvEmployeeList.Visible = false;
                return;
            }
            filterList(txtName.Text, "N");
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //If press Enter
            {
                if (dgvEmployeeList.Visible == true)
                {
                    dgvEmployeeList.Select();
                    dgvEmployeeList.Rows[0].Selected = true;
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //If press Enter
            {
                if (dgvEmployeeList.Visible == true)
                {
                    dgvEmployeeList.Select();
                    dgvEmployeeList.Rows[0].Selected = true;
                }
            }
        }

        private void dgvEmployeeList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                txtCode.Text = ((Personal)dgvEmployeeList.SelectedRows[0].DataBoundItem).EmpCode;
                txtName.Text = ((Personal)dgvEmployeeList.SelectedRows[0].DataBoundItem).EmpName;
                dgvEmployeeList.Visible = false;
                btnOpen.Select();

            }
        }
    }
}
