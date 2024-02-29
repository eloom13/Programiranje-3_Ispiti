using DLWMS.Data;
using DLWMS.Data.IspitIBXXXXXX;
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
    public partial class frmKorisnici : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            UcitajKorisnike();
        }

        private void UcitajKorisnike(List<Korisnik> korisnici = null)
        {
            var lista = baza.Korisnici.Include(s => s.Spol).ToList();

            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = korisnici ?? lista;
        }
    }
}
