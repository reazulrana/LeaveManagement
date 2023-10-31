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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        bool isvalid()
        {


            bool blnflag = true;

            if (txtUsername.Text.Trim() == string.Empty)
            {
                blnflag = false;
                MessageBox.Show("User Name Is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Select();

            }
            if (txtPassword.Text.Trim() == string.Empty)
            {
                blnflag = false;
                MessageBox.Show("User Name Is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Select();

            }

            if (cmbType.Text.Trim() == string.Empty)
            {
                blnflag = false;
                MessageBox.Show("User Name Is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbType.Select();
            }

            return blnflag;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


       

            if (isvalid() == false)
            {
                return;
            }

            Users _user = new Users();

            _user.UserName = txtUsername.Text;
            _user.Password = txtPassword.Text;
            if (cmbType.Text.ToLower() == "admin".ToLower())
            {
                _user.Type = "admin";
            }
            else
            {
                _user.Type = "user";
            }

            try
            {
                GlobalConfig.iDataConnection.CreateUser(_user);
                MessageBox.Show("Record Save Successfully");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtPassword.Text.Length == 0)
            {
                lblPassword.Visible = false;
                txtPassword.BackColor = Color.White;
                txtPassword.ForeColor = Color.Black;
                ChangeTextBoxLocation();
                return;
            }
            lblPassword.Visible = true;
            ChangeTextBoxLocation();
            if (txtPassword.Text.Length < 8)
            {
                txtPassword.BackColor = Color.Red;
                txtPassword.ForeColor = Color.White;
                lblPassword.Text = "Weak Password";
                lblPassword.BackColor = Color.Red;
                lblPassword.ForeColor = Color.White;
            }
            else if (txtPassword.Text.Length < 10)
            {
                txtPassword.BackColor = Color.Yellow;
                txtPassword.ForeColor = Color.Black;
                lblPassword.Text = "Strong Password";
                lblPassword.BackColor = Color.Yellow;
                lblPassword.ForeColor = Color.Black;
            }

            else if (txtPassword.Text.Length > 15)
            {
                txtPassword.BackColor = Color.Green;
                txtPassword.ForeColor = Color.White;
                lblPassword.Text = "Strong Password";
                lblPassword.BackColor = Color.Green;
                lblPassword.ForeColor = Color.White;
            }
        }


        private void ChangeTextBoxLocation()
        {
            if (lblPassword.Visible == false)
            {
                lblPassword.Top = txtPassword.Top + txtPassword.Height+1;
                txtConfirmPassword.Top = lblPassword.Top+2;
                lblConfirmPassword.Top = lblPassword.Top+2;
                cmbType.Top = txtConfirmPassword.Top + txtConfirmPassword.Height+2;
                lblType.Top = txtConfirmPassword.Top + txtConfirmPassword.Height+2;
                btnCreate.Top = cmbType.Top + cmbType.Height+2;
                btnClose.Top = cmbType.Top + cmbType.Height+2;


            }
            else
            {
                lblPassword.Top = txtPassword.Top + txtPassword.Height+1;
                txtConfirmPassword.Top = lblPassword.Top + lblPassword.Height+2;
                lblConfirmPassword.Top = lblPassword.Top + lblPassword.Height+2;
                cmbType.Top = txtConfirmPassword.Top + txtConfirmPassword.Height+2;
                lblType.Top = txtConfirmPassword.Top + txtConfirmPassword.Height+2;
                btnCreate.Top = cmbType.Top + cmbType.Height+2;
                btnClose.Top = cmbType.Top + cmbType.Height+2;

            }

        }
    }
}
