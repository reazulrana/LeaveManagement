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
using BLL;
using Payroll.InterfacerLibrary;
namespace Payroll
{
    public partial class frmEditNIDDetails : Form,IRefreshEmpList
    {
        public frmEditNIDDetails()
        {
            InitializeComponent();
        }

        private void frmEditNIDDetails_Load(object sender, EventArgs e)
        {
            BindDatagrid();
        }




        private void BindDatagrid()
        {
            dgvNidList.DataSource = null;
            dgvNidList.DataSource = GlobalConfig.iDataConnection.GetNIDDetailsExtrainfo;


        }

        private void dgvNidList_MouseUp(object sender, MouseEventArgs e)
        {
            int intRowIndex = dgvNidList.HitTest(e.X, e.Y).RowIndex;
            if (intRowIndex == -1)
            {
                cntxAddNID.Enabled = false;
                cntxEditNID.Enabled = false;
                cntxDeleteNID.Enabled = false;
            }
            else 
            {
                cntxAddNID.Enabled = true;
                cntxEditNID.Enabled = true;
                cntxDeleteNID.Enabled = true;
                dgvNidList.ClearSelection();
                dgvNidList.Rows[intRowIndex].Selected = true;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ShowForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void ShowForm()
        {
            if (dgvNidList.SelectedRows.Count > 0)
            {
                NidDetailsExtraInfo _NidDetailsExtraInfo = dgvNidList.SelectedRows[0].DataBoundItem as NidDetailsExtraInfo;
                frmNIDDetails frm = new frmNIDDetails(_NidDetailsExtraInfo, this,RecordTypes.Update);
                frm.ShowDialog();
            }
        }

        public void RefreshEmpList()
        {
            BindDatagrid();
        }

        private void cntxEditNID_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void dgvNidList_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void cntxAddNID_Click(object sender, EventArgs e)
        {


            string empcode = ((NidDetailsExtraInfo)dgvNidList.SelectedRows[0].DataBoundItem).EmpCode;
            frmNIDDetails frm = new frmNIDDetails(empcode, this,RecordTypes.Add);
            frm.ShowDialog();
        }

        private void cntxDeleteNID_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Delete Record","Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No)
            {
                return;
            }

            if (dgvNidList.SelectedRows.Count > 0)
            {
                int id = ((NidDetailsExtraInfo)dgvNidList.SelectedRows[0].DataBoundItem).NIDID;
                try
                {
                    GlobalConfig.iDataConnection.DeleteNIDDetails(id);
                    MessageBox.Show("Record Deleted Successfully");
                    BindDatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterData(string SearchCrieteria,string SearchType)
        {
            List<NidDetailsExtraInfo> NidList = GlobalConfig.iDataConnection.GetNIDDetailsExtrainfo;

            if (SearchType.ToLower() == "C".ToLower())
            {
                NidList = NidList.Where(x => x.EmpCode.ToLower().Contains(SearchCrieteria.ToLower())).ToList();
            }
            if (SearchType.ToLower() == "N".ToLower())
            {
                NidList = NidList.Where(x => x.EmpName.ToLower().Contains(SearchCrieteria.ToLower())).ToList();
            }
            if (SearchType.ToLower() == "I".ToLower())
            {
                NidList = NidList.Where(x => x.NIDNumber.ToLower().Contains(SearchCrieteria.ToLower())).ToList();
            }

            dgvNidList.DataSource = null;
            dgvNidList.DataSource = NidList;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                BindDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
