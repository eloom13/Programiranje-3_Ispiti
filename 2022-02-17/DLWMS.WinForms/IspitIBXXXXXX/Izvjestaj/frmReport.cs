using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIBXXXXXX.Izvjestaj
{
    public partial class frmReport : Form
    {
        private dtoIzvjestaj podaciZaPrint;

        public frmReport(dtoIzvjestaj podaciZaPrint)
        {
            InitializeComponent();
            this.podaciZaPrint = podaciZaPrint;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var student = "";
            var ukupno = "";

            var tabela = new dsDLWMS.KonsultacijeDataTable();
            for (int i = 0; i < podaciZaPrint.StudentiKonsultacije.Count; i++) 
            {
                var red = tabela.NewKonsultacijeRow();
                red.Rb = i.ToString();
                red.Predmet = podaciZaPrint.StudentiKonsultacije[i].Predmet.ToString();
                red.Vrijeme = podaciZaPrint.StudentiKonsultacije[i].VrijemeOdrzavanja.ToString();
                red.Napomena = podaciZaPrint.StudentiKonsultacije[i].Napomena.ToString();
                tabela.AddKonsultacijeRow(red);

                student = podaciZaPrint.StudentiKonsultacije[i].Student.ToString();
                ukupno = podaciZaPrint.StudentiKonsultacije.Count.ToString();
            }

            rpc.Add(new ReportParameter("pImePrezime", student));
            rpc.Add(new ReportParameter("pUkupnoZahtjeva", ukupno));

            var rds = new ReportDataSource();
            rds.Name = "dsStudentiKonsultacije";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
