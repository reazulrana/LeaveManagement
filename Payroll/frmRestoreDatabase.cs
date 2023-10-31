using BLL;
using SQLLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DAL;

namespace Payroll
{
    public partial class frmRestoreDatabase : Form
    {

        string strconnectionstring = ConfigurationManager.ConnectionStrings["dbmaster"].ConnectionString;

        public frmRestoreDatabase()
        {
            InitializeComponent();
        }

        private void frmRestoreDatabase_Load(object sender, EventArgs e)
        {

        }

        private void chkRestoreName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRestoreName.Checked == true)
            {
                txtNewDatabaseName.Enabled = true;
            }
            else
            {
                txtNewDatabaseName.Enabled = false;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try { 
            ofd.Filter = "Database files (*.bak ) | *.bak";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
   
                txtRestorePath.Text = ofd.FileName;
                txtRestoreDatabaseName.Text = System.IO.Path.GetFileName(ofd.FileName);
                int I = txtRestoreDatabaseName.Text.IndexOf("_");
                    
                    if (I > -1)
                { 
                txtRestoreDatabaseName.Text = txtRestoreDatabaseName.Text.Substring(0,Convert.ToInt32(txtRestoreDatabaseName.Text.IndexOf("_")));
                }
                else
                {
                    txtRestoreDatabaseName.Text = txtRestoreDatabaseName.Text.Substring(0, txtRestoreDatabaseName.Text.Length - 4);
                }
            }
            }
            catch(Exception ex)
            {
                GlobalConfig.iDataConnection.ErrorMessage(ex);
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtTargetPath.Text = fbd.SelectedPath;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            if (txtRestorePath.Text.Length == 0)
            {
                MessageBox.Show("Restore Path Not Seletecd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTargetPath.Text.Length == 0)
            {
                MessageBox.Show("Target Path Not Seletecd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RestoreDatabase rd = new RestoreDatabase();
            if (string.IsNullOrEmpty(txtNewDatabaseName.Text))
            { 
            rd.DatabaseName = txtRestoreDatabaseName.Text;
            }
            else
            {
                rd.DatabaseName = txtNewDatabaseName.Text;
            }
            rd.MoveDatabasePrimery = txtRestoreDatabaseName.Text; //for Move mdf File Name example[MOVE N'dbPayrollManagement']
            rd.MoveDatabaseLog = txtRestoreDatabaseName.Text + "_log"; //for Move log (ldf) File Name  example[MOVE N'dbPayrollManagement_log']
            rd.RestorePath = txtRestorePath.Text;
            
            rd.TargetPath = txtTargetPath.Text;

            SQLRestore sqlrestore = new SQLRestore(strconnectionstring);
            try { 
            sqlrestore.RestorePath = rd.RestorePath;
            sqlrestore.MoveDatabasePrimery = rd.MoveDatabasePrimery;
            sqlrestore.MoveDatabaseLog = rd.MoveDatabaseLog;
            sqlrestore.DatabaseName = rd.DatabaseName;
            sqlrestore.TargetPath = rd.TargetPath;
            sqlrestore.Restore();
                MessageBox.Show("Restore Complete Successfully", "Successfull Message");
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
