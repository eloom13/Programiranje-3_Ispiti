using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using FIT.Infrastructure;
using System.Data;

namespace FIT.WinForms.IspitIBXXXXXX
{
    public partial class frmPretraga : Form
    {
        List<Student> _studenti = new List<Student>();
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            cmbFilterStatus.SelectedIndex = 0;
        }

        private void UcitajPodatke()
        {
            string filterEmail = txtFilterEmail.Text.ToLower();
            string aktivnost = cmbFilterStatus.Text;
            bool aktivan = true;

            if (aktivnost == "Aktivan")
                aktivan = true;
            else if(aktivnost == "Neaktivan")
                aktivan = false;

            _studenti = baza.Studenti
                .Where(s=>
                    (string.IsNullOrEmpty(filterEmail) ||
                    s.Email.ToLower().Contains(filterEmail)) &&
                    (aktivnost == "Svi" || 
                    s.Aktivan == aktivan))
                .ToList();


            foreach(var item in _studenti)
            {
                var prosjek = baza.PolozeniPredmeti.Where(pp => pp.StudentId == item.Id).ToList();

                item.Prosjek = prosjek.Count() == 0 ? 5 : prosjek.Average(x => x.Ocjena);
            }

            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = _studenti;
           
        }

        private void txtFilterEmail_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvPretraga.SelectedRows[0].Index;
            var student = _studenti[index];

            if(e.ColumnIndex == 4)
            {
                frmKonsultacije frmKonsultacije = new frmKonsultacije(student);
                frmKonsultacije.ShowDialog();
            }
        }
    }
}
