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
using Microsoft.Reporting.WinForms;
using Payroll;
using System.Configuration;
using System.Drawing.Printing;
namespace Payroll
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }



        ReportsType _ReportType;
        object _object;

        string Reportpath = ConfigurationManager.AppSettings["Reportpath"];
        public frmReport(ReportsType reporttype, object sender)
        {
            InitializeComponent();
            _ReportType = reporttype;
            _object = sender;

        }


        private void ShowReport()
        {
            try
            {
                ReportDataSource rps = new ReportDataSource();
                reportViewer1.LocalReport.DataSources.Clear();

                List<ReportParameter> ParameterList = new List<ReportParameter>(); // Set Parameter for All Report in One Variable

                //set Paper
                System.Drawing.Printing.PageSettings p = new System.Drawing.Printing.PageSettings();


              


                if (_ReportType == ReportsType.LeaveDetails)
                {
                    Personal Person = ((Personal)_object);

                    //set Margin
                    p.Margins = new Margins(1, 1, 1, 1);
                    //set Paper Size A4
                    p.PaperSize = new PaperSize("A4", 828, 1169);
                    ParameterList = new List<ReportParameter>() {

                               new ReportParameter("rpttxtEmployeeID", Person.EmpCode),
                               new ReportParameter("rpttxtDesignation", Person.Designation),
                               new ReportParameter("rpttxtName", Person.EmpName),
                               new ReportParameter("rpttxtBranch", Person.Branch),
                               new ReportParameter("rpttxtFrom", DateRange.StartDate.ToShortDateString()),
                               new ReportParameter("rpttxtTo", DateRange.EndtDate.ToShortDateString()),
                               new ReportParameter("rptintCL", Person.TotalCL.ToString()),
                               new ReportParameter("rptintPL", Person.TotalPL.ToString()),
                               new ReportParameter("rptintSL", Person.TotalSL.ToString()),
                               new ReportParameter("rptintLWP", Person.TotalLWP.ToString()),
                               new ReportParameter("rptintMaternity", Person.Maternity.ToString()),
                               new ReportParameter("rptintAdvance", Person.Advance.ToString())

                           };
                    
                    rps = new ReportDataSource("DataSetLeaveDetails", Person.leavedetails);
                    //reportViewer1.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("A4",1169,827);

                    reportViewer1.LocalReport.ReportPath = Reportpath + "rptLeaveDetails.rdlc";
                   
                }


                else if (_ReportType == ReportsType.EmployeeList)
                {
                    List<Personal> PersonList = _object as List<Personal>;
                    //set Margin
                    p.Margins = new Margins(1, 1, 1, 1);
                    //set Paper Size A4
                    
                    p.PaperSize = new PaperSize("A4", 1169, 828);
                    

                    rps = new ReportDataSource("AllEmployeeLeaveDetails", PersonList);
                    //reportViewer1.PrinterSettings.DefaultPageSettings= p;
                    reportViewer1.LocalReport.ReportPath = Reportpath + "rptAllEmployeeLeave.rdlc";
                
                }


          
           
                reportViewer1.SetPageSettings(p);
                if (ParameterList.Count > 0) { 
                reportViewer1.LocalReport.SetParameters(ParameterList);
                }
                reportViewer1.LocalReport.DataSources.Add(rps);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            ShowReport();

        }
    }
}
