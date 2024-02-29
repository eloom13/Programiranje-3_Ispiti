using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    public class StudentCovidTest
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public DateTime Datum { get; set; }
        public string Rezultat { get; set; }
        public bool Dostavljen { get; set; }
    }
}
