using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIBXXXXXX
{
    public class PorukaIBXXXXXX
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public PredmetIBXXXXXX Predmet { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public DateTime Validnost { get; set; }
        public string Sadrzaj {  get; set; }
        public byte[] Slika {  get; set; }
    }
}
