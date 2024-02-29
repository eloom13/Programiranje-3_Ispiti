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
    public partial class frmGodineStudija : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private bool Edit;
        private GodinaStudija Odabrana;
        public frmGodineStudija()
        {
            InitializeComponent();
            dgvGodineStudija.AutoGenerateColumns = false;
        }

        private void frmGodineStudija_Load(object sender, EventArgs e)
        {
            UcitajGodineStudija();
        }

        private void UcitajGodineStudija(List<GodinaStudija> godineStudija = null)
        {
            var lista = baza.GodineStudija.ToList();
            dgvGodineStudija.DataSource = null;
            dgvGodineStudija.DataSource = godineStudija ?? lista;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var godinaVecPostoji = baza.GodineStudija.Where(g => g.Naziv == txtNaziv.Text).Count() > 0;

                if (godinaVecPostoji)
                {
                    MessageBox.Show($"{Resursi.Get(Kljucevi.PodatakVecPostoji)}", Resursi.Get(Kljucevi.Informacija),
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                    return;
                }

                if(!Edit)
                {
                    var novaGodinaStudija = new GodinaStudija()
                    {
                        Naziv = txtNaziv.Text,
                        Aktivna = cbAktivna.Checked,
                    };
                    baza.GodineStudija.Add(novaGodinaStudija);
                }
                else
                {
                    Odabrana.Naziv = txtNaziv.Text;
                    Odabrana.Aktivna = cbAktivna.Checked;
                    baza.Entry(Odabrana).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }

                baza.SaveChanges();
                UcitajGodineStudija();
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtNaziv, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void dgvGodineStudija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var editGodinaStudija = dgvGodineStudija.SelectedRows[0].DataBoundItem as GodinaStudija;

            if (editGodinaStudija != null)
            {
                txtNaziv.Text = editGodinaStudija.Naziv;
                cbAktivna.Checked = editGodinaStudija.Aktivna;
                //kad se odabere neka godina edit mode se postavi na true i godina se spasi u Odabranu
                Edit = true;
                Odabrana = editGodinaStudija;
            }
        }
    }
}
