using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmGradoviIBXXXXXX : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private DrzavaIBXXXXXX? objekat;

        public frmGradoviIBXXXXXX(DrzavaIBXXXXXX? objekat)
        {
            InitializeComponent();
            dgvGradovi.AutoGenerateColumns = false;
            this.objekat = objekat;
        }

        private void frmGradoviIBXXXXXX_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            pbSlika.Image = Ekstenzije.ToImage(objekat.Zastava);
            lblDrzavaInfo.Text = objekat.ToString();

            var lista = baza.GradoviIBXXXXXX.Where(g => g.DrzavaId == objekat.Id).ToList();

            dgvGradovi.DataSource = null;
            dgvGradovi.DataSource = lista;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "" && txtNaziv.Text != " ")
            {
                if (baza.GradoviIBXXXXXX.Where(g => g.Naziv == txtNaziv.Text).Count() > 0)
                    MessageBox.Show("Taj naziv vec postoji!");

                else
                {
                    var noviGrad = new GradIBXXXXXX()
                    {
                        Status = true,
                        Naziv = txtNaziv.Text,
                        DrzavaId = objekat.Id,
                    };

                    baza.GradoviIBXXXXXX.Add(noviGrad);
                    baza.SaveChanges();
                    UcitajPodatke();
                }
            }
        }

        private void dgvGradovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var objekat = dgvGradovi.SelectedRows[0].DataBoundItem as GradIBXXXXXX;

                objekat.Status = !objekat.Status;
                baza.Entry(objekat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                baza.SaveChanges();
            }

            UcitajPodatke();
        }

        private void frmGradoviIBXXXXXX_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBrojGradova.Text, out int n))
            {
                await Task.Run(() =>
                {
                    string info = "";

                    for (int i = 0; i < n; i++)
                    {
                        var noviGrad = new GradIBXXXXXX()
                        {
                            DrzavaId = objekat.Id,
                            Status = cbStatus.Checked,
                            Naziv = $"Grad {i}",
                        };

                        baza.GradoviIBXXXXXX.Add(noviGrad);
                        baza.SaveChanges();

                        info = $"{DateTime.Now} dodat Grad {i} za drzavu {objekat} {Environment.NewLine}";

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

                MessageBox.Show($"Uspjesno dodato {n} zahtjeva");
            }

            else
                MessageBox.Show("Neispravan unos!");
        }
    }
}
