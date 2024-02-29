using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmKorisniciAdmin : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmKorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void frmKorisniciAdmin_Load(object sender, EventArgs e)
        {
            UcitajKorisnike();
            IzracunajProsjekOcjenaSvihKorisnika();
        }

        public void IzracunajProsjekOcjenaSvihKorisnika()
        {
            var sveOcjene = baza.PolozeniPredmeti.Select(pp => pp.Ocjena);
            if (sveOcjene.Any())
            {
                double prosjek = sveOcjene.Average();
                var zaokruzeno = Math.Round(prosjek, 2);
                lblProsjek.Text = zaokruzeno.ToString();
            }
            else  
               lblProsjek.Text = "Nema ocjena";
        }



        private void UcitajKorisnike(List<Korisnik> korisnici = null)
        {
            var lista = baza.Korisnici.Include(s => s.Spol).ToList();

            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = korisnici ?? lista;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var rezultat = baza.Korisnici.Where(Filtriraj).ToList();
            UcitajKorisnike(rezultat);
        }

        private bool Filtriraj(Korisnik korisnik)
        {
            var filter = txtFilter.Text.ToLower();

            return korisnik.Ime.ToLower().Contains(filter) ||
                   korisnik.Prezime.ToLower().Contains(filter);
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex== 6) Jedna opcija

            var odabraniKorisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;

            if (dgvKorisnici.CurrentCell is DataGridViewButtonCell)
            {
                frmKorisniciPolozeniPredmeti frm = new frmKorisniciPolozeniPredmeti(odabraniKorisnik);
                frm.ShowDialog();
            }
        }
    }
}
