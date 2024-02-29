using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.IspitIBXXXXXX.Izvjestaj;
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
    public partial class frmKonsultacije : Form
    {
        private Student _student;
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmKonsultacije(Student student)
        {
            InitializeComponent();
            dgvKonsultacije.AutoGenerateColumns = false;
            this._student = student;
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
                .Include(s => s.Student)
                .Include(s => s.Predmet)
                .Where(s => s.StudentId == _student.Id)
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
                var message = MessageBox.Show("Da li ste sigurni da zelite obrisati konsultaciju?", "Upozorenje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                var konsultacija = dgvKonsultacije.SelectedRows[0].DataBoundItem as StudentKonsultacije;

                if (message == DialogResult.OK)
                {
                    DateTime today = DateTime.Today;

                    if (konsultacija.VrijemeOdrzavanja.Date > today)
                    {
                        baza.StudentKonsultacije.Remove(konsultacija);
                        baza.SaveChanges();
                        UcitajPodatke();
                    }

                    else
                    {
                        MessageBox.Show("Nemoguce brisanje realizvanih konsultacija!");
                    }
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = dgvKonsultacije.DataSource as List<StudentKonsultacije>;
            var podaciZaPrint = new dtoIzvjestaj()
            {
                StudentiKonsultacije = lista,
            };

            frmReport frmReport = new frmReport(podaciZaPrint);
            frmReport.ShowDialog();
        }

        private async void btnDodajAsync_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtBrojZahtjeva.Text, out int n))
            {
                var predmet = cmbPredmet.SelectedItem as Predmet;
                string info = "";

                await Task.Run(() => {
                    for (int i = 0; i < n; i++) 
                    {
                        info = $"Za {_student} dodat novi zahtjev sa konsultacijama -> {predmet} {DateTime.Now} {Environment.NewLine}";
                        Thread.Sleep(500);
                        BeginInvoke(() => { txtSadrzaj.Text += info; });
                    }
                });
                MessageBox.Show($"Uspjesno ste dodali {txtBrojZahtjeva.Text} zahtjeva!");
            }
        }
    }

    public class dtoIzvjestaj
    {
        public List<StudentKonsultacije> StudentiKonsultacije {get; set; }
    }
}
