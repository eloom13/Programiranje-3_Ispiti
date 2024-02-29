using FIT.Data;
using FIT.WinForms.IspitIBXXXXXX;
using FIT.WinForms.IspitIBXXXXXX.Izvjestaj;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaj : Form
    {
        private Student student;
        private dtoIzvjestaj podaciZaPrint;

        public frmIzvjestaj(Student student, dtoIzvjestaj podaciZaPrint)
        {
            InitializeComponent();
            this.student = student;
            this.podaciZaPrint = podaciZaPrint;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var tabela = new dsDLWMS.dsPredmetiDataTable();

            foreach(var item in podaciZaPrint.polozeniPredmeti)
            {
                var red = tabela.NewdsPredmetiRow();
                red.ImePrezime = student.ToString();
                red.Predmet = item.Predmet.ToString();
                red.Ocjena = item.Ocjena.ToString();
                red.DatumPolaganja = item.DatumPolaganja.ToString();
                tabela.Rows.Add(red);
            }

            foreach (var item in podaciZaPrint.nepolozeniPredmeti)
            {
                var red = tabela.NewdsPredmetiRow();
                red.ImePrezime = student.ToString();
                red.Predmet = item.Naziv.ToString();
                red.Ocjena = "NIJE POLOZENO";
                red.DatumPolaganja = "NIJE POLOZENO";
                tabela.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsPolozeniPredmeti";
            rds.Value = tabela;


            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
