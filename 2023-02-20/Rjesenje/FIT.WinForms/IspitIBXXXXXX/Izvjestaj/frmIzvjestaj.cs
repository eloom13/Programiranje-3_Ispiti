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
            var tabela = new dsDLWMS.PorukeDataTable();

            int rb = 1;
            string studentInfo = "";
            int brojZnakova = 0;
            string ukupnoPoruka = "";
            int prosjek = 0;
            int suma = 0;
            string prosjekPoruka = "";

            foreach (var item in podaciZaPrint.Poruke)
            {
                var red = tabela.NewPorukeRow();
                int brojPoruka = podaciZaPrint.Poruke.Count;

                red.Rb = rb++.ToString();
                red.Predmet = item.Predmet.ToString();
                red.Poruka = item.Sadrzaj.ToString();
                red.Validnost = item.Validnost.ToString();
                brojZnakova = item.Sadrzaj.Length;
                red.BrojZnakova = brojZnakova.ToString();

                tabela.Rows.Add(red);   
                studentInfo = podaciZaPrint.StudentiInfo.ToString();
                ukupnoPoruka = $"Ukupno evidentirano {brojPoruka} poruka";
                suma += brojZnakova;
                prosjek = brojZnakova / brojPoruka;
                prosjekPoruka = $"Prosjecno {prosjek} karaktera u porukama";
            }

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("rpStudentInfo", studentInfo));
            rpc.Add(new ReportParameter("rpUkupno", ukupnoPoruka));
            rpc.Add(new ReportParameter("rpProsjekKaraktera", prosjekPoruka));

            var rds = new ReportDataSource();
            rds.Value = tabela;
            rds.Name = "dsPoruke";

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
