using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIBXXXXXX.Report
{
    public partial class frmIzvjestaj : Form
    {
        private StudentUvjerenje objekat;
        private Student student;

    
        public frmIzvjestaj(StudentUvjerenje objekat, Student student)
        {
            InitializeComponent();
            this.objekat = objekat;
            this.student = student;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("rpStudent", student.ToString()));
            rpc.Add(new ReportParameter("rpSvrha", objekat.Svrha));

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
