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

namespace DLWMS.WinForms.IspitIBXXXXXX.Izvjestaj
{
    public partial class frmReport : Form
    {
        private dtoIzvjestaj podaciZaPrint;

        public frmReport(dtoIzvjestaj podaciZaPrint)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var prosjek = "";
            var tabela = new dsDLWMS.StudentiPredmetiDataTable();

            for (int i = 0; i < podaciZaPrint.StudentiPredmeti.Count; i++) 
            {
                var red = tabela.NewStudentiPredmetiRow();
                red.Student = podaciZaPrint.StudentiPredmeti[i].Student.ToString();
                red.Predmet = podaciZaPrint.StudentiPredmeti[i].Predmet.ToString();
                red.Datum = podaciZaPrint.StudentiPredmeti[i].Datum.ToString();
                red.Ocjena = podaciZaPrint.StudentiPredmeti[i].Ocjena.ToString();
                tabela.Rows.Add(red);

                prosjek = podaciZaPrint.StudentiPredmeti.Average(x => x.Ocjena).ToString();
            }

            rpc.Add(new ReportParameter("rpProsjecnaOcjena", prosjek));

            var rds = new ReportDataSource();
            rds.Name = "dsStudentiPredmeti";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
