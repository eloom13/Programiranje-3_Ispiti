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
    public partial class frmPretraga : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        string NazivPredmetaFilter = "";
        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvPretraga.DataSource = null;

            var lista = baza.StudentiPredmeti
                .Include(s => s.Student)
                .Include(s => s.Predmet)
                .Where(s => NazivPredmetaFilter == "" ||
                       s.Predmet.Naziv.ToLower().Contains(NazivPredmetaFilter.ToLower()))
                .ToList();

            dgvPretraga.DataSource = lista;

            Text = $"Ukupno zapisa: {lista.Count}";
        }

        private void txtFilterNazivPredmeta_TextChanged(object sender, EventArgs e)
        {
            NazivPredmetaFilter = txtFilterNazivPredmeta.Text;
            UcitajPodatke();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var message = MessageBox.Show("Da li ste sigurni da zelite obrisati poruku?", "Question", MessageBoxButtons.OKCancel);
                var predmet = dgvPretraga.SelectedRows[0].DataBoundItem as StudentPredmet;

                if (message == DialogResult.OK)
                {
                    baza.StudentiPredmeti.Remove(predmet);
                    baza.SaveChanges();
                    UcitajPodatke();
                }
            }

            if (e.ColumnIndex == 5)
            {
                var odabraniStudent = dgvPretraga.SelectedRows[0].DataBoundItem as StudentPredmet;

                frmStudentiSlike frmStudentiSlike = new frmStudentiSlike(odabraniStudent.Student);
                frmStudentiSlike.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = dgvPretraga.DataSource as List<StudentPredmet>;
            var podaciZaPrint = new dtoIzvjestaj()
            {
                StudentiPredmeti = lista,
            };

            frmReport frmReport = new frmReport(podaciZaPrint);
            frmReport.ShowDialog();
        }

        private void btnSumiraj_Click(object sender, EventArgs e)
        {
            var suma = 0;

            if(int.TryParse(txtOd.Text, out int k) && int.TryParse(txtDo.Text, out int n))
            {
                Thread sumiraj = new Thread(() =>
                {
                    for(int i = k; i <= n; i++) 
                        suma+= i;
                    BeginInvoke(() => PrikaziSadrzaj(suma));
                });
                sumiraj.Start();
            }
            else
            {
                MessageBox.Show("Unos nije ispravan!");
                txtOd.Clear();
                txtDo.Clear();
                txtSuma.Clear();
            }
        }

        private void PrikaziSadrzaj(int suma)
        {
            txtSuma.Text = suma.ToString();
        }
    }

    public class dtoIzvjestaj 
    {
        public List<StudentPredmet> StudentiPredmeti {  get; set; }
    }
}
