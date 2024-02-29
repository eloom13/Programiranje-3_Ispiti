using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIBXXXXXX
{
    public partial class frmSeminarski : Form
    {
        private PolozenPredmet _objekat;
        DLWMSDbContext baza = new DLWMSDbContext();
        int trenutnaSlikaIndex = 0;
        List<Image> listaSlika = new List<Image>();

        public frmSeminarski(PolozenPredmet objekat)
        {
            InitializeComponent();
            this._objekat = objekat;
        }

        private void frmSeminarski_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            listaSlika.Clear();

            var slikeStudenta = baza.PredmetiSeminarski
                .Where(s=>s.StudentId == _objekat.StudentId)
                .ToList();

            foreach (var item in slikeStudenta)
            {
                var binarniPodaciSlike = item.Slika;

                if(binarniPodaciSlike != null)
                {
                    Image slika = Ekstenzije.ToImage(binarniPodaciSlike);
                    listaSlika.Add(slika);
                }
            }

            if(listaSlika.Count > 0)
                PrikaziSliku(trenutnaSlikaIndex);
        }

        private void PrikaziSliku(int index)
        {
            lblSlikeInfo.Text = $"Stranica {trenutnaSlikaIndex+1}/{listaSlika.Count}";
            lblOpis.Text = baza.PredmetiSeminarski.Skip(index).Take(1).FirstOrDefault().Opis;

            if(index >= 0 && index < listaSlika.Count)
                pbSlikaPregled.Image = listaSlika[index];
            
        }

        private void UcitajPodatke()
        {
            lblStudentInfo.Text = _objekat.Student.ImePrezime.ToString();
            lblPredmetInfo.Text = _objekat.Predmet.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var noviSeminarski = new PredmetSeminarski()
                {
                    StudentId = _objekat.Student.Id,
                    PredmetId = _objekat.Predmet.Id,
                    Slika = Ekstenzije.ToByteArray(pbSlika.Image),
                    Opis = txtOpis.Text,
                    Datum = DateTime.Now
                };

                baza.PredmetiSeminarski.Add(noviSeminarski);
                baza.SaveChanges();
            }

            UcitajSlike();
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtOpis, errorProvider1, Kljucevi.Warning) &&
                   Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.Warning);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
           if(trenutnaSlikaIndex > 0)
           {
                trenutnaSlikaIndex--;
                PrikaziSliku(trenutnaSlikaIndex);
           }

           else
            MessageBox.Show("Nema prethodnih slika!");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (trenutnaSlikaIndex < listaSlika.Count - 1)
            {
                trenutnaSlikaIndex++;
                PrikaziSliku(trenutnaSlikaIndex);
            }

            else
                MessageBox.Show("Nema vise slika!");
        }
    }
}
