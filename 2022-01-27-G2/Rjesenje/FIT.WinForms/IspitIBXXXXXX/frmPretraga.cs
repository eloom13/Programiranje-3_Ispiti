using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
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
    public partial class frmPretraga : Form
    {
        List<PolozenPredmet> _polozeniPredmeti = new List<PolozenPredmet>();
        DLWMSDbContext baza = new DLWMSDbContext();
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
            var ocjenaInput = int.TryParse(cmbOcjena.Text, out int ocjena);

            _polozeniPredmeti = baza.PolozeniPredmeti
                                    .Include(pp => pp.Predmet)
                                    .Include(pp => pp.Student)
                                    .Where(pp => ocjena == 0 || pp.Ocjena <= ocjena)
                                    .ToList();
            var broj = 1;

            foreach (var item in _polozeniPredmeti)
            {
                item.Rb = broj++;
            }

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = _polozeniPredmeti;
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = dgvPretraga.DataSource as List<PolozenPredmet>;

            var podaciZaPrint = new dtoIzvjestaj
            {
                polozeniPredmeti = lista
            };

            frmIzvjestaji frmIzvjestaji = new frmIzvjestaji(podaciZaPrint);
            frmIzvjestaji.ShowDialog();
        }

        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var objekat = dgvPretraga.SelectedRows[0].DataBoundItem as PolozenPredmet;

            if(e.ColumnIndex == 5  && objekat != null)
            {
                frmSeminarski frmSeminarski = new frmSeminarski(objekat);
                frmSeminarski.ShowDialog();
            }
        }
    }

    public class dtoIzvjestaj
    {
       public List<PolozenPredmet> polozeniPredmeti { get; set; }
    }
}
