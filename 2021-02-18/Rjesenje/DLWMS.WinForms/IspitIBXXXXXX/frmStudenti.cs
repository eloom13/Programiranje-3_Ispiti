using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.Helpers;
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
    public partial class frmStudenti : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        List<Student> filtriraniStudenti;

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            if (Validiraj())
            {
                var studenti = baza.Studenti.Include(s => s.Spol).ToList();
                var datumOD = dtpOd.Value;
                var datumDO = dtpDo.Value;
                string operacija = cmbOperator.Text;
                var ocjenaInput = int.TryParse(cmbOcjene.Text, out int ocjena);

                var filterPoDatumu = baza.StudentiPredmeti.Where(sp => sp.Datum >= datumOD && sp.Datum <= datumDO).ToList();
                var filterPoDatumuIOcjeni = filterPoOcjeni(filterPoDatumu, ocjena, operacija);

                var studentiIDs = filterPoDatumuIOcjeni.Select(x => x.Student.Id).ToList();

                /*
                var uniqueStudentIDs = new List<int>();
                foreach (var studentID in studentiIDs)
                {
                    if (!uniqueStudentIDs.Contains(studentID))
                    {
                        uniqueStudentIDs.Add(studentID);
                    }
                }
                */

                filtriraniStudenti = baza.Studenti.Where(x => studentiIDs.Contains(x.Id)).ToList();
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = filtriraniStudenti;
            }

            lblUkupanBrojStudenata.Text = filtriraniStudenti != null ? $"Broj studenata: {filtriraniStudenti.Count}" : "Broj studenata: 0";
        }


        private List<StudentPredmet> filterPoOcjeni(List<StudentPredmet> filterPoDatumu, int ocjena, string operacija)
        {
            switch (operacija)
            {
                case "=":
                    return filterPoDatumu.Where(sp => sp.Ocjena == ocjena).ToList();
                case ">":
                    return filterPoDatumu.Where(sp => sp.Ocjena > ocjena).ToList();
                case ">=":
                    return filterPoDatumu.Where(sp => sp.Ocjena >= ocjena).ToList();
                case "<":
                    return filterPoDatumu.Where(sp => sp.Ocjena < ocjena).ToList();
                case "<=":
                    return filterPoDatumu.Where(sp => sp.Ocjena <= ocjena).ToList();
                default:
                    return filterPoDatumu;
            }
        }

        private bool Validiraj()
        {
            return
                 Validator.ValidirajKontrolu(cmbOcjene, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                 Validator.ValidirajKontrolu(cmbOperator, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void UcitajComboBoxove()
        {
            cmbOperator.DataSource = new List<string>() { "=", ">", ">=", "<", "<=" };
            cmbOcjene.DataSource = new List<string>() { "6", "7", "8", "9", "10" };
        }

        private void cmbVrijednost_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cmbOcjene_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
    }
}
