using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.IspitIBXXXXXX.Izvjestaj;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIBXXXXXX
{
    public partial class frmStudenti : Form
    {
        private DLWMSDbContext baza = new DLWMSDbContext();
        private List<Student> listaStudenata;
        private List<Student> filtriraniStudenti; // New list to hold filtered data
        private string filterImePrezime = "";
        private string filterGodina = "Sve";
        private int filterGodinaParsed;
        private string filterAktivnost = "Svi";
        private bool filterAktivnostParsed;

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajComboBox();
            //UcitajStudente();
        }

        private void UcitajStudente()
        {
            listaStudenata = baza.Studenti
                    .Include(s => s.Spol)
                    .Include(s => s.GodinaStudija)
                    .ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = listaStudenata;

            lblBrojStudenata.Text = listaStudenata.Count.ToString();
        }

        
        
            private void FiltrirajStudente()
            {
                if (Validiraj())
                {
                    if (string.IsNullOrWhiteSpace(filterImePrezime))
                    {
                        dgvStudenti.DataSource = null;
                        lblBrojStudenata.Text = "0";
                        return;
                    }

                    filtriraniStudenti = listaStudenata
                        .Where(x =>
                            (x.Ime.ToLower().Contains(filterImePrezime.ToLower()) ||
                             x.Prezime.ToLower().Contains(filterImePrezime.ToLower())) &&
                            (filterGodina == "Sve" || x.GodinaStudija.Broj == filterGodinaParsed) &&
                            (filterAktivnost == "Svi" || x.Aktivan == filterAktivnostParsed))
                        .ToList();

                    dgvStudenti.DataSource = null;
                    dgvStudenti.DataSource = filtriraniStudenti;

                    lblBrojStudenata.Text = filtriraniStudenti.Count.ToString();
                }

                else
                    UcitajStudente();
            }

        

        private void UcitajComboBox()
        {
            // Postavljanje izvora podataka za ComboBox-ove
            cmbGodineStudija.DataSource = new List<string>() { "Sve", "1", "2", "3" };
            cmbAktivnosti.DataSource = new List<string>() { "Svi", "Aktivni", "Neaktivi" };
        }

        private bool Validiraj()
        {
            if (string.IsNullOrEmpty(txtFilterImePrezime.Text))
            {
                errorProvider1.SetError(txtFilterImePrezime, "Unos imena ili prezimena je obavezan");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private void txtFilterImePrezime_TextChanged(object sender, EventArgs e)
        {
            filterImePrezime = txtFilterImePrezime.Text;
            FiltrirajStudente();
        }

        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterGodina = cmbGodineStudija.Text;

            if (filterGodina != "Sve")
                filterGodinaParsed = int.Parse(filterGodina);

            FiltrirajStudente();
        }

        private void cmbAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterAktivnost = cmbAktivnosti.Text;

            if (filterAktivnost != "Svi")
            {
                filterAktivnostParsed = filterAktivnost == "Aktivni";
            }

            FiltrirajStudente();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = filtriraniStudenti ?? listaStudenata;

            var podaciZaPrint = new dtoUvjerenje()
            {
                Studenti = lista,
            };

            frmizvjestaj frmizvjestaj = new frmizvjestaj(podaciZaPrint);
            frmizvjestaj.ShowDialog();
        }
    }

    public class dtoUvjerenje
    {
        public List<Student> Studenti { get; set; }
    }
}
