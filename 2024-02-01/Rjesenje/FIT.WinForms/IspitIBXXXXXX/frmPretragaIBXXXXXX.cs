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
        DLWMSDbContext baza = new DLWMSDbContext();
        List<Student> _studenti = new List<Student>();
        public frmPretragaIBXXXXXX()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIBXXXXXX_Load(object sender, EventArgs e)
        {
            UcitajDrzave();
            UcitajGradove();
            cmbDrzava.SelectedIndex = 0;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var grad = cmbGrad.SelectedItem as GradIBXXXXXX;

            _studenti = baza.Studenti
                .Where(s => s.GradId == grad.Id)
                .ToList();

            foreach (var student in _studenti)
            {
                var polozeniPredmeti = baza.PolozeniPredmeti.Where(pp => pp.StudentId == student.Id).ToList();

                student.Prosjek = polozeniPredmeti.Count() == 0 ? 5 : polozeniPredmeti.Average(x => x.Ocjena);

                /*
                var gradStudenta = baza.GradoviIBXXXXXX.FirstOrDefault(g => g.Id == student.GradId);

                var drzavaStudenta = baza.DrzaveIBXXXXXX.FirstOrDefault(d => d.Id == gradStudenta.DrzavaId);

                student.Drzava = drzavaStudenta.Naziv.ToString();
                */
            }

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = _studenti;
        }

        private void UcitajGradove()
        {
            var drzava = cmbDrzava.SelectedItem as DrzavaIBXXXXXX;

            cmbGrad.DataSource = baza.GradoviIBXXXXXX.Where(g => g.DrzavaId == drzava.Id).ToList();
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "Id";
        }

        private void UcitajDrzave()
        {
            cmbDrzava.DataSource = baza.DrzaveIBXXXXXX.ToList();

            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "Id";
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajGradove();
        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
    }
}
