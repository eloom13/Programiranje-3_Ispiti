using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.Izvjestaji;
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
    public partial class frmKorisniciPolozeniPredmeti : Form
    {
        private Korisnik _korisnik;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmKorisniciPolozeniPredmeti(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
            dgvKorisniciPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void frmKorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajPolozenePredmete();
            cmbOcjene.SelectedIndex = 0;
        }

        private void UcitajPolozenePredmete()
        {
            dgvKorisniciPolozeniPredmeti.DataSource = null;
            dgvKorisniciPolozeniPredmeti.DataSource = baza.PolozeniPredmeti.Where(pp => pp.KorisnikId == _korisnik.Id).ToList();
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = baza.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmet;
            var predmetPostoji = baza.PolozeniPredmeti.Where(polozeni => polozeni.PredmetId == predmet.Id && polozeni.KorisnikId == _korisnik.Id).Count() > 0;

            if (predmetPostoji)
            {
                MessageBox.Show($"Predmet {predmet} vec postoji", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var polozeniPredmet = new PolozeniPredmeti()
            {
                KorisnikId = _korisnik.Id,
                PredmetId = predmet.Id,
                Ocjena = int.Parse(cmbOcjene.Text),
                DatumPolaganja = dtpDatumPolaganja.Value
            };

            baza.PolozeniPredmeti.Add(polozeniPredmet);
            baza.SaveChanges();
            UcitajPolozenePredmete();
        }

        private void cbNepolozeniPredmeti_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNepolozeniPredmeti.Checked)
            {
                /*
                var nepolozeniPredmeti = baza.Predmeti
                .Where(predmet => !baza.PolozeniPredmeti
                .Any(polozio => polozio.PredmetId == predmet.Id && polozio.KorisnikId == _korisnik.Id))
                .ToList();
                */

                var polozeni = baza.PolozeniPredmeti
                    .Where(pp => pp.KorisnikId == _korisnik.Id)
                    .Select(pp => pp.PredmetId)
                    .ToList();

                var nepolozeniPredmeti = baza.Predmeti
                    .Where(p => !polozeni.Contains(p.Id))
                    .ToList();

                cmbPredmeti.DataSource = nepolozeniPredmeti;
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.ValueMember = "Id";
            }

            else
                UcitajPredmete();
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var podaciZaPrint = new dtoUvjerenjeOPolozenim()
            {
                ImePrezime = $"{_korisnik.Ime} {_korisnik.Prezime}",
                Polozeni = dgvKorisniciPolozeniPredmeti.DataSource as List<PolozeniPredmeti>,
                Nepolozeni = DohvatiNepolozenePredmete(_korisnik.Id) // Funkcija koja dohvaća nepoložene predmete
            };

            frmIzvjestaji frm = new frmIzvjestaji(podaciZaPrint, _korisnik);
            frm.ShowDialog();
        }

        private List<Predmet> DohvatiNepolozenePredmete(int korisnikId)
        {
            // Uzmite sve predmete koje je korisnik položio
            var polozeniPredmeti = baza.PolozeniPredmeti
                .Where(pp => pp.KorisnikId == korisnikId)
                .Select(pp => pp.PredmetId).ToList();

            // Filtrirajte sve predmete tako da uzmete one koje korisnik nije položio
            var nepolozeniPredmeti = baza.Predmeti
                .Where(p => !polozeniPredmeti.Contains(p.Id))
                .ToList();

            return nepolozeniPredmeti;
        }


        public class dtoUvjerenjeOPolozenim
        {
            public string ImePrezime { get; set; }
            public List<PolozeniPredmeti> Polozeni { get; set; }
            public List<Predmet> Nepolozeni { get; set; }
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            try
            {
                await DodajPolozenePredmete(_korisnik.Id);

                MessageBox.Show("Uspješno je dodano 500 predmeta");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom dodavanja predmeta: {ex.Message}");
            }
        }


        private async Task DodajPolozenePredmete(int korisnikId)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmet;

            for (int i = 0; i < 500; i++)
            {
                var polozeniPredmet = new PolozeniPredmeti()
                {
                    KorisnikId = korisnikId,
                    PredmetId = predmet.Id,
                    Ocjena = 6,
                    DatumPolaganja = DateTime.Now
                };

                baza.PolozeniPredmeti.Add(polozeniPredmet);
            }

            await baza.SaveChangesAsync();
        }

    }
}
