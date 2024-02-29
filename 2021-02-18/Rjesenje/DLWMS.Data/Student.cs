using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Spol Spol { get; set; }
        public int SpolId { get; set; }
        public bool Aktivan { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        public string ImePrezime
        {
            get { return Ime + " " + Prezime; }
        }
    }  
}