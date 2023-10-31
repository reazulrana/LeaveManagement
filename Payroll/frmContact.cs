using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Payroll.InterfacerLibrary;
using Payroll;
namespace Payroll


{


    public partial class frmContact : Form
    {

        

        RecordTypes _recordType;
        IRefreshEmpList _irefreshEmplist;
        Contacts _contacts;
        
        
        
        public frmContact()
        {
            InitializeComponent();
            _recordType = RecordTypes.Add;
        }

        //Uses for Add Contacts according to EmpCode
        public frmContact(string EmpCode, IRefreshEmpList Irefreshemplist,RecordTypes rt)
        {
            InitializeComponent();
            _irefreshEmplist = Irefreshemplist;
            _recordType = rt;
            txtEmpCode.Text = EmpCode;
            DisableField();
        }


        //Uses for Edit Contacts
        public frmContact(Contacts model, IRefreshEmpList Irefreshemplist, RecordTypes rt)
        {
            InitializeComponent();
            _irefreshEmplist = Irefreshemplist;
            _recordType = rt;
            this.Text = "Update Contact Details";
            txtEmpCode.Text = model.EmpCode;
            btnSave.Text = "&Update";
            _contacts = model;
            UpdateFields(); //Retrieve Data into text boxes
        }




        //Uses Update for Edit Contacts
        //Retrive Information into field from Contact class
        void UpdateFields()
        {
            txtContact.Text = _contacts.ContactNo;
            cmbOperator.Text = _contacts.Operator;
            if (_contacts.IssueDate != null)
            { 
            dtIssueDate.Value =  (DateTime)_contacts.IssueDate;
            }
            txtRemarks.Text = _contacts.Remarks;

        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            if (_recordType == RecordTypes.Add) { 
            cmbOperator.SelectedIndex = 0;
            }
        }


        void DisableField()
        {
            txtEmpCode.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          

                Tuple<bool, string> obj = Isvalidate();

            if (obj.Item1==false)
            {
                MessageBox.Show(obj.Item2 + " is reqired", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
                    if (obj.Item2.ToLower() == "Code".ToLower())
                    {
                        txtEmpCode.Select();
                    }
            
                if (obj.Item2.ToLower() == "Contact".ToLower())
                    {
                        txtContact.Select();
                    }

                if (obj.Item2.ToLower() == "Operator".ToLower())
                    {
                        cmbOperator.Select();
                    }

                    return;
            
            }
            Contacts contact = new Contacts();

            contact.EmpCode = txtEmpCode.Text;
            contact.ContactNo = txtContact.Text;
            contact.Operator = cmbOperator.Text;
            contact.IssueDate = dtIssueDate.Value;
            contact.Remarks = txtRemarks.Text;
            try { 
            if (_recordType == RecordTypes.Add)
            {
                GlobalConfig.iDataConnection.CreateContacts(contact);
                MessageBox.Show("Record Save Successfully");

                if (_irefreshEmplist != null)
                {
                    _irefreshEmplist.RefreshEmpList();
                  
                }
            }
            else if(_recordType == RecordTypes.Update)
            {
                contact.ContactID = _contacts.ContactID;
                GlobalConfig.iDataConnection.UpdateContacts(contact);
                MessageBox.Show("Record Update Successfully");
                
                if (_irefreshEmplist != null)
                {
                    _irefreshEmplist.RefreshEmpList();
                 
                }
                    this.Close();
                }
          
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }




        }

        private Tuple<bool,string> Isvalidate()
        {
            bool validate = false;
            string msg = "";
            try { 
            Personal p = GlobalConfig.iDataConnection.GetAllEmployee.ToList().Where(x=>x.EmpCode.ToLower()==txtEmpCode.Text.ToLower()).Single();

            if (p != null)
            {
                validate = true;
                    msg = "Code";
            }

                if (txtContact.Text.Length == 0)
                {
                    validate = false;
                    msg = "Contact";
                }

                if (cmbOperator.Text.Length == 0)
                {
                    validate = false;
                    msg = "Operator";
                }

            }
            catch
            {
                validate = false;
            }

            Tuple<bool, string> type = Tuple.Create(validate, msg);


            return type;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
