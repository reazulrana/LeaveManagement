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
using Payroll.InterfacerLibrary;
using Payroll;
namespace Payroll
{
    public partial class frmEditLeaveDetails : Form,IRefreshEmpList
    {
        public frmEditLeaveDetails()
        {
            InitializeComponent();
        }

        private void frmEditLeaveDetails_Load(object sender, EventArgs e)
        {
            dtStarttingYear.Value = DateTime.Now;
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
            bindDatagridByCurrentYear();
        }

        void bindDatagridByCurrentYear()
        {

            
            List<LeaveDetailsExtraInfo> GetLeaveDetails = GlobalConfig.iDataConnection.GetLeaveDetailsExtraInfo(DateRange.StartDate, DateRange.EndtDate).ToList();
            dgvLeaveDetails.DataSource = null;
            dgvLeaveDetails.DataSource = GetLeaveDetails;
            
        }
        void bindDatagridByDateRange()
        {

         

            List<LeaveDetailsExtraInfo> GetLeaveDetails = GlobalConfig.iDataConnection.GetLeaveDetailsExtraInfo(dtFrom.Value, dtTo.Value).ToList();
            dgvLeaveDetails.DataSource = null;
            dgvLeaveDetails.DataSource = GetLeaveDetails;

        }


        private void optCurrentYear_CheckedChanged(object sender, EventArgs e)
        {
            bindDatagridByCurrentYear();
            grpDateRange.Enabled = false;
          
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                bindDatagridByDateRange();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
       
        }

        private void optRangeYear_CheckedChanged(object sender, EventArgs e)
        {
            dgvLeaveDetails.DataSource = null;
            grpDateRange.Enabled = true;
         
            
        }

        private void dgvLeaveDetails_MouseUp(object sender, MouseEventArgs e)
        {
            int rowindex = dgvLeaveDetails.HitTest(e.X, e.Y).RowIndex;

            if (rowindex == -1)
            {
                cntxDelete.Enabled = false;
                cntxEdit.Enabled = false;

            }
            else
            {
                cntxDelete.Enabled = true;
                cntxEdit.Enabled = true;
                dgvLeaveDetails.ClearSelection();
                dgvLeaveDetails.Rows[rowindex].Selected = true;
            }
        }

        private void cntxEdit_Click(object sender, EventArgs e)
        {

            if (dgvLeaveDetails.SelectedRows.Count > 0) {
                LeaveDetailsExtraInfo lde = dgvLeaveDetails.SelectedRows[0].DataBoundItem as LeaveDetailsExtraInfo;
                frmLeave frm = new frmLeave(lde, this,RecordTypes.Update);
                frm.ShowDialog();
                    }

        }

        public void RefreshEmpList()
        {
            if (optCurrentYear.Checked == true)
            {
                bindDatagridByCurrentYear();
            }
            else
            {
                bindDatagridByDateRange();

            }
        }

        private void cntxDelete_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Do You Want To Delete Record","Confirmation Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (dgvLeaveDetails.SelectedRows.Count > 0)
            {
                int intid =((LeaveDetailsExtraInfo)dgvLeaveDetails.SelectedRows[0].DataBoundItem).LDID;
                try { 
                GlobalConfig.iDataConnection.DeleteLeaveDetailsByID(intid);
                RefreshEmpList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvLeaveDetails_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLeaveDetails.SelectedRows.Count > 0)
            {
                LeaveDetailsExtraInfo lde = dgvLeaveDetails.SelectedRows[0].DataBoundItem as LeaveDetailsExtraInfo;
                frmLeave frm = new frmLeave(lde, this,RecordTypes.Update);
                frm.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLeaveDetails.SelectedRows.Count > 0)
                {
                    LeaveDetailsExtraInfo lde = dgvLeaveDetails.SelectedRows[0].DataBoundItem as LeaveDetailsExtraInfo;
                    frmLeave frm = new frmLeave(lde, this, RecordTypes.Update);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
