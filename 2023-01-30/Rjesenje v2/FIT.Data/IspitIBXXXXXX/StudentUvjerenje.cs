using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIBXXXXXX
{
    public class StudentUvjerenje
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public string Svrha {  get; set; }
        public string Vrsta { get; set; }
        public byte[] Uplatnica { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public bool Printano { get; set; }
    }
}
