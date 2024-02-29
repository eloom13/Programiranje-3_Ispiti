using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.IspitIBXXXXXX.Izvjestaj;
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
using static DLWMS.WinForms.IspitIBXXXXXX.frmKorisniciPolozeniPredmeti;

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmIzvjestaj : Form
    {
        private dtoUvjerenje podaciZaPrint;

        public frmIzvjestaj(dtoUvjerenje podaciZaPrint)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pImePrezime", podaciZaPrint.ImePrezime));

            var polozeni = new dsDLWMS.PolozeniDataTable();
            for (int i = 0; i<podaciZaPrint.Polozeni.Count; i++)
            {
                var red = polozeni.NewPolozeniRow();
                red.Predmet = podaciZaPrint.Polozeni[i].Predmet.Naziv.ToString();
                red.GodinaStudija = podaciZaPrint.Polozeni[i].GodinaStudija.ToString();
                red.Datum = podaciZaPrint.Polozeni[i].DatumPolaganja.ToShortDateString();
                red.Ocjena = podaciZaPrint.Polozeni[i].Ocjena.ToString(); 
                polozeni.AddPolozeniRow(red);
            }

            var rds = new ReportDataSource();
            rds.Value = polozeni;
            rds.Name = "dsPolozeniPredmetiKorisnika";

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
