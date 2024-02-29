using DLWMS.Data;
using Microsoft.EntityFrameworkCore;
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
        dtoIzvjestaj podaciZaPrint;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmIzvjestaj(dtoIzvjestaj print)
        {
            InitializeComponent();
            podaciZaPrint = print;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var polozeni = new dsDLWMS.dsPolozeniDataTable();

            foreach(var korisnik in podaciZaPrint.Korisnici)
            {
                string sviPredmeti = "";
                var red = polozeni.NewdsPolozeniRow();
                red.ImePrezime = $"{korisnik.Ime} {korisnik.Prezime}";
                
                var polozeniPredmetiZaKorisnika = baza.PolozeniPredmeti.Include(k => k.Predmet).Where(p => p.KorisnikId == korisnik.Id).ToList();

                foreach(var polozeniPredmet in polozeniPredmetiZaKorisnika)
                    sviPredmeti += polozeniPredmet.Predmet.Naziv + Environment.NewLine;

                red.Predmet = sviPredmeti;
                polozeni.AdddsPolozeniRow(red);
            }

            var rds = new ReportDataSource();
            rds.Value = polozeni;
            rds.Name = "dsPolozeniPredmeti";

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
