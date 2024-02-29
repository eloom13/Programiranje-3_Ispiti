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
            string filterStatus = cmbFilterStatus.Text;
            bool filterStatusParsed = true;

            if (filterStatus == "Aktivan")
                filterStatusParsed = true;
            else if (filterStatus == "Neaktivan")
                filterStatusParsed = false;

            _studenti = baza.Studenti
                .Where(s =>
                    (string.IsNullOrEmpty(filterEmail) ||
                    s.Email.ToLower().Contains(filterEmail)) &&
                    (filterStatus == "Svi" ||
                    s.Aktivan == filterStatusParsed))
                .ToList();

            if (_studenti != null)
            {
                var tabela = new DataTable();
                tabela.Columns.Add("ImePrezime");
                tabela.Columns.Add("Email");
                tabela.Columns.Add("Status");
                tabela.Columns.Add("Prosjek");

                for (int i = 0; i < _studenti.Count; i++)
                {
                    var student = _studenti[i];
                    List<PolozeniPredmet> studentiPolozeniPredmeti = baza.PolozeniPredmeti
                        .Where(x => x.StudentId == student.Id)
                        .ToList();

                    DataRow red = tabela.NewRow();
                    red["ImePrezime"] = student;
                    red["Email"] = student.Email;
                    red["Status"] = student.Aktivan;
                    red["Prosjek"] = studentiPolozeniPredmeti.Count == 0 ? 5 : studentiPolozeniPredmeti.Average(x => x.Ocjena);
                    tabela.Rows.Add(red);
                }

                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = tabela;
            }

            else
                dgvPretraga.DataSource = null;
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
