using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmailSMSLibrary;
using System.Configuration;
using System.Security;
using DAL;
using BLL;

namespace Payroll
{
    public partial class frmMail : Form
    {





        List<string> ListAttachmentFile = new List<string>();
        public frmMail()
        {
            InitializeComponent();
            bindMailGrid();
        }

        public frmMail(string to)
        {
            InitializeComponent();
            bindMailGrid();
            txtTo.Text = to;

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    string from = ConfigurationManager.AppSettings["email"];
        //    string Passsword = ConfigurationManager.AppSettings["password"];


        //    try { 
        //    GlobalMailConfiguration._Iemail.Message = "Hi";

        //    GlobalMailConfiguration._Iemail.Subjects = "Test";
        //    GlobalMailConfiguration._Iemail.Send(from, from, Passsword);
        //        MessageBox.Show("Message Sent Successfully","Message Confirmation");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}

        private void lblColorShow_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            colorDialog.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        //Retrive All List of Attachment File
        private void lblAttachment_Click(object sender, EventArgs e)
        {

            if (OFD.ShowDialog() == DialogResult.OK)
            {

                if (txtAttachment.Text.Length > 0)
                {
                    if (MessageBox.Show("Do You Want Keep Previous Attachment Files", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        txtAttachment.Text = "";
                        ListAttachmentFile.Clear();
                    }
                }

                string files = "";
                foreach( string filename in OFD.FileNames)
                {
                    //if (txtAttachment.Text.Length > 0)
                    //{
                    //    files += ";" + System.IO.Path.GetFileName(filename);
                    //    ListAttachmentFile.Add(filename);
                    //        }
                    //else
                    //{
                    //    files += System.IO.Path.GetFileName(filename) + ";";
                    //    ListAttachmentFile.Add(filename);
                    //}
                    files += System.IO.Path.GetFileName(filename) + ";";
                    ListAttachmentFile.Add(filename);
                }

                txtAttachment.Text += files;

            }
        }

        private void lstMailList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        //Bind Mail List 

          private  void bindMailGrid()
        {

            lstMailList.DataSource = null;
            lstMailList.DataSource = GlobalConfig.iDataConnection.GetAllMail();
            lstMailList.DisplayMember = "EmailNo";
            lstMailList.ValueMember = "EmpCode";

        }
        private void lstMailList_DoubleClick(object sender, EventArgs e)
        {
            List<string> toMail=new List<string>();

            if (txtTo.Text.Length > 0)
            {
                toMail = txtTo.Text.Split(Convert.ToChar(";")).ToList();


                foreach(string s in toMail)
                {
                    if (s.ToLower() == lstMailList.Text.ToLower())
                    {
                        MessageBox.Show("Duplicate Email is Adding","Duplication Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                                return;
                    }
                }

            }



            if (txtTo.Text.Length > 0)
            {
                txtTo.Text += ";" + lstMailList.Text;
            }
            else
            {
                txtTo.Text += lstMailList.Text;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            string from = ConfigurationManager.AppSettings["email"];
            string Passsword = ConfigurationManager.AppSettings["password"];



            List<string> tomail = txtTo.Text.Split(Convert.ToChar(";")).ToList();

            try
            {
                GlobalMailConfiguration._Iemail.Message = rtxBody.Text;
                GlobalMailConfiguration._Iemail.Attachments = ListAttachmentFile.ToList();
           

                GlobalMailConfiguration._Iemail.Subjects = txtSubject.Text;
                GlobalMailConfiguration._Iemail.Send(from, tomail, Passsword);
                MessageBox.Show("Message Sent Successfully", "Message Confirmation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMail_Load(object sender, EventArgs e)
        {

        }
    }
}
