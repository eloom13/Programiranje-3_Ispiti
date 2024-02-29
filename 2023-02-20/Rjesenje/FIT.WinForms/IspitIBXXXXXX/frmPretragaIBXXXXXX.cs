using FIT.Data;
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
        List<StudentPredmetIBXXXXXX> _studenti = new List<StudentPredmetIBXXXXXX>();
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmPretragaIBXXXXXX()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            cmbOcjenaOd.SelectedIndex = 0;
            cmbOcjenaDo.SelectedIndex = 4;
        }

        private void UcitajPodatke()
        {
            var ocjenaOdInput = int.TryParse(cmbOcjenaOd.Text, out int ocjenaOd);
            var ocjenaDoInput = int.TryParse(cmbOcjenaDo.Text, out int ocjenaDo);
            var datumOd = dtpOd.Value;
            var datumDo = dtpDo.Value;

            _studenti = baza.PolozeniPredmeti.Include(sp => sp.Student).Include(sp => sp.Predmet)
                .Where(sp =>
                    (sp.Ocjena >= ocjenaOd && sp.Ocjena <= ocjenaDo) &&
                    (sp.DatumPolaganja >= datumOd && sp.DatumPolaganja <= datumDo))
                .ToList();

            var tabela = new DataTable();
            tabela.Columns.Add("Indeks");
            tabela.Columns.Add("ImePrezime");
            tabela.Columns.Add("Predmet");
            tabela.Columns.Add("Ocjena");
            tabela.Columns.Add("DatumPolaganja");

            if (_studenti.Count > 0)
            {
                for (int i = 0; i < _studenti.Count; i++)
                {
                    var student = _studenti[i];

                    var red = tabela.NewRow();
                    red["Indeks"] = student.Student.Indeks;
                    red["ImePrezime"] = student.Student.ImePrezime;
                    red["Predmet"] = student.Predmet;
                    red["Ocjena"] = student.Ocjena;
                    red["DatumPolaganja"] = student.DatumPolaganja;
                    tabela.Rows.Add(red);
                }
            }

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = tabela;
            ProvjeriTabelu();
        }

        private void ProvjeriTabelu()
        {
            if (dgvPretraga.Rows.Count > 0)
                lblInfo.Text = "";
            else
                lblInfo.Text = $"U periodu od {dtpOd.Value} do {dtpDo.Value} ne postoje evidentirane ocjene u opsegu od {cmbOcjenaOd.Text} do {cmbOcjenaDo.Text}";
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

        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var objekat = _studenti[index];

            if (objekat != null && e.ColumnIndex == 5) 
            {
                frmPorukeIBXXXXXX frmPoruke = new frmPorukeIBXXXXXX(objekat.Student);
                frmPoruke.ShowDialog();
            }
        }
    }
}
