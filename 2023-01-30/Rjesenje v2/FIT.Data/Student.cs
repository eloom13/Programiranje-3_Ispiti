using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using FIT.Data.IspitIBXXXXXX;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public Spol Spol { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public int SemestarId { get; set; }
        public int SpolId { get; set; }

        public string ImePrezime => Ime + " " + Prezime;
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }

        //---------------------------------------------
        [NotMapped] public double Prosjek {  get; set; }

        [NotMapped] public string BrojIndeksa => Indeks;
    }
}
