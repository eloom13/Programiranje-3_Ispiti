using DLWMS.Data;
using DLWMS.WinForms.Entiteti;
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
    public partial class frmScanIspita : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student odabraniStudent;

        public frmScanIspita(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
            dgvScan.AutoGenerateColumns = false;
        }

        private void frmScanIspita_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lblStudent.Text = odabraniStudent.ToString();

            dgvScan.DataSource = null;
            dgvScan.DataSource = baza.StudentiScanIspita
                .Include(ssi => ssi.Predmet)
                .Where(x => x.StudentId == odabraniStudent.Id)
                .ToList();
        }

        private void btnDodajScanIspita_Click(object sender, EventArgs e)
        {
            frmNoviScanIspita frmNoviScanIspita = new frmNoviScanIspita(odabraniStudent);
            frmNoviScanIspita.ShowDialog();
        }

        private void dgvScan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniScan = dgvScan.SelectedRows[0].DataBoundItem as StudentScanIspita;

            if (e.ColumnIndex == 4)
            {
                baza.StudentiScanIspita.Remove(odabraniScan);
                baza.SaveChanges();
                UcitajPodatke();
            }

            else
            {
                frmNoviScanIspita frmNoviScanIspita = new frmNoviScanIspita(odabraniStudent, odabraniScan);
                frmNoviScanIspita.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var scan = dgvScan.DataSource as List<StudentScanIspita>;

            var podaciZaPrint = new dtoIzvjestaj()
            {
                ScanIspita = scan
            };

            frmIzvjestaj frmIzvjestaj = new frmIzvjestaj(podaciZaPrint);
            frmIzvjestaj.ShowDialog();
        }
    }

    public class dtoIzvjestaj 
    {
        public List<StudentScanIspita> ScanIspita { get; set; }
    }
}
