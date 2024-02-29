using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using FIT.WinForms.IspitIBXXXXXX.Report;
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
    public partial class frmUvjerenja : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student _student;

        public frmUvjerenja(Student student)
        {
            InitializeComponent();
            dgvUvjerenja.AutoGenerateColumns = false;
            this._student = student;
        }

        private void frmUvjerenja_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            ProvjeriButton();
            cmbVrsta.SelectedIndex = 0;
        }

        private void ProvjeriButton()
        {
            if (dgvUvjerenja.Rows.Count > 0)
                btnDodaj.Enabled = true;
            
            else
                btnDodaj.Enabled = false;
        }

        private void UcitajPodatke()
        {
            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = baza.StudentiUvjerenja.Where(s => s.StudentId == _student.Id).ToList();
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            frmNovoUvjerenje frmNovoUvjerenje = new frmNovoUvjerenje(_student);

            if (frmNovoUvjerenje.ShowDialog() == DialogResult.OK)
            {
                frmNovoUvjerenje.Close();
                UcitajPodatke();
            }

            ProvjeriButton();
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var objekat = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentUvjerenje;

            if (objekat != null)
            {
                if (e.ColumnIndex == 5)
                {
                    baza.Remove(objekat);
                    baza.SaveChanges();
                    UcitajPodatke();
                }

                if (e.ColumnIndex == 6)
                {
                    frmIzvjestaj frmIzvjestaj = new frmIzvjestaj(objekat, _student);
                    frmIzvjestaj.ShowDialog();

                    objekat.Printano = true;
                    baza.Entry(objekat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    baza.SaveChanges();
                    UcitajPodatke();
                }
            }

            ProvjeriButton();
        }
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbVrsta.Text != "" && txtSvrha.Text != "" && int.TryParse(txtBroj.Text, out int n))
            {
                var slika = baza.StudentiUvjerenja.Where(s => s.StudentId == _student.Id).Select(x => x.Uplatnica).FirstOrDefault();
                string vrsta = cmbVrsta.Text;

                await Task.Run(() =>
                {
                    string info = "";
                    
                    for (int i = 0; i < n; i++)
                    {
                        var novoUvjerenje = new StudentUvjerenje()
                        {
                            StudentId = _student.Id,
                            Vrsta = vrsta,
                            Svrha = txtSvrha.Text,
                            VrijemeKreiranja = DateTime.Now,
                            Uplatnica = slika,
                            Printano = false
                        };
                        baza.StudentiUvjerenja.Add(novoUvjerenje);
                        baza.SaveChanges();

                        info = $"Za {DateTime.Now} -> {vrsta} - {_student} {txtSvrha.Text} {Environment.NewLine}";
                        
                        
                        BeginInvoke(() =>
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
            {
                MessageBox.Show("Neispravan unos!");
            }
        }
    }
}
