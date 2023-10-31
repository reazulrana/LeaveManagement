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

namespace Payroll
{
    public partial class frmLogin : Form
    {

        IMainFormFunction _imainformfunction;


        public frmLogin()
        {
            InitializeComponent();
      
        }
        public frmLogin(IMainFormFunction imainformfunction)
        {
            InitializeComponent();
            _imainformfunction = imainformfunction;
            _blnClosedBlag = true;
        }
        bool _blnClosedBlag;
        private void btnLogin_Click(object sender, EventArgs e)
        {

               
            Users model = new Users();
            model.UserName = txtUserName.Text;
            model.Password = txtPassword.Text;

            try { 
            Users _user = GlobalConfig.iDataConnection.UserVerify(model);

            if (_user != null)
            {
                if (_imainformfunction != null)
                {
                    if (_user.Type.ToString().ToLower() == "admin".ToLower())
                    { 

                    Program.ConfigFunction(TypeofUser.admin);
                        if (chkRemember.Checked == true)
                        {
                            Properties.Settings.Default.UserName = txtUserName.Text;
                            Properties.Settings.Default.Password = txtPassword.Text;
                            Properties.Settings.Default.Save();
                        }

                    }
                    else
                    {
                        Program.ConfigFunction(TypeofUser.user);
                    }
                    _imainformfunction.CloseLogin(this, _user);
                    _blnClosedBlag = false;
                }
            }
            else
            {
                lblMessage.Text = "User Name or Pasword is invalid";
                lblMessage.ForeColor = Color.White;
                lblMessage.Font=new Font("Times New Roman",12,FontStyle.Regular);
            }


            }
            catch(Exception ex)
            {
                lblMessage.Text =ex.Message;
                lblMessage.ForeColor = Color.White;
                lblMessage.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        

            txtUserName.Select();
            txtUserName.Text = Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.Password;

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_blnClosedBlag == true)
            { 
            Application.Exit();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Application.Exit();
            
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtPassword.PasswordChar = char.MinValue;
            }
            else
            {
                txtPassword.PasswordChar = Convert.ToChar("*");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.Select();
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Select();
            }
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            NSANIMATION.Animations.DragControl(this.Handle);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            NSANIMATION.Animations.DragControl(this.Handle);
        }
    }
}
