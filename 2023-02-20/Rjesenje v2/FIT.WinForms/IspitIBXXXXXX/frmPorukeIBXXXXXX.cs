using FIT.Data;
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
    public partial class frmPorukeIBXXXXXX : Form
    {
        private Student student;

        public frmPorukeIBXXXXXX(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmPorukeIBXXXXXX_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lblStudentInfo.Text = $"Lista poruka za {student.ImePrezime}";         
        }
    }
}
