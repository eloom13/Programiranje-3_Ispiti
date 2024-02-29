using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
using DLWMS.WinForms.IspitIBXXXXXX;
using Microsoft.Reporting.WinForms;
using static DLWMS.WinForms.IspitIBXXXXXX.frmKorisniciPolozeniPredmeti;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private dtoUvjerenjeOPolozenim podaciZaPrint;
        private Korisnik korisnik;
        DLWMSDbContext baza = new DLWMSDbContext();
      
        public frmIzvjestaji(dtoUvjerenjeOPolozenim podaciZaPrint, Korisnik korisnik = null)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;
            this.korisnik = korisnik;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pImePrezime", podaciZaPrint.ImePrezime));

            // 1. Nacin
                /*
                var tabela = new List<object>();

                int redniBroj = 1;

                // Dodavanje položenih predmeta u izvještaj
                foreach (var polozeni in podaciZaPrint.Polozeni)
                {
                    tabela.Add(new
                    {
                        Rb = redniBroj.ToString(),
                        Naziv = polozeni.Predmet.Naziv,
                        Ocjena = polozeni.Ocjena.ToString(),
                        Datum = polozeni.DatumPolaganja.ToString(),
                    });

                    redniBroj++;
                }

                // Dodavanje nepoloženih predmeta u izvještaj
                foreach (var nepolozeni in podaciZaPrint.Nepolozeni)
                {
                    tabela.Add(new
                    {
                        Rb = redniBroj.ToString(),
                        Naziv = nepolozeni.Naziv,
                        Ocjena = "NIJE POLOŽENO",
                        Datum = "NIJE POLOŽENO",
                    });

                    redniBroj++;
                }
                */

         
            // 2. Nacin, bez korstenja listi u dtoUvjerenje
            List<object> tabela = new List<object>();
            int i = 0;
            foreach (var polozeni in baza.Predmeti)
            {
                var podaci = baza.PolozeniPredmeti
                    .Where(x => x.Predmet.Id == polozeni.Id && x.KorisnikId == korisnik.Id)
                    .Select(y => new { y.Ocjena, y.DatumPolaganja })
                    .FirstOrDefault();

                tabela.Add(new
                {
                    Rb = i++,
                    Naziv = polozeni.Naziv,
                    Ocjena = podaci?.Ocjena.ToString() ?? "Nije polozeno", 
                    Datum = podaci?.DatumPolaganja.ToString() ?? "Nije polozeno"
                });
            }

            var rds = new ReportDataSource();
            rds.Name = "dsPredmeti";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }


    }
}
