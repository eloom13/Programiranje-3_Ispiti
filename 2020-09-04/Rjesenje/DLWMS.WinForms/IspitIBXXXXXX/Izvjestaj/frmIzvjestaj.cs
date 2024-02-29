using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.IspitIBXXXXXX;
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

namespace DLWMS.WinForms.Izvjestaj
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
            var tabela = new dsDLWMS.dsPorukeDataTable();

            for (int i = 0; i < podaciZaPrint.Poruke.Count; i++) 
            {
                var red = tabela.NewdsPorukeRow();
                red.Primalac = podaciZaPrint.ImePrezime.ToString();
                red.Datum = podaciZaPrint.Poruke[i].Datum.ToString();
                red.Sadrzaj = podaciZaPrint.Poruke[i].Sadrzaj.ToString();
                tabela.AdddsPorukeRow(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsPorukeKorisnika";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
