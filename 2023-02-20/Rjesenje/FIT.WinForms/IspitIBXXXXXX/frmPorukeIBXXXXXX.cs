using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmPorukeIBXXXXXX : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student _student;

        public frmPorukeIBXXXXXX(Student student)
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
            this._student = student;
        }

        private void frmPorukeIBXXXXXX_Load(object sender, EventArgs e)
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

        private void ProvjeriTabelu()
        {
            if (dgvPoruke.Rows.Count > 0)
                btnDodaj.Enabled = true;
            else
                btnDodaj.Enabled = false;

            Text = $"Broj poruka -> {dgvPoruke.Rows.Count}";
        }

        private void UcitajPodatke()
        {
            lblInfo.Text = $"Poruke studenta {_student}";
         
            var today = DateTime.Today;

            var lista = baza.StudentiPorukeIBXXXXXX.Include(sp => sp.Predmet)
                .Where(sp => sp.StudentId == _student.Id && sp.Validnost >= today)
                .ToList();

            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = lista;

            ProvjeriTabelu();
        }

        private void dgvPoruke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var objekat = dgvPoruke.SelectedRows[0].DataBoundItem as PorukaIBXXXXXX;

            if (e.ColumnIndex == 4)
            {
                baza.Remove(objekat);
                baza.SaveChanges();
                UcitajPodatke();
            }
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIBXXXXXX frmNovaPoruka = new frmNovaPorukaIBXXXXXX(_student);

            if (frmNovaPoruka.ShowDialog() == DialogResult.OK)
            {
                frmNovaPoruka.Close();
                UcitajPodatke();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var objekat = dgvPoruke.DataSource as List<PorukaIBXXXXXX>;

            var podaciZaPrint = new dtoIzvjestaj()
            {
                Poruke = objekat,
                StudentiInfo = _student.ImePrezime
            };

            frmIzvjestaj frmIzvjestaj = new frmIzvjestaj(podaciZaPrint);
            frmIzvjestaj.ShowDialog();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtBrojPoruka.Text, out int n))
            {
                var predmet = cmbPredmet.SelectedItem as PredmetIBXXXXXX;
                var slika = baza.StudentiPorukeIBXXXXXX
                    .Where(sp => sp.StudentId == _student.Id)
                    .Select(sp => sp.Slika).First();

                await Task.Run(() => 
                {
                    string info = "";

                    for (int i = 0; i < n; i++)
                    {
                        var novaPoruka = new PorukaIBXXXXXX()
                        {
                           StudentId = _student.Id,
                           PredmetId = predmet.Id,
                           Validnost = dtpDatum.Value,
                           Slika = slika,
                           Sadrzaj = $"Generisana poruka {i}"
                        };

                        baza.StudentiPorukeIBXXXXXX.Add(novaPoruka);
                        baza.SaveChanges();

                        info = $"{dtpDatum.Value} -> generisana poruka za {_student.ImePrezime}" +
                        $" na predmetu {predmet.Naziv} {Environment.NewLine}";

                        Invoke(() =>
                        {
                            UcitajPodatke();
                            txtInfo.Text += info;
                            txtInfo.SelectionStart = txtInfo.Text.Length;
                            txtInfo.ScrollToCaret();
                        });

                        Thread.Sleep(300);
                    }
                });

                MessageBox.Show($"Uspjesno dodato {n} poruka");
            }

            else
                MessageBox.Show($"Neispravan unos");
        }
    }
}

    public class dtoIzvjestaj
    {
        public string StudentiInfo { get; set; }
        public List<PorukaIBXXXXXX> Poruke {  get; set; }
    }

