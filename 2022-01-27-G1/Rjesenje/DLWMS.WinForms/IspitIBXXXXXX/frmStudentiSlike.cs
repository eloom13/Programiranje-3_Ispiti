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
    public partial class frmStudentiSlike : Form
    {
        private Student student;
        DLWMSDbContext baza = new DLWMSDbContext();
        private int trenutnaSlikaIndex = 0;
        private List<Image> listaSLika = new List<Image>();

        public frmStudentiSlike(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var novaSlikaStudent = new StudentSlika()
                {
                    StudentId = student.Id,
                    Slika = ImageHelper.FromImageToByte(pbSlika.Image),
                    Datum = DateTime.Now,
                    Opis = txtOpis.Text
                };

                baza.StudentiSlike.Add(novaSlikaStudent);
                baza.SaveChanges();

                UcitajSlike();
                PrikaziSliku(trenutnaSlikaIndex);
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(pbSlika, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(txtOpis, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmStudentiSlike_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            listaSLika.Clear();

            var slikeStudenta = baza.StudentiSlike
                .Where(s => s.StudentId == student.Id)
                .ToList();

            foreach (var slikaStudenta in slikeStudenta)
            {
                byte[] binarniPodaciSlike = slikaStudenta.Slika;

                if (binarniPodaciSlike != null)
                {
                    Image slika = ImageHelper.FromByteToImage(binarniPodaciSlike);
                    listaSLika.Add(slika);
                }

                if (listaSLika.Count > 0)
                    PrikaziSliku(trenutnaSlikaIndex);
            }
        }

        private void PrikaziSliku(int index)
        {
            if (index >= 0 && index < listaSLika.Count)
            {
                pbPregledSlika.Image = listaSLika[index];

                lblOpis.Text = baza.StudentiSlike.Skip(index).Take(1).FirstOrDefault().Opis;
                lblDatum.Text = baza.StudentiSlike.Skip(index).Take(1).FirstOrDefault().Datum.ToShortDateString();
                lblPretraga.Text = $"{trenutnaSlikaIndex + 1}/{listaSLika.Count}";
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
                MessageBox.Show("Nema prethodnih slika.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(trenutnaSlikaIndex < listaSLika.Count - 1)
            {
                trenutnaSlikaIndex++;
                PrikaziSliku(trenutnaSlikaIndex);
            }
            else
                MessageBox.Show("Nema vise slika.");
        }
    }
}
