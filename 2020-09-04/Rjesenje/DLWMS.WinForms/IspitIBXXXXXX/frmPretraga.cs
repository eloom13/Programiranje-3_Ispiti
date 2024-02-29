using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmPretraga : Form
    {
        private readonly DLWMSDbContext baza = new DLWMSDbContext();

        public frmPretraga()
        {
            InitializeComponent();
            dgvKorisniciPredmeti.AutoGenerateColumns = false;
        }

        private void frmPretragaBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var filter = txtFilter.Text.ToLower();

            var filteredList = baza.KorisniciPredmeti
                .Include(k => k.Korisnik)
                .Include(k => k.Predmet)
                .Where(k => k.Predmet.Naziv.ToLower().Contains(filter))
                .ToList();

            lblProsjek.Text = filteredList.Any() ? filteredList.Average(x => x.Ocjena).ToString() : "0";
            dgvKorisniciPredmeti.DataSource = filteredList;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvKorisniciPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var odabraniKorisnik = dgvKorisniciPredmeti.SelectedRows[0].DataBoundItem as KorisnikPredmet;

                if (odabraniKorisnik != null)
                {
                    frmPoruke frmPorukeBrojIndeksa = new frmPoruke(odabraniKorisnik.Korisnik); // saljemo Korisnika
                    frmPorukeBrojIndeksa.ShowDialog();
                }
            }
        }

        private void btnSumiraj_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtThread.Text, out int n))
            {
                Thread suma = new Thread(() =>
                {
                    int suma = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        suma += i;
                        Thread.Sleep(100);
                    }
                    BeginInvoke(() => { lblSuma.Text = suma.ToString(); });
                });

                suma.Start();
            }

            else
            {
                MessageBox.Show("Unesite validan broj!");
                txtThread.Text = string.Empty;
            }
        }
    }
}
