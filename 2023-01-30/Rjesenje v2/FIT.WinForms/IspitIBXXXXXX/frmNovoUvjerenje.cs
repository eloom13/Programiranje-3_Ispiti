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
    public partial class frmNovoUvjerenje : Form
    {
        private Student _student;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmNovoUvjerenje(Student student)
        {
            InitializeComponent();
            this._student = student;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                var novoUvjerenje = new StudentUvjerenje()
                {
                    StudentId = _student.Id,
                    Svrha = txtSvrhaRegulisanja.Text,
                    Vrsta = cmbVrstaUvjerenja.Text,
                    VrijemeKreiranja = DateTime.Now,
                    Printano = false,
                    Uplatnica = Helpers.Ekstenzije.ToByteArray(pbSlika.Image)
                };

                baza.StudentiUvjerenja.Add(novoUvjerenje);
                baza.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ProvjeriUnos(txtSvrhaRegulisanja, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Validator.ProvjeriUnos(cmbVrstaUvjerenja, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
