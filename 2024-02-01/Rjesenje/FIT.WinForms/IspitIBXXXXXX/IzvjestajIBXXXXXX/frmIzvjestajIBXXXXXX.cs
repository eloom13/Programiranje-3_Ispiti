using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
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

namespace FIT.WinForms.IspitIBXXXXXX.IzvjestajIBXXXXXX
{
    public partial class frmIzvjestajIBXXXXXX : Form
    {
        private dtoIzvjestaj podaciZaPrint;
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmIzvjestajIBXXXXXX(dtoIzvjestaj podaciZaPrint)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;
        }

        private void frmIzvjestajIBXXXXXX_Load(object sender, EventArgs e)
        {
            var tabela = new dsDLWMSIBXXXXXX.dsGradoviDataTable();
            var rb = 1;
            string lblUkupnoGradova = "";
            int gradovi = 0;

            foreach(var item in podaciZaPrint.Drzave) 
            {
                var listaGradova = baza.GradoviIBXXXXXX.Where(g=> g.DrzavaId == item.Id).ToList();

                for(var i = 0; i < listaGradova.Count; i++) 
                {
                    var red = tabela.NewdsGradoviRow();
                    red.Rb = rb++.ToString();
                    red.Grad = listaGradova[i].Naziv.ToString();
                    red.Drzava = item.Naziv.ToString();

                    if (item.Status == true)
                        red.Aktivan = "DA";
                    else if (item.Status == false)
                        red.Aktivan = "NE";

                    gradovi++;
                    tabela.Rows.Add(red);
                    lblUkupnoGradova = $"Ukupno gradova: {gradovi}";
                }
            }

            var rds = new ReportDataSource();
            rds.Name = "dsDrzaveGradovi";
            rds.Value = tabela;

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("rpUkupanBrojGradova", lblUkupnoGradova.ToString()));


            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
