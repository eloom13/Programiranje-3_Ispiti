using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
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
    public partial class frmPretragaIBXXXXXX : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        List<PolozenPredmetIBXXXXXX> _polozeniPredmeti = new List<PolozenPredmetIBXXXXXX>();
        public frmPretragaIBXXXXXX()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIBXXXXXX_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            cmbOcjenaOd.SelectedIndex = 0;
            cmbOcjenaDo.SelectedIndex = 4;
        }

        private void UcitajPodatke()
        {
            var InputOcjenaOd = int.TryParse(cmbOcjenaOd.Text, out int ocjenaOd);
            var InputOcjenaDo = int.TryParse(cmbOcjenaDo.Text, out int ocjenaDo);
            var datumOd = dtpOd.Value;
            var datumDo = dtpDo.Value;

            _polozeniPredmeti = baza.PolozeniPredmeti.Include(pp => pp.Student).Include(pp => pp.Predmet)
                .Where(pp =>
                    (pp.Ocjena >= ocjenaOd && pp.Ocjena <= ocjenaDo) &&
                    (pp.DatumPolaganja >= datumOd && pp.DatumPolaganja <= datumDo))
                .ToList();

            foreach (var polozen in _polozeniPredmeti)
            {
                /*
                var student = baza.Studenti.Where(s => s.Id == polozen.StudentId).FirstOrDefault();

                polozen.Indeks = student.Indeks;
                polozen.ImePrezime = student.ImePrezime;
                */
            }

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = _polozeniPredmeti;
            ProvjeriTabelu();
        }

        private void ProvjeriTabelu()
        {
            if (dgvPretraga.Rows.Count == 0)
                lblWarning.Text = $"U periodu od {dtpOd.Value} do {dtpDo.Value} ne psotoje evidentirane ocjene" +
                    $" u opsegu od {cmbOcjenaOd.Text} do {cmbOcjenaDo.Text} za bilo kojeg studenta";
            else
                lblWarning.Text = "";
        }

        private void cmbOcjenaOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbOcjenaDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                var _student = dgvPretraga.SelectedRows[0].DataBoundItem as PolozenPredmetIBXXXXXX;

                if(_student != null)
                {
                    frmPorukeIBXXXXXX frmPoruke = new frmPorukeIBXXXXXX(_student.Student);
                    frmPoruke.ShowDialog();
                }
            }
        }
    }
}
