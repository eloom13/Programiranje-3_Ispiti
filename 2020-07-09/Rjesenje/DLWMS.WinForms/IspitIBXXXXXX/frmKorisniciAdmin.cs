using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.IspitIBXXXXXX.Izvjestaj;
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
            //UcitajSpolove();
            UcitajKorisnike();
            UcitajKorisnikeSaFilterom();
        }

        private void UcitajKorisnikeSaFilterom()
        {
            txtFilter.TextChanged += FilterPromjene;
            cmbSpolovi.SelectedIndexChanged += FilterPromjene;
            cbAdministrator.CheckedChanged += FilterPromjene;
        }

        private void UcitajSpolove()
        {
            cmbSpolovi.DataSource = baza.Spolovi.ToList();

            cmbSpolovi.DisplayMember = "Naziv";
            cmbSpolovi.ValueMember = "Id";
        }

        private void UcitajKorisnike(List<Korisnik> korisnici = null)
        {
            var lista = baza.Korisnici.Include(k => k.Spol).ToList();

            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = korisnici ?? lista;
        }

        private void FilterPromjene(object sender, EventArgs e) // Moze na vise nacina...
        {
            string filter = txtFilter.Text.ToLower();
            var spol = cmbSpolovi.SelectedItem.ToString();
            int isAdmin = cbAdministrator.Checked ? 1 : 0;
            List<Korisnik> rezultatiPretrage = new List<Korisnik>();

            if (spol == "Svi")
            {
                rezultatiPretrage = baza.Korisnici.Where(k =>
                (k.Ime.ToLower().Contains(filter) || k.Prezime.ToLower().Contains(filter)) &&
                (k.Administrator == isAdmin)).ToList();
            }
            else
            {
                rezultatiPretrage = baza.Korisnici.Where(k =>
                (k.Ime.ToLower().Contains(filter) || k.Prezime.ToLower().Contains(filter)) &&
                (k.Spol.Naziv == spol) &&
                (k.Administrator == isAdmin)).ToList();
            }

            UcitajKorisnike(rezultatiPretrage);
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var print = new dtoIzvjestaj()
            {
                Korisnici = dgvKorisnici.DataSource as List<Korisnik>
            };

            frmIzvjestaj frmIzvjestaj = new frmIzvjestaj(print);
            frmIzvjestaj.ShowDialog();
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniKorisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;

            if (dgvKorisnici.CurrentCell is DataGridViewButtonCell)
            {
                frmKorisnikSlikePregled frmKorisnikSlikePregled = new frmKorisnikSlikePregled(odabraniKorisnik);
                frmKorisnikSlikePregled.ShowDialog();
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtThread.Text, out int n))
            {
                Thread opseg = new Thread(() =>
                {
                    long sum = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        sum += i;
                        Thread.Sleep(10);
                    }

                    BeginInvoke(() => txtThread.Text = sum.ToString());
                });

                opseg.Start();
            }
            else
            {
                MessageBox.Show("Unesite validan broj.");
            }
        }
    }

    public class dtoIzvjestaj
    {
        public List<Korisnik> Korisnici { get; set; }
    }
}
