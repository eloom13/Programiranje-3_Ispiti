using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
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
    public partial class frmPretraga : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        List<Student> _studenti = new List<Student>();

        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajSpolove();
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            string spol = cmbSpol.Text;
            var godinaoOd = dtpRodjenOd.Value;
            var godinaDo = dtpRodjenDo.Value;

            _studenti = baza.Studenti
                .Where(s =>
                    (s.Spol.Naziv == spol) &&
                    (s.DatumRodjenja >= godinaoOd && s.DatumRodjenja <= godinaDo))
                .ToList();

            var tabela = new DataTable();
            tabela.Columns.Add("BrojIndeksa");
            tabela.Columns.Add("ImePrezime");
            tabela.Columns.Add("Prosjek");
            tabela.Columns.Add("DatumRodjenja");
            tabela.Columns.Add("Aktivan");

            if (_studenti.Count > 0)
            {
                for (int i = 0; i < _studenti.Count; i++)
                {
                    var student = _studenti[i];
                    List<PolozeniPredmet> StudentiPolozeniPredmeti = baza.PolozeniPredmeti
                        .Where(x => x.StudentId == student.Id)
                        .ToList();

                    var red = tabela.NewRow();
                    red["ImePrezime"] = student.ToString();
                    red["BrojIndeksa"] = student.Indeks.ToString();
                    red["Prosjek"] = StudentiPolozeniPredmeti.Count == 0 ? 5 : StudentiPolozeniPredmeti.Average(x => x.Ocjena);
                    red["DatumRodjenja"] = student.DatumRodjenja.ToString();
                    red["Aktivan"] = student.Aktivan.ToString();
                    tabela.Rows.Add(red);
                }

                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = tabela;
            }
            ProvjeriTabelu();
        }

        private void ProvjeriTabelu()
        {
            if (dgvPretraga.Rows.Count <= 0)
                lblInfo.Text = $"Ne postoji niti jedan student {cmbSpol.Text} spola koji su rodeni u periodu " +
                    $"od {dtpRodjenOd.Value} do {dtpRodjenDo.Value} godine.";

            else
                lblInfo.Text = "";

        }

        private void UcitajSpolove()
        {
            cmbSpol.DataSource = baza.Spolovi.ToList();

            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpRodjenOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpRodjenDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var student = _studenti[index];

            if (e.ColumnIndex == 5)
            {
                frmUvjerenja frmUvjerenja = new frmUvjerenja(student);
                frmUvjerenja.ShowDialog();
            }

            else
            {
                frmStudentInfo frmStudentInfo = new frmStudentInfo(student);
                frmStudentInfo.ShowDialog();
            }
        }
    }
}
