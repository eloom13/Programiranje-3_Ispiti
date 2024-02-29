using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class StudentScanIspita
    {
        public int Id {  get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetId { get; set; }
        public string Napomena { get; set; }
        public byte[] Scan {  get; set; }
        public bool Varanje { get; set; }
    }
}
