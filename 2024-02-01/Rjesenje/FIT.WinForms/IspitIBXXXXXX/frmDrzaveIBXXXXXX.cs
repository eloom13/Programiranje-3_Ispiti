using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.IspitIBXXXXXX.IzvjestajIBXXXXXX;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIBXXXXXX
{
    public partial class frmDrzaveIBXXXXXX : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        List<DrzavaIBXXXXXX> _drzave = new List<DrzavaIBXXXXXX>();

        public frmDrzaveIBXXXXXX()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void frmDrzaveIBXXXXXX_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            _drzave = baza.DrzaveIBXXXXXX.ToList();

            foreach (var drzava in _drzave)
            {
                var brojGradova = baza.GradoviIBXXXXXX.
                    Where(g=> g.DrzavaId == drzava.Id)
                    .Count();
                drzava.BrojGradova = brojGradova;
            }

            dgvDrzave.DataSource = null;
            dgvDrzave.DataSource = _drzave;
        }

        private void dgvDrzave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            var objekat = dgvDrzave.Rows[e.RowIndex].DataBoundItem as DrzavaIBXXXXXX;

            if (objekat != null)
            {
                if (e.ColumnIndex != 4)
                {
                    frmNovaDrzavaIBXXXXXX frmNovaDrzava = new frmNovaDrzavaIBXXXXXX(objekat);
                    if (frmNovaDrzava.ShowDialog() == DialogResult.OK)
                        UcitajPodatke();
                }

                else
                {
                    frmGradoviIBXXXXXX frmGradovi = new frmGradoviIBXXXXXX(objekat);
                    if (frmGradovi.ShowDialog() == DialogResult.Cancel)
                        UcitajPodatke();
                }
            }
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            frmNovaDrzavaIBXXXXXX frmNovaDrzava = new frmNovaDrzavaIBXXXXXX();
            if (frmNovaDrzava.ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var selektovaneDrzave = dgvDrzave.DataSource as List<DrzavaIBXXXXXX>;

            var podaciZaPrint = new dtoIzvjestaj
            {
                Drzave = selektovaneDrzave
            };

            frmIzvjestajIBXXXXXX frmIzvjestaj = new frmIzvjestajIBXXXXXX(podaciZaPrint);
            frmIzvjestaj.ShowDialog();
        }
    }

    public class dtoIzvjestaj
    {
        public List<DrzavaIBXXXXXX> Drzave { get; set; }
    }
}
