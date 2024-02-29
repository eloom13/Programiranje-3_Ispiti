using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.IspitIBXXXXXX.Izvjestaj;
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
    public partial class frmCovidTest : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmCovidTest()
        {
            InitializeComponent();
            dgvRezultati.AutoGenerateColumns = false;
        }

        private void frmCovidTest_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajRezultate();
        }

        private void UcitajPodatke()
        {
            cmbStudenti.DataSource = baza.Studenti.ToList();
            cmbStudenti.DisplayMember = "ImePrezime";
            cmbStudenti.ValueMember = "Id";

            cmbRezultatTesta.SelectedIndex = 0;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var odabraniStudent = cmbStudenti.SelectedItem as Student;
            DateTime danas = DateTime.Today;
            bool vecPostoji = baza.StudentiCovidTestovi.Where(x => x.Datum.Date == danas && x.StudentId == odabraniStudent.Id).Count() > 0;

            if (vecPostoji)
            {
                MessageBox.Show("Rezultat vec postoji!");
                return;
            }

            var rezultat = new StudentCovidTest()
            {
                StudentId = odabraniStudent.Id,
                Datum = DateTime.Now,
                Rezultat = cmbRezultatTesta.SelectedItem.ToString(),
                Dostavljen = cbNalazDostavljen.Checked
            };

            baza.StudentiCovidTestovi.Add(rezultat);
            baza.SaveChanges();
            UcitajRezultate();
        }

        private bool RezultatVecPostoji()
        {
            throw new NotImplementedException();
        }

        private void UcitajRezultate()
        {
            dgvRezultati.DataSource = null;

            var lista = baza.StudentiCovidTestovi.ToList();
            dgvRezultati.DataSource = lista;

            lblUkupanBroj.Text = "Ukupan broj: " + (lista.Any() ? lista.Count.ToString() : "0");
        }

        private async void btnObrisiTestove_Click(object sender, EventArgs e)
        {
            if (baza.StudentiCovidTestovi.Any())
            {
                var message = MessageBox.Show("Da li zelite obrisati testove?", "Information", MessageBoxButtons.OKCancel);

                if (message == DialogResult.OK)
                {
                    await Task.Run(() =>
                    {
                        baza.StudentiCovidTestovi.RemoveRange(baza.StudentiCovidTestovi);
                        baza.SaveChanges();
                        BeginInvoke(UcitajRezultate);
                    });
                }
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBrojTestova.Text, out int n))
            {
                var studenti = baza.Studenti.ToList();
                Random rand = new Random();
                int brojac = 0;

                await Task.Run(() =>
                {
                    for (int i = 0; i < n; i++)
                    {
                        int toSkip = rand.Next(0, studenti.Count);
                        var student = studenti[toSkip];

                        var rezultatTestiranja = new StudentCovidTest()
                        {
                            StudentId = student.Id,
                            Datum = DateTime.Now,
                            Rezultat = rand.Next(0, 2) == 0 ? "Pozitivan" : "Negativan",
                            Dostavljen = Convert.ToBoolean(rand.Next(0, 2))
                        };
                        baza.StudentiCovidTestovi.Add(rezultatTestiranja);
                        brojac = i;
                    }

                    baza.SaveChanges();
                    BeginInvoke(UcitajRezultate);
                    MessageBox.Show($"Uspjesno generisano {brojac} rezultat testiranja");
                });
            }

            else
            {
                MessageBox.Show("Neispravan unos!");
                txtBrojTestova.Clear();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = dgvRezultati.DataSource as List<StudentCovidTest>;

            var podaciZaPrint = new dtoIzvjestaj()
            {
                Rezultati = lista,
            };

            frmIzvjestaj izvjestaj = new frmIzvjestaj(podaciZaPrint);
            izvjestaj.ShowDialog();
        }
    }

    public class dtoIzvjestaj
    {
        public List<StudentCovidTest> Rezultati { get; set;}
    }
}
