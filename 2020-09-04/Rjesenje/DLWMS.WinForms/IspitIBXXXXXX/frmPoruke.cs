using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.Izvjestaj;
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
    public partial class frmPoruke : Form
    {
        private Korisnik odabraniKorisnik;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmPoruke(Korisnik odabraniKorisnik)
        {
            InitializeComponent();
            this.odabraniKorisnik = odabraniKorisnik;
            dgvKorisniciPoruke.AutoGenerateColumns = false;
        }

        private void frmPorukeBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            lblKorisnik.Text = odabraniKorisnik.ToString();
            dgvKorisniciPoruke.DataSource = null;
            dgvKorisniciPoruke.DataSource = baza.KorisniciPoruke.Where(k => k.KorisnikId == odabraniKorisnik.Id).ToList();
        }

        private void dgvKorisniciPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaPoruka = dgvKorisniciPoruke.SelectedRows[0].DataBoundItem as KorisnikPoruka;

            if (e.ColumnIndex == 3)
            {
                if (odabranaPoruka != null)
                {
                    var messageBox = MessageBox.Show("Jeste li sigurni da zelite obrisati ovu poruku?",
                        "Message for user", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (messageBox == DialogResult.OK)
                    {
                        baza.KorisniciPoruke.Remove(odabranaPoruka);
                        baza.SaveChanges();
                        UcitajPoruke();
                    }
                }
            }
            else
            {
                frmNovaPoruka frmNovaPoruka = new frmNovaPoruka(odabraniKorisnik, odabranaPoruka);
                frmNovaPoruka.ShowDialog();
            }
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPoruka frmNovaPoruka = new frmNovaPoruka(odabraniKorisnik);
            frmNovaPoruka.ShowDialog();

            if (frmNovaPoruka.DialogResult == DialogResult.OK)
                UcitajPoruke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            //var poruke = dgvKorisniciPoruke.DataSource as List<KorisnikPoruka>;

            var podaciZaPrint = new dtoIzvjestaj()
            {
                ImePrezime = $"{odabraniKorisnik.Ime} {odabraniKorisnik.Prezime}",
                Poruke = dgvKorisniciPoruke.DataSource as List<KorisnikPoruka>
            };

            frmIzvjestaj frmIzvjestaj = new frmIzvjestaj(podaciZaPrint);
            frmIzvjestaj.ShowDialog();
        }
    }

    public class dtoIzvjestaj
    {
        public string ImePrezime {  get; set; }
        public List<KorisnikPoruka> Poruke { get; set; }
    }
}
