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
using ImageLibrary;
using Payroll.InterfacerLibrary;
using MyLibrary;

namespace Payroll
{
    public partial class frmEmpList : Form ,IRefreshEmpList
    {
        public frmEmpList()
        {
            InitializeComponent();
            //BindEmployee(BindModel);
            BindEmployeeList();
        }

        private void frmEmpList_Load(object sender, EventArgs e)
        {
            dtFrom.Value = DateRange.StartDate;
            dgvEmployeeList.RowHeadersWidth = 60;


            dtFrom.Value = DateRange.StartDate;
        
            BindEmployeeList();
        }

        private void BindEmployeeList()
        {
            
            BindEmployee(bindModel(DateRange.StartDate, DateRange.EndtDate));
        }

        private List<Personal> BindModel
        {
            get
            {

                return GlobalConfig.iDataConnection.GetAllEmployee;
            }
        }
        private List<Personal> bindModel(DateTime StartDate,DateTime EndDate)
        {
            
            List<Personal> GetEmployeeList = GlobalConfig.iDataConnection.GetAllEmployees(StartDate, EndDate).ToList();
            return GetEmployeeList;
        }
        private void BindEmployee(List<Personal> BindingModel)
        {
            dgvEmployeeList.DataSource = BindingModel;
        }

        private void dgvEmployeeList_DoubleClick(object sender, EventArgs e)
        {
            ShowRegisterEmployeForm();
        }

        private void ShowRegisterEmployeForm()
        {
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                Personal p = dgvEmployeeList.SelectedRows[0].DataBoundItem as Personal;

                frmNewEmployee frm = new frmNewEmployee(p,this,RecordTypes.Update);
                frm.dtStartDate.Value = dtFrom.Value;
                frm.ShowDialog();
            }
        }

        public void RefreshEmpList()
        {
            BindEmployeeList();
        }

        private void dgvEmployeeList_MouseUp(object sender, MouseEventArgs e)
        {
            int rowindex = dgvEmployeeList.HitTest(e.X, e.Y).RowIndex;
            if (rowindex == -1)
            {
                cntxAddNewLeave.Enabled = false;
                cntxEditPersonalInformation.Enabled = false;
                cntxDeleteEmployee.Enabled = false;
            }
            else
            {
                dgvEmployeeList.ClearSelection();
                cntxAddNewLeave.Enabled = true;
                cntxEditPersonalInformation.Enabled = true;
                cntxDeleteEmployee.Enabled = true;
                dgvEmployeeList.ClearSelection();
                dgvEmployeeList.Rows[rowindex].Selected = true;
            }
        }

        private void cntxEditPersonalInformation_Click(object sender, EventArgs e)
        {
            try
            {
                ShowRegisterEmployeForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void cntxAddNewLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployeeList.SelectedRows.Count > 0)
                {
                    Personal p = dgvEmployeeList.SelectedRows[0].DataBoundItem as Personal;

                    frmLeave frm = new frmLeave(p, this, RecordTypes.Add);

                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                BindEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            try
            {
                //Calling from MyLibrary Dll  file
                NSMSOFFICE.ExcelInformation.ExportGridView(dgvEmployeeList, dgvEmployeeList.Columns.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void cntxDeleteEmployee_Click(object sender, EventArgs e)
        {
            try { 
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {

                string EmployeeCode = ((Personal)dgvEmployeeList.SelectedRows[0].DataBoundItem).EmpCode;
                
            if(MessageBox.Show("Do You Want To Delete The Record ","Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    GlobalConfig.iDataConnection.DeleteEmployee(EmployeeCode);

                    MessageBox.Show("Record Deleted Successfully","Successfull Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dgvEmployeeList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            foreach(DataGridViewRow row in dgvEmployeeList.Rows)
            {
                dgvEmployeeList.Rows[row.Index].HeaderCell.Value = string.Format("{0}", row.Index + 1).ToString();
                
            }


        }

        private void cntxReport_Click(object sender, EventArgs e)
        {

            try
            {
                List<Personal> PList = dgvEmployeeList.DataSource as List<Personal>;


                frmReport frm = new frmReport(ReportsType.EmployeeList, PList);

                frm.MdiParent = Program.formMain;

                frm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
          

        }
    }
}
