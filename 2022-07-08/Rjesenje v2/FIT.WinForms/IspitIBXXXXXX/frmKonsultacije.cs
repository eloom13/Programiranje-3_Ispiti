using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using FIT.WinForms.IspitIBXXXXXX.Izvjestaj;
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
    public partial class frmKonsultacije : Form
    {
        private Student _student;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmKonsultacije(Student student)
        {
            InitializeComponent();
            this._student = student;
            dgvKonsultacije.AutoGenerateColumns = false;
        }

        private void frmKonsultacije_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmet.DataSource = baza.Predmeti.ToList();

            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.ValueMember = "Id";
        }

        private void UcitajPodatke()
        {
            lblStudent.Text = _student.ToString();

            var lista = baza.StudentKonsultacije
                .Include(x => x.Student)
                .Include(x => x.Predmet)
                .Where(x => x.StudentId == _student.Id)
                .ToList();

            dgvKonsultacije.DataSource = null;
            dgvKonsultacije.DataSource = lista;
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            frmNovaKonsultacija frmNovaKonsultacija = new frmNovaKonsultacija(_student);
            if (frmNovaKonsultacija.ShowDialog() == DialogResult.OK)
            {
                frmNovaKonsultacija.Close();
                UcitajPodatke();
            }
        }

        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var poruka = MessageBox.Show("Da li ste sigurni da zelite obrisati poruku?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                var konsultacija = dgvKonsultacije.SelectedRows[0].DataBoundItem as Konsultacija;

                if (poruka == DialogResult.OK)
                {
                    var today = DateTime.Today;

                    if (konsultacija.VrijemeOdrzavanja > today)
                    {
                        baza.Remove(konsultacija);
                        baza.SaveChanges();
                        UcitajPodatke();
                    }

                    else
                        MessageBox.Show("Nemoguce brisanje realizovanih konsultacija!");
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = dgvKonsultacije.DataSource as List<Konsultacija>;

            var podaciZaPrint = new dtoUvjerenje()
            {
                polozeniPredmeti = lista
            };

            frmReport frmReport = new frmReport(podaciZaPrint);
            frmReport.ShowDialog();
        }

        private async void btnDodajAsync_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBrojZahtjeva.Text, out int n))
            {
                var predmet = cmbPredmet.SelectedItem as Predmet;
                string info = "";

                await Task.Run(() => {
                    for (int i = 0; i < n; i++)
                    {
                        info = $"Za {_student} dodat novi zahtjev sa konsultacijama -> {predmet} {DateTime.Now} {Environment.NewLine}";
                        Thread.Sleep(500);
                        BeginInvoke(() => { txtInfo.Text += info; });
                    }
                });
                MessageBox.Show($"Uspjesno ste dodali {txtBrojZahtjeva.Text} zahtjeva!");
            }
        }
    }

    public class dtoUvjerenje
    {
        public List<Konsultacija> polozeniPredmeti { get; set; }
    }
}
