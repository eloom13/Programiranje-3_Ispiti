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
    public partial class frmKorisnikSlikePregled : Form
    {
        private Korisnik _korisnik;
        private List<Image> listaSlika = new List<Image>();
        private int trenutnaSlikaIndex = 0;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmKorisnikSlikePregled(Korisnik odabraniKorisnik)
        {
            InitializeComponent();
            this._korisnik = odabraniKorisnik;
        }

        private void frmKorisnikSlikePregled_Load(object sender, EventArgs e)
        {
            UcitajSliku();
        }

        private void UcitajSliku()
        {
            var slikeKorisnika = baza.KorisniciSlike
                                    .Where(s => s.KorisnikId == _korisnik.Id)
                                    .ToList();

            foreach (var slikaKorisnika in slikeKorisnika)
            {
                byte[] binarniPodaciSlike = slikaKorisnika.Slika;
                if (binarniPodaciSlike != null && binarniPodaciSlike.Length > 0)
                {
                    Image slika = ImageHelper.FromByteToImage(binarniPodaciSlike);
                    listaSlika.Add(slika);
                }
            }

            if (listaSlika.Count > 0)
                PrikaziSliku(trenutnaSlikaIndex); // Prikazuje prvu sliku

        }

        private void PrikaziSliku(int index)
        {
            if (index >= 0 && index < listaSlika.Count)
            {
                pbSlika.Image = listaSlika[index];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (trenutnaSlikaIndex < listaSlika.Count - 1)
            {
                trenutnaSlikaIndex++;
                PrikaziSliku(trenutnaSlikaIndex);
            }
            else
            {
                MessageBox.Show("Nema više slika.");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (trenutnaSlikaIndex > 0)
            {
                trenutnaSlikaIndex--;
                PrikaziSliku(trenutnaSlikaIndex);
            }
            else
            {
                MessageBox.Show("Nema prethodnih slika.");
            }
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image novaSlika = Image.FromFile(openFileDialog1.FileName);

                    byte[] binarniPodaciNoveSlike = ImageHelper.FromImageToByte(novaSlika);

                    // Provjera postoje li već isti binarni podaci slike za trenutnog korisnika
                    bool postojiIstaSlika = baza.KorisniciSlike
                                                .Any(s => s.KorisnikId == _korisnik.Id && s.Slika.SequenceEqual(binarniPodaciNoveSlike));

                    if (!postojiIstaSlika)
                    {
                        KorisnikSlika novaKorisnikSlika = new KorisnikSlika
                        {
                            KorisnikId = _korisnik.Id,
                            Slika = binarniPodaciNoveSlike
                        };

                        // Dodavanje novog entiteta u bazu
                        baza.KorisniciSlike.Add(novaKorisnikSlika);
                        baza.SaveChanges();

                        // Ponovno učitavanje slika korisnika
                        UcitajSliku();
                    }
                    else
                        MessageBox.Show("Korisnik već posjeduje istu sliku.");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom dodavanja slike: {ex.Message}");
                }
            }
        }


    }
}
