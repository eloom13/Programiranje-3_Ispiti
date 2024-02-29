using DLWMS.WinForms.Izvjestaji;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
            var tabela = new dsDLWMS.dsStudentiDataTable();
            for (int i = 0; i<podaciZaPrint.Rezultati.Count; i++) 
            {
                var red = tabela.NewdsStudentiRow();
                red.ImePrezime = podaciZaPrint.Rezultati[i].Student.ToString();
                red.Datum = podaciZaPrint.Rezultati[i].Datum.ToString();
                red.Rezultat = podaciZaPrint.Rezultati[i].Rezultat.ToString();
                red.Dostavljen = podaciZaPrint.Rezultati[i].Dostavljen.ToString();
                tabela.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
