using DLWMS.Data;
using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmPretraga : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        public List<Statistika> Statistika;
        string filterImePrezime = "";

        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            var studenti = baza.StudentiPredmeti
                .Where(x => filterImePrezime == "" ||
                            (x.Student.Ime.ToLower().Contains(filterImePrezime.ToLower()) ||
                            x.Student.Prezime.ToLower().Contains(filterImePrezime.ToLower())))
                .Select(s => s.Student)
                .Distinct()
                .ToList();

            var statistika = new List<Statistika>();

            foreach (var student in studenti)
            {
                statistika.Add(new Statistika()
                {
                    Student = student,
                    Polozeni = string.Join("; ", baza.StudentiPredmeti
                        .Where(x => x.Student.Id == student.Id)
                        .Select(x => x.Predmet.Naziv)
                        .ToList()),
                    Broj = baza.StudentiPredmeti.Count(x => x.Student.Id == student.Id),
                    Prosjek = baza.StudentiPredmeti.Where(x => x.Student.Id == student.Id).Average(x => x.Ocjena),
                });
            }

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = statistika;

            lblProsjek.Text = statistika.Count != 0 ? statistika.Average(x => x.Prosjek).ToString() : "0";
            lblNajveciProsjek.Text = NajveciProsjek(statistika);
        }

        private string NajveciProsjek(List<Statistika> statistika)
        {
            if (statistika == null || statistika.Count == 0)
                return "0";

            var studentSaNajvecimProsjekom = statistika.OrderByDescending(s => s.Prosjek).FirstOrDefault();

            return studentSaNajvecimProsjekom != null ? studentSaNajvecimProsjekom.Student.ToString() : "N/A";
        }

        private void txtImePrezimeFilter_TextChanged(object sender, EventArgs e)
        {
            filterImePrezime = txtImePrezimeFilter.Text;
            UcitajStudente();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = dgvPretraga.SelectedRows[0].DataBoundItem as Statistika;

            if (e.ColumnIndex == 4)
            {
                if (odabraniStudent != null)
                {
                    frmScanIspita scanIspita = new frmScanIspita(odabraniStudent.Student);
                    scanIspita.ShowDialog();
                }
            }
        }

        private void btnGenerisiInfo_Click(object sender, EventArgs e)
        {
            string tekst = txtTekst.Text;

            Thread thread = new Thread(() => BrojZnakova(tekst));
            thread.Start();
        }

        private void BrojZnakova(string tekst)
        {
            int brojSamoglasnika = 0;
            int brojSuglasnika = 0;
            int brojSpecijalnihZnakova = 0;

            foreach (char znak in tekst)
            {
                if (char.IsLetter(znak))
                {
                    if ("aeiouAEIOU".Contains(znak))
                    {
                        brojSamoglasnika++;
                    }
                    else
                    {
                        brojSuglasnika++;
                    }
                }
                else if ("?!<>*".Contains(znak))
                {
                    brojSpecijalnihZnakova++;
                }
            }
            BeginInvoke(()=>Prikazi(brojSamoglasnika, brojSuglasnika, brojSpecijalnihZnakova));
        }

        private void Prikazi(int brojSamoglasnika, int brojSuglasnika, int brojSpecijalnihZnakova)
        {
            lblBrojSamoglasnika.Text = brojSamoglasnika.ToString();
            lblBrojSuglasnika.Text = brojSuglasnika.ToString();
            lblBrojZnakova.Text = brojSpecijalnihZnakova.ToString();
        }
    }
}
