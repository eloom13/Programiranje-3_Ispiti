using FIT.Data;
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
            string filterImePrezime = txtNazivFilter.Text.ToLower();

            var listaStudenata = baza.Studenti.Include(s => s.Spol)
                .Where(s =>
                    string.IsNullOrEmpty(filterImePrezime) ||
                    s.Ime.ToLower().Contains(filterImePrezime) ||
                    s.Prezime.ToLower().Contains(filterImePrezime))
                .ToList();

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = listaStudenata;


            var studentIds = listaStudenata.Select(s => s.Id).ToList();

            var polozeniPredmeti = baza.PolozeniPredmeti
                .Where(pp => studentIds.Contains(pp.StudentId))
                .ToList();

            lblProsjek.Text = polozeniPredmeti.Count == 0 ? "0" : polozeniPredmeti.Average(pp => pp.Ocjena).ToString();
        }


        private void txtNazivFilter_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5) 
            {
                var objekat = dgvPretraga.SelectedRows[0].DataBoundItem as Student;

                if(objekat != null) 
                {
                    frmPolozeniPredmeti frmPolozeniPredmeti = new frmPolozeniPredmeti(objekat);
                    frmPolozeniPredmeti.ShowDialog();
                }
            }
        }
    }
}
