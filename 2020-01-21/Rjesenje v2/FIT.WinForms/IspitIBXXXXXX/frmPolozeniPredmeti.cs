using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmPolozeniPredmeti : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student _student;

        public frmPolozeniPredmeti(Student objekat)
        {
            InitializeComponent();
            dgvPolozeni.AutoGenerateColumns = false;
            this._student = objekat;
        }

        private void frmPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = baza.Predmeti.ToList();

            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void UcitajPodatke()
        {
            cmbOcjena.SelectedIndex = 0;

            var lista = baza.PolozeniPredmeti.Include(pp => pp.Predmet)
                .Where(pp => pp.StudentId == _student.Id)
                .ToList();

            dgvPolozeni.DataSource = null;
            dgvPolozeni.DataSource = lista;
        }

        private void cbNepolozeni_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNepolozeni.Checked)
                cmbPredmeti.DataSource = NepolozeniPredmetiStudenta(_student.Id);
            else
                UcitajPredmete();
        }

        private List<PredmetIBXXXXXX> NepolozeniPredmetiStudenta(int id)
        {
            var polozeniPredmeti = baza.PolozeniPredmeti
                .Where(pp => pp.StudentId == _student.Id)
                .Select(pp => pp.PredmetId)
                .ToList();

            var nepolozeniPredmeti = baza.Predmeti
                .Where(p => !polozeniPredmeti.Contains(p.Id))
                .ToList();

            return nepolozeniPredmeti;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as PredmetIBXXXXXX;

            var predmetPostoji = baza.PolozeniPredmeti
                .Where(pp => pp.StudentId == _student.Id && pp.PredmetId == predmet.Id)
                .Count() > 0;

            if (predmetPostoji)
            {
                MessageBox.Show("Predmet je vec dodat!");
                return;
            }

            else
            {
                var noviPredmet = new PolozenPredmetIBXXXXXX()
                {
                    StudentId = _student.Id,
                    PredmetId = predmet.Id,
                    Ocjena = int.Parse(cmbOcjena.Text),
                    DatumPolaganja = dtpDatum.Value,
                    Napomena = ""
                };

                baza.PolozeniPredmeti.Add(noviPredmet);
                baza.SaveChanges();
            }

            UcitajPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var podaciZaPrint = new dtoIzvjestaj()
            {
                polozeniPredmeti = dgvPolozeni.DataSource as List<PolozenPredmetIBXXXXXX>,
                nepolozeniPredmeti = NepolozeniPredmetiStudenta(_student.Id)
            };

            frmIzvjestaj frmIzvjestaj = new frmIzvjestaj(_student, podaciZaPrint);
            frmIzvjestaj.ShowDialog();
        }

        private async void btnRunAsync_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as PredmetIBXXXXXX;
            var ocjena = int.Parse(cmbOcjena.Text);

            await Task.Run(() =>
            {
                for (int i = 0; i < 500; i++)
                {
                    var noviPredmet = new PolozenPredmetIBXXXXXX()
                    {
                        StudentId = _student.Id,
                        PredmetId = predmet.Id,
                        Ocjena = ocjena,
                        DatumPolaganja = DateTime.Now,
                        Napomena = ""
                    };

                    baza.PolozeniPredmeti.Add(noviPredmet);
                    baza.SaveChanges();
                }
            });

            MessageBox.Show("Uspjesno dodato 500 polozenih predmeta");
            UcitajPodatke();
        }

    }

    public class dtoIzvjestaj 
    {
        public List<PolozenPredmetIBXXXXXX> polozeniPredmeti {  get; set; }
        public List<PredmetIBXXXXXX> nepolozeniPredmeti { get; set; }
    }
}
