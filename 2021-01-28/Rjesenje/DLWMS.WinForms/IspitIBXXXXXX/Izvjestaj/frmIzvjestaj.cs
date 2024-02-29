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
    public partial class frmizvjestaj : Form
    {
        private dtoUvjerenje podaciZaPrint;

        public frmizvjestaj(dtoUvjerenje podaciZaPrint)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;
        }

        private void frmizvjestaj_Load(object sender, EventArgs e)
        {
            var tabela = new dsDLWMS.StudentiDataTable();
            int redniBroj = 1;

            foreach(var student in podaciZaPrint.Studenti)
            {
                string aktivan = "";

                var red = tabela.NewStudentiRow();
                red.Rb = redniBroj++.ToString();
                red.Indeks = student.BrojIndeksa.ToString();
                red.Ime = student.Ime.ToString();
                red.Prezime = student.Prezime.ToString();
                red.Spol = student.Spol.ToString();
                red.Godina = student.GodinaStudija.ToString();

                if (student.Aktivan)
                    aktivan = "Da";
                else
                    aktivan = "Ne";

                red.Aktivan = aktivan.ToString();
                tabela.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsStudenti";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
