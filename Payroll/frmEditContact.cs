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
namespace Payroll
{
    public partial class frmEditContact : Form,IRefreshEmpList
    {
        public frmEditContact()
        {
            InitializeComponent();
            BindDataGrid();
        }

        private void frmEditContact_Load(object sender, EventArgs e)
        {

        }


        private void FilterDate(string SearchCriteria,string searchtype)
        {

            List<ContactExtraInfo> contactlist = GlobalConfig.iDataConnection.GetContactExtrainfo;

            if (searchtype.ToLower() == "Code".ToLower())
            {

                contactlist = contactlist.Where(x => x.EmpCode.ToLower().Contains(SearchCriteria.ToLower())).ToList();
            }
            else if (searchtype.ToLower() == "Name".ToLower())
            {

                contactlist = contactlist.Where(x => x.EmpName.ToLower().Contains(SearchCriteria.ToLower())).ToList();
            }

            else if (searchtype.ToLower() == "Contact".ToLower())
            {

                contactlist = contactlist.Where(x => x.ContactNo.ToLower().Contains(SearchCriteria.ToLower())).ToList();
            }
            dgvContactList.DataSource = null;
            dgvContactList.DataSource = contactlist;


        }

        private void BindDataGrid()
        {
            try { 
            dgvContactList.DataSource = null;
            dgvContactList.DataSource = GlobalConfig.iDataConnection.GetContactExtrainfo;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BindDataGrid();
        }

        private void dgvContactList_MouseUp(object sender, MouseEventArgs e)
        {
            int introwindex = dgvContactList.HitTest(e.X, e.Y).RowIndex;

            if (introwindex == -1)
            {
                cntxDeleteContact.Enabled = false;
                cntxEditContact.Enabled = false;
                cntxAddContact.Enabled = false;
            }
            else
            {
                cntxDeleteContact.Enabled = true;
                cntxEditContact.Enabled = true;
                cntxAddContact.Enabled = true;
                dgvContactList.ClearSelection();
                dgvContactList.Rows[introwindex].Selected = true;
            }
        }

        private void cntxEditContact_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        public void RefreshEmpList()
        {
            BindDataGrid();
        }

        private void cntxDeleteContact_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Delete Record","Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            if (dgvContactList.SelectedRows.Count > 0)
            {

                int id = ((ContactExtraInfo)dgvContactList.SelectedRows[0].DataBoundItem).ContactID;
                try { 
                GlobalConfig.iDataConnection.DeleteContact(id);
                    MessageBox.Show("Record Deleted Successfully", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BindDataGrid();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

    private    void ShowForm()
        {
            try { 
            if (dgvContactList.SelectedRows.Count > 0)
            {
                ContactExtraInfo _contact = dgvContactList.SelectedRows[0].DataBoundItem as ContactExtraInfo;
                frmContact frm = new frmContact(_contact, this,RecordTypes.Update);
                frm.ShowDialog();
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvContactList_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            FilterDate(txtCode.Text, "Code");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FilterDate(txtName.Text, "Name");
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            FilterDate(txtContact.Text, "Contact");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cntxAddContact_Click(object sender, EventArgs e)
        {
            if (dgvContactList.SelectedRows.Count > 0)
            {
                string empcode = ((ContactExtraInfo)dgvContactList.SelectedRows[0].DataBoundItem).EmpCode;
                frmContact frm = new frmContact(empcode, this,RecordTypes.Update);
                frm.ShowDialog();
            }
        }
    }
}
