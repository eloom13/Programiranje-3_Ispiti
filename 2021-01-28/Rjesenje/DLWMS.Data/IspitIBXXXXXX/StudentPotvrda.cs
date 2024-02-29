using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    public class StudentPotvrda
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public DateTime Datum { get; set; }
        public string Svrha { get; set; }
        public bool Izdata { get; set; }
    }
}
