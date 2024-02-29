using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
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

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmPretraga : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        List<Student> _studenti;

        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajGodineStudija();
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            int godinaStudijaFilter = int.Parse(cmbGodinaStudija.Text);
            string filterImePrezime = txtFilterImePrezime.Text.ToLower();

            _studenti= baza.Studenti
                .Where(s =>
                    (string.IsNullOrEmpty(filterImePrezime) ||
                    s.Ime.ToLower().Contains(filterImePrezime) ||
                    s.Prezime.ToLower().Contains(filterImePrezime)) &&
                    (s.GodinaStudija.Oznaka == godinaStudijaFilter))
                .ToList();


            if (_studenti != null)
            {
                DataTable tblStudenti = new DataTable();
                tblStudenti.Columns.Add("ImePrezime");
                tblStudenti.Columns.Add("GodinaStudija");
                tblStudenti.Columns.Add("Prosjek");

                for (int i = 0; i < _studenti.Count; i++)
                {
                    var student = _studenti[i];
                    List<StudentPredmet> studentiPredmeti = baza.StudentiPredmeti
                        .Where(x => x.StudentId == student.Id)
                        .ToList();

                    DataRow red = tblStudenti.NewRow();
                    red["ImePrezime"] = student;
                    red["GodinaStudija"] = student.GodinaStudija;
                    red["Prosjek"] = studentiPredmeti.Count == 0 ? 5 : studentiPredmeti.Average(x => x.Ocjena);
                    tblStudenti.Rows.Add(red);
                }

                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = tblStudenti;
            }

            else
                dgvPretraga.DataSource = null;

        }


        private void UcitajGodineStudija()
        {
            var lista = baza.GodineStudija.ToList();
            cmbGodinaStudija.DataSource = lista;
            cmbGodinaStudija.DisplayMember = "Oznaka";
            cmbGodinaStudija.ValueMember = "Id";
        }

        private void txtFilterImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == 3) 
            {
                int index = dgvPretraga.SelectedRows[0].Index;  //int index = dgvPretraga.SelectedCells[0].RowIndex;
                var student = _studenti[index];
                frmKonsultacije frmKonsultacije = new frmKonsultacije(student);
                frmKonsultacije.ShowDialog();
            }
        }
    }
}
