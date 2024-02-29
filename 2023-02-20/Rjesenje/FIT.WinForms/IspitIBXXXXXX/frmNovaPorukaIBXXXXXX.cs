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
    public partial class frmNovaPorukaIBXXXXXX : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student _student;

        public frmNovaPorukaIBXXXXXX(Student student)
        {
            InitializeComponent();
            this._student = student;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNovaPorukaIBXXXXXX_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmet.DataSource = baza.Predmeti.ToList();

            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.ValueMember = "Id";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var predmet = cmbPredmet.SelectedItem as PredmetIBXXXXXX;
                var novaPoruka = new PorukaIBXXXXXX()
                {
                    StudentId = _student.Id,
                    PredmetId = predmet.Id,
                    Sadrzaj = txtSadrzaj.Text,
                    Validnost = dtpDatum.Value,
                    Slika = Ekstenzije.ToByteArray(pbSlika.Image)
                };

                baza.StudentiPorukeIBXXXXXX.Add(novaPoruka);
                baza.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbPredmet, errorProvider1, Kljucevi.Warning) &&
                   Validator.ProvjeriUnos(txtSadrzaj, errorProvider1, Kljucevi.Warning) &&
                   Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.Warning);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
