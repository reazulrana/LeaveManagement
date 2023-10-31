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
    public partial class frmNIDDetails : Form
    {




        IRefreshEmpList _IrefreshEmplis;
        RecordTypes _recordtype;
        NIDDetails _model;
        public frmNIDDetails()
        {
            InitializeComponent();

            _recordtype = RecordTypes.Add;
        }

        

        // Its Used for Add NIDDetails
        public frmNIDDetails(string EmployeeCode,IRefreshEmpList IrefreshEmplist,RecordTypes rt)
        {
            InitializeComponent();
            _recordtype = rt;
            txtEmpCode.Text=EmployeeCode;
            _IrefreshEmplis = IrefreshEmplist;
            DisableField();
        }


        // Its Used for Update NIDDetails
        public frmNIDDetails(NIDDetails model, IRefreshEmpList IrefreshEmplist,RecordTypes rt)
        {
            InitializeComponent();
            _recordtype = rt;
            btnSave.Text = "&Update";
            _model = model;
            this.Text = "Update National ID Card Details";
            _IrefreshEmplis = IrefreshEmplist;
            BindField(); 
        }

      private  void BindField()
        {
            txtEmpCode.Text = _model.EmpCode;
            dtAssignDate.Value = _model.CardAssignDate;
            txtNIDNumber.Text = _model.NIDNumber;
            txtRemarks.Text = _model.Remarks;
        }


        void DisableField()
        {
            txtEmpCode.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Tuple<bool,string> obj = Isvalidfield();

            if (obj.Item1 == false)
            {
                MessageBox.Show($"{obj.Item2} Is Requird");
                return;
            }

            NIDDetails nd = new NIDDetails();
            nd.EmpCode = txtEmpCode.Text;
            nd.CardAssignDate = dtAssignDate.Value;
            nd.NIDNumber = txtNIDNumber.Text;
            nd.Remarks = txtRemarks.Text;
       
            if (_recordtype == RecordTypes.Add) { 
            GlobalConfig.iDataConnection.CreateNidDetails(nd);
                MessageBox.Show("Record Save Successfullu", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    if (_IrefreshEmplis != null)
                {
                    _IrefreshEmplis.RefreshEmpList();
                   
                        return;
                }
            }
            else if (_recordtype == RecordTypes.Update) // if _recordtype is Update Mode Then Fires
                {
                nd.NIDID = _model.NIDID;
                GlobalConfig.iDataConnection.UpdateNIDDetailsByNidID(nd);
                MessageBox.Show("Record Save Successfullu", "Successfull Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_IrefreshEmplis != null)
                {
                    _IrefreshEmplis.RefreshEmpList();
                    
                        return;
                    }
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearField()
        {
            txtEmpCode.Text = "";
            txtNIDNumber.Text = "";
            txtRemarks.Text = "";
        }

        private void frmNIDDetails_Load(object sender, EventArgs e)
        {

        }



        Tuple<bool,string> Isvalidfield()
        {

            string msg = "";
            bool blnflag = true;
            try {
                Personal p = GlobalConfig.iDataConnection.GetAllEmployee.Where(x => x.EmpCode.ToLower() == txtEmpCode.Text.ToLower()).Single();

                if (p == null)
                {
                    msg = "Code";
                    blnflag = false;
                    txtEmpCode.Select();
                }

                if (txtNIDNumber.Text.Length <= 0)
                {
                    msg = "NID NUmber";
                    blnflag = false;
                    txtNIDNumber.Select();
                }

                }
            catch
            {
                msg = "Code";
                blnflag = false;
            }
            Tuple<bool, string> t = Tuple.Create(blnflag, msg);
            return t;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
