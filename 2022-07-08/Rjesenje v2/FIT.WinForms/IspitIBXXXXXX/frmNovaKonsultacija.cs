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
    public partial class frmNovaKonsultacija : Form
    {
        private Student student;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmNovaKonsultacija(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmNovaKonsultacija_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmet.DataSource = baza.Predmeti.ToList();

            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.ValueMember = "Id";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(ValidanUnos())
            {
                var predmet = cmbPredmet.SelectedItem as Predmet;
                var novaKonsultacija = new Konsultacija()
                {
                    StudentId = student.Id,
                    PredmetId = predmet.Id,
                    VrijemeOdrzavanja = dtpVrijemeOdrzavanja.Value,
                    Napomena = txtNapomena.Text,
                };

                baza.StudentKonsultacije.Add(novaKonsultacija);
                baza.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbPredmet, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ProvjeriUnos(dtpVrijemeOdrzavanja, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ProvjeriUnos(txtNapomena, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }
    }
}
