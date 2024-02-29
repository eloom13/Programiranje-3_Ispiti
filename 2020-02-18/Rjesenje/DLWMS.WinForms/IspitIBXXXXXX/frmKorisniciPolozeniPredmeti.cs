using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.Helpers;
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
        DLWMSDbContext baza = new DLWMSDbContext();
        private Korisnik _korisnik;

        public frmKorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvKorisniciPolozeniPredmeti.AutoGenerateColumns = false;
            _korisnik = baza.Korisnici.FirstOrDefault();
        }

        private void frmKorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajGodineStudija();
            UcitajPolozenePredmete();
            cmbOcjene.SelectedIndex = 0;
        }

        private void UcitajGodineStudija()
        {
            cmbGodineStudija.DataSource = baza.GodineStudija.ToList();
            cmbGodineStudija.DisplayMember = "Naziv";
            cmbGodineStudija.ValueMember = "Id";
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

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;
                var godinaStudija = cmbGodineStudija.SelectedItem as GodinaStudija;

                var predmetPostoji = baza.PolozeniPredmeti
                    .Where(p => p.GodinaStudijaId == godinaStudija.Id && p.PredmetId == predmet.Id)
                    .Count() > 0;

                if (predmetPostoji)
                {
                    MessageBox.Show($"Predmet {predmet} vec postoji", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var noviPolozeniPredmet = new PolozeniPredmet()
                {
                    KorisnikId = _korisnik.Id,
                    PredmetId = predmet.Id,
                    GodinaStudijaId = godinaStudija.Id,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    DatumPolaganja = dtpDatum.Value
                };

                baza.PolozeniPredmeti.Add(noviPolozeniPredmet);
                baza.SaveChanges();
            }

            UcitajPolozenePredmete();
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(cmbOcjene, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(cmbGodineStudija, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(dtpDatum, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var polozeni = dgvKorisniciPolozeniPredmeti.DataSource as List<PolozeniPredmet>;
            var odabranaGodina = cmbGodineStudija.Text;
            var polozeniZaGodinu = polozeni.Where(p => p.GodinaStudija.Naziv == odabranaGodina).ToList();

            var podaciZaPrint = new dtoUvjerenje()
            {
                ImePrezime = $"{_korisnik.Ime} {_korisnik.Prezime}",
                Polozeni = polozeniZaGodinu
            };
            
            frmIzvjestaj frmIzvjestaj = new frmIzvjestaj(podaciZaPrint);
            frmIzvjestaj.ShowDialog();
        }

        public class dtoUvjerenje
        {
            public string ImePrezime { get; set; }
            public List<PolozeniPredmet> Polozeni { get; set; }
        }
    }
}
