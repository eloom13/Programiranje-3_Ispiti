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

namespace FIT.WinForms.IspitIBXXXXXX.Izvjestaj
{
    public partial class frmReport : Form
    {
        private dtoUvjerenje podaciZaPrint;

        public frmReport(dtoUvjerenje podaciZaPrint)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;

            var tabela = new dsDLWMS.KonsultacijeDataTable();
            
            var rb = 1;
            var studentIme = "";

            foreach ( var polozeni in podaciZaPrint.polozeniPredmeti ) 
            {
                var red = tabela.NewKonsultacijeRow();
                red.Rb = rb++.ToString();
                red.Predmet = polozeni.Predmet.ToString();
                red.Vrijeme = polozeni.VrijemeOdrzavanja.ToString();
                red.Napomena = polozeni.Napomena.ToString();

                studentIme = polozeni.Student.ToString();
                tabela.AddKonsultacijeRow(red);
            }
            

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pStudent", studentIme));

            var rds = new ReportDataSource();
            rds.Name = "dsKonsultacije";
            rds.Value = tabela;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
