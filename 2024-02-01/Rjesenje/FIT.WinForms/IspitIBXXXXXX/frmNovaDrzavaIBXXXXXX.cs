using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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

namespace FIT.WinForms.IspitIBXXXXXX
{
    public partial class frmNovaDrzavaIBXXXXXX : Form
    {
        private DrzavaIBXXXXXX _drzava;
        DLWMSDbContext baza = new DLWMSDbContext();
        bool edit;

        public frmNovaDrzavaIBXXXXXX(DrzavaIBXXXXXX? _drzava = null)
        {
            InitializeComponent();
            this._drzava = _drzava;
            edit = _drzava != null;
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            edit = _drzava != null;

            if (ValidanUnos())
            {
                if (edit)
                {
                    _drzava.Naziv = txtNaziv.Text;
                    _drzava.Status = cbStatus.Checked;
                    _drzava.Zastava = Ekstenzije.ToByteArray(pbSlika.Image);
                    baza.Entry(_drzava).State = EntityState.Modified;
                }

                else if (!edit)
                {
                    var novaDrzava = new DrzavaIBXXXXXX()
                    {
                        Naziv = txtNaziv.Text,
                        Status = cbStatus.Checked,
                        Zastava = Ekstenzije.ToByteArray(pbSlika.Image)
                    };

                    baza.DrzaveIBXXXXXX.Add(novaDrzava);
                }

                baza.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.Warning) &&
                   Validator.ProvjeriUnos(txtNaziv, errorProvider1, Kljucevi.Warning) &&
                   Validator.ProvjeriUnos(cbStatus, errorProvider1, Kljucevi.Warning);
        }

        private void frmNovaDrzavaIBXXXXXX_Load(object sender, EventArgs e)
        {
            if (edit)
                UcitajDrzavu();
        }

        private void UcitajDrzavu()
        {
            txtNaziv.Text = _drzava.Naziv;
            cbStatus.Checked = _drzava.Status;
            pbSlika.Image = Ekstenzije.ToImage(_drzava.Zastava);
        }
    }
}
