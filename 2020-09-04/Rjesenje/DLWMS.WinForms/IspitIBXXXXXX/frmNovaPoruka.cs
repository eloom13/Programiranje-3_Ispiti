using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovaPoruka : Form
    {
        private Korisnik odabraniKorisnik;
        private KorisnikPoruka odabranaPoruka;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmNovaPoruka(Korisnik odabraniKorisnik, KorisnikPoruka odabranaPoruka = null)
        {
            InitializeComponent();
            this.odabraniKorisnik = odabraniKorisnik;
            this.odabranaPoruka = odabranaPoruka;
        }

        private void frmNovaPoruka_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            txtPrimalac.Text = odabraniKorisnik.ToString();
            UcitajPoruku();
        }

        private void UcitajPoruku()
        {
            if (odabranaPoruka != null)
            {
                txtSadrzaj.Text = odabranaPoruka.Sadrzaj.ToString();
                pbSlika.Image = ImageHelper.FromByteToImage(odabranaPoruka.Slika);
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var edit = odabranaPoruka != null;

                if (edit)
                {
                    odabranaPoruka.KorisnikId = odabraniKorisnik.Id;
                    odabranaPoruka.Datum = DateTime.Now;
                    odabranaPoruka.Sadrzaj = txtSadrzaj.Text;
                    odabranaPoruka.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                    
                    baza.Entry(odabranaPoruka).State = EntityState.Modified;
                }

                else if (!edit)
                {
                    var novaPoruka = new KorisnikPoruka()
                    {
                        KorisnikId = odabraniKorisnik.Id,
                        Datum = DateTime.Now,
                        Sadrzaj = txtSadrzaj.Text,
                        Slika = ImageHelper.FromImageToByte(pbSlika.Image)
                    };

                    baza.KorisniciPoruke.Add(novaPoruka);
                }

                baza.SaveChanges();
                DialogResult = DialogResult.OK;
                UcitajPodatke();
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtSadrzaj, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
