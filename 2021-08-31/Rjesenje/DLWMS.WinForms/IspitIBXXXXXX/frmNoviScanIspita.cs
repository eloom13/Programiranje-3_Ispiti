using DLWMS.Data;
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmNoviScanIspita : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student odabraniStudent;
        private StudentScanIspita odabraniScan;

        public frmNoviScanIspita(Student odabraniStudent, StudentScanIspita odabraniScan = null)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
            this.odabraniScan = odabraniScan;
        }

        private void frmNoviScanIspita_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            if (odabraniScan != null)
            {
                txtNapomena.Text = odabraniScan.Napomena.ToString();
                txtNapomena.Enabled = false;
                cmbPredmeti.Text = odabraniScan.Predmet.ToString();
                cmbPredmeti.Enabled = false;
                pbSlika.Image = ImageHelper.FromByteToImage(odabraniScan.Scan);
                pbSlika.Enabled = false;
                cbVaranje.Checked = odabraniScan.Varanje;
                cbVaranje.Enabled = false;
            }

            else
            {
                cmbPredmeti.DataSource = baza.Predmeti.ToList();

                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.ValueMember = "Id";
            }
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;

                    var noviScanIspita = new StudentScanIspita()
                    {
                        StudentId = odabraniStudent.Id,
                        PredmetId = predmet.Id,
                        Napomena = txtNapomena.Text,
                        Scan = ImageHelper.FromImageToByte(pbSlika.Image),
                        Varanje = cbVaranje.Checked,
                    };
                    baza.StudentiScanIspita.Add(noviScanIspita);

                DialogResult = DialogResult.OK;
                baza.SaveChanges();
            }
        }

        private bool Validiraj()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbPredmeti, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Helpers.Validator.ValidirajKontrolu(txtNapomena, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
                   Helpers.Validator.ValidirajKontrolu(pbSlika, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }
    }
}
