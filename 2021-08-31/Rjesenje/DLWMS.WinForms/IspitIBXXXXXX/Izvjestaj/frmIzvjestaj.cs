using DLWMS.WinForms.Izvjestaji;
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
    public partial class frmIzvjestaj : Form
    {
        private dtoIzvjestaj podaciZaPrint;

        public frmIzvjestaj(dtoIzvjestaj podaciZaPrint)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var tabela = new dsDLWMS.ScanDataTable();

            for (int i = 0; i < podaciZaPrint.ScanIspita.Count; i++) 
            {
                var red = tabela.NewScanRow();
                red.Predmet = podaciZaPrint.ScanIspita[i].Predmet.ToString();
                red.Napomena = podaciZaPrint.ScanIspita[i].Napomena.ToString();
                red.Varanje = podaciZaPrint.ScanIspita[i].Varanje.ToString();
                tabela.AddScanRow(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsScanIspita";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
