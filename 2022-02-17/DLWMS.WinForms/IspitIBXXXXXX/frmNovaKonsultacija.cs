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
    public partial class frmNovaKonsultacija : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student student;

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

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var predmet = cmbPredmet.SelectedItem as Predmet;
                var novaKonsultacija = new StudentKonsultacije()
                {
                    StudentId = student.Id,
                    PredmetId = predmet.Id,
                    VrijemeOdrzavanja = dtpDatum.Value,
                    Napomena = txtNapomena.Text,
                };

                baza.StudentKonsultacije.Add(novaKonsultacija);
                baza.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cmbPredmet, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(dtpDatum, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                    Validator.ValidirajKontrolu(txtNapomena, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
