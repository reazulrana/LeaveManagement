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
using Payroll;

namespace Payroll
{



    public partial class frmCreateMail : Form
    {




        RecordTypes _recordtypes;

        public frmCreateMail()
        {
            InitializeComponent();
        }


        IRefreshEmpList _irefreshemplist;
        MailList _model;
        //its call for New add Mail with information
        public frmCreateMail(string empcode, string empname,string Designation,string Branch, IRefreshEmpList  Irefreshemplist, RecordTypes rt)
        {
            InitializeComponent();
            _irefreshemplist = Irefreshemplist;
            _recordtypes = rt;
            disablefield();
            txtCode.Text = empcode;
            txtName.Text = empname;
            txtDesignation.Text = Designation;
            txtBranch.Text = Branch;

        }


        //its call for Update Existing Mail with information
        public frmCreateMail(MailList model,string empName, string Designation, string Branch, IRefreshEmpList Irefreshemplist, RecordTypes rt)
        {
            InitializeComponent();
            _irefreshemplist = Irefreshemplist;
            _recordtypes = rt;
            disablefield();
            _model = model;
            this.Text = "Update Mail";
            btnSave.Text = "&Update";
            txtCode.Text = _model.EmpCode;
            txtName.Text = empName;
            txtDesignation.Text = Designation;
            txtBranch.Text = Branch;
            txtEmail.Text = _model.EmailNo;



        }


        public void disablefield()
        {

            txtCode.Enabled = false;
            txtName.Enabled = false;
            txtDesignation.Enabled = false;
            txtBranch.Enabled = false;

        }

        private void frmCreateMail_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            MailList ml = new MailList();
            ml.EmpCode = txtCode.Text;
            ml.EmailNo = txtEmail.Text;
            try { 
            if (_recordtypes == RecordTypes.Add)
            {
                GlobalConfig.iDataConnection.CreateMail(ml);
                MessageBox.Show("Record Save Successfully", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_irefreshemplist != null)
                {
                    _irefreshemplist.RefreshEmpList();
                }

             
            }

            else if (_recordtypes == RecordTypes.Update)
            {
                ml.MailID = _model.MailID;
                GlobalConfig.iDataConnection.UpdateMail(ml);
                MessageBox.Show("Record Update Successfully", "Update Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_irefreshemplist != null)
                {
                    _irefreshemplist.RefreshEmpList();
                }
            }
            this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
    }
}
