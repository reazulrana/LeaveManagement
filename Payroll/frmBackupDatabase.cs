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
using BLL;

namespace Payroll
{
    public partial class frmBackupDatabase : Form
    {
        public frmBackupDatabase()
        {
            InitializeComponent();
            GetDbName();
        }


        private void GetDbName()
        {
            try
            {
                txtSourceDatabase.Text = GlobalConfig.iDataConnection.GetDatabaseName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {


            if (txtSourceDatabase.Text.Length == 0)
            {
                MessageBox.Show("Source Databse is Incorrect to backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (txtLocation.Text.Length == 0)
            {
                MessageBox.Show("Select Back Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string strOriginaFileName = txtBackupDatabase.Text; //Get Database Name from txtBackupDatabase to Rename the file if file overwritten
            BackUp bk = new BackUp();
            bk.SourceDatabase = txtSourceDatabase.Text;
            bk.Location = txtLocation.Text;

            if (txtBackupDatabase.Text.Length!=0)
            {
                

                // it use to change original database name to new Database name as backup
                bk.BackupName = txtBackupDatabase.Text;

              
            }
            else
            {
                bk.BackupName = bk.SourceDatabase;
            }

            //Check File Is Existing in the Folder
            string strCheckfileExisting = "";
           
            strCheckfileExisting = bk.FullPath;
        
            if (System.IO.File.Exists(strCheckfileExisting))
            {
           
                bk.BackupName = bk.BackupName + "_" + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.TimeOfDay.Ticks;
            }

            try
            {
                               
                GlobalConfig.iDataConnection.BackupDatabase(bk);
                MessageBox.Show("Backe Up Complete Successfully","Successfull Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
               


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void frmBackupDatabase_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDbName();
        }

        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnable.Checked == false)
            {
                txtSourceDatabase.Enabled = false;
            }
            else
            {
                txtSourceDatabase.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
