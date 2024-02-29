using FIT.Data;
using FIT.Infrastructure;
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
    public partial class frmStudentInfo : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student _student;

        public frmStudentInfo(Student student)
        {
            InitializeComponent();
            this._student = student;
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lblStudent.Text = _student.ImePrezime;
            
            var polozeni = baza.PolozeniPredmeti.Where(s=> s.StudentId == _student.Id).ToList();
            var prosjek = polozeni.Count == 0 ? 5 : polozeni.Average(x => x.Ocjena);
            lblProsjek.Text = $"Prosjek: {prosjek}";

            pbSlika.Image = Helpers.Ekstenzije.ToImage(_student.Slika);
        }
    }
}
