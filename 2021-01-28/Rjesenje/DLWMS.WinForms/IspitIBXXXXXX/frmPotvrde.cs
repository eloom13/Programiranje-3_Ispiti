using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmPotvrde : Form
    {
        private DLWMSDbContext baza = new DLWMSDbContext();

        public frmPotvrde()
        {
            InitializeComponent();
            dgvStudentiPoruke.AutoGenerateColumns = false;
        }

        private void frmPotvrde_Load(object sender, EventArgs e)
        {
            UcitajPotvrde();
        }

        private void UcitajPotvrde()
        {
            var lista = baza.StudentiPotvrde.Include(sp => sp.Student).ToList();

            dgvStudentiPoruke.DataSource = null;
            dgvStudentiPoruke.DataSource = lista;
            lblTrenutnoPotvrda.Text = lista.Count.ToString();
        }

        private async void btnObrisiPotvrde_Click(object sender, EventArgs e)
        {
            if (baza.StudentiPotvrde.Any())
            {
                var message = MessageBox.Show("Da li želite obrisati poruke?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (message == DialogResult.OK)
                {
                    await Task.Run(() =>
                    {
                        baza.StudentiPotvrde.RemoveRange(baza.StudentiPotvrde);
                        baza.SaveChanges();
                        BeginInvoke(UcitajPotvrde);
                    });
                }
            }
            else
            {
                MessageBox.Show("Nema potvrda za brisanje!");
            }
        }

        private async void btnGenerisiPotvrde_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBrojPotvrda.Text, out int n))
            {
                var studenti = baza.Studenti.ToList();
                Random rand = new Random();

                await Task.Run(() =>
                {
                    for (int i = 0; i < n; i++)
                    {
                        int toSkip = rand.Next(studenti.Count);
                        var student = studenti[toSkip];

                        var potvrda = new StudentPotvrda()
                        {
                            StudentId = student.Id,
                            Datum = DateTime.Now,
                            Izdata = Convert.ToBoolean(rand.Next(0, 2)),
                            Svrha = $"Stipendija {i}"
                        };

                        baza.StudentiPotvrde.Add(potvrda);
                        baza.SaveChanges();

                        // Osvježi prikaz nakon svake dodane potvrde
                        BeginInvoke(UcitajPotvrde);
                        Thread.Sleep(200);
                    }
                    /* BEZ CEKANJA 200ms
                    baza.SaveChanges();
                    BeginInvoke(UcitajPotvrde);
                    */
                });
            }
            else
            {
                MessageBox.Show("Neispravan unos!");
            }
        }

        private void SaveCSV(string putanja)
        {
            using (StreamWriter sw = File.AppendText(putanja))
            {
                foreach (var potvrda in baza.StudentiPotvrde)
                {
                    sw.WriteLine(potvrda.Id + "," + potvrda.Student + "," + potvrda.Svrha + "," + potvrda.Datum + "," + potvrda.Izdata);
                }

                sw.Close();
            }
        }

        private void btnSpasiUFajl_Click(object sender, EventArgs e)
        {
            SaveCSV(@"Potvrde.csv");
        }
    }
}
