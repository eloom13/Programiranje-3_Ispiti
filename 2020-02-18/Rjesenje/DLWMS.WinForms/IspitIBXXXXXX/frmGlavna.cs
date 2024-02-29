using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmGlavna : Form
    {
        public string Sadrzaj {  get; set; }

        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnGodineStudija_Click(object sender, EventArgs e)
        {
            frmGodineStudija frmGodineStudija = new frmGodineStudija();
            frmGodineStudija.ShowDialog();
        }

        private void btnPolozeniPredmeti_Click(object sender, EventArgs e)
        {
            frmKorisniciPolozeniPredmeti frmPolozeniPredmeti = new frmKorisniciPolozeniPredmeti();
            frmPolozeniPredmeti.ShowDialog();
        }

        private void PrikaziSadrzaj(long sum)
        {
            txtThread.Text = sum.ToString();
        }

        private void IzracunajOpseg()
        {
            if (int.TryParse(txtThread.Text, out int n))
            {
                long sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                    // Simulacija računanja - možete dodati kratku pauzu ovdje ako je potrebno
                    Thread.Sleep(10);
                }

                BeginInvoke(() => PrikaziSadrzaj(sum));
            }
            else
                MessageBox.Show("Unesite validan broj.");
            
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            Thread opseg = new Thread(IzracunajOpseg);
            opseg.Start();
        }
    }
}
