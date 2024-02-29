using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIBXXXXXX
{
    public class PredmetSeminarski
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet {  get; set; }
        public int StudentId {  get; set; }
        public int PredmetId {  get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
    }
}
