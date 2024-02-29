using FIT.WinForms.IspitIBXXXXXX.Izvjestaji;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.IspitIBXXXXXX
{
    public partial class frmIzvjestaji : Form
    {
        private dtoIzvjestaj podaciZaPrint;

        public frmIzvjestaji(dtoIzvjestaj podaciZaPrint)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var tabela = new dsDLWMS.dsPretragaDataTable();
            var broj = 1;
            var info = "";
            var prosjek = 0;
            var suma = 0;
            var brojac = 0;

            foreach (var item in podaciZaPrint.polozeniPredmeti)
            {
                
                var red = tabela.NewdsPretragaRow();
                red.Rb = broj++.ToString();
                red.ImePrezime = item.ImePrezime.ToString();
                red.Predmet = item.Predmet.Naziv.ToString();
                red.DatumPolaganja = item.DatumPolaganja.ToString();
                red.Ocjena = item.Ocjena.ToString();
                tabela.AdddsPretragaRow(red);
                brojac++;

                suma += item.Ocjena;
                prosjek = suma / brojac;
            }

            info = $"Ukupno polozeno {broj} prosjek: {prosjek}";
            
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("rpInfo", info));

            var rds = new ReportDataSource();
            rds.Name = "dsPretragaStudenti";
            rds.Value = tabela;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
