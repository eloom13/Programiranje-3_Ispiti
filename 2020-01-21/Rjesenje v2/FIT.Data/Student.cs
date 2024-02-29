using FIT.Data.IspitIBXXXXXX;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Admin { get; set; }        
        public int SemestarId { get; set; }
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }

        //-------------------------------------------

        public SpolIBXXXXXX Spol {  get; set; }
        public int SpolId { get; set; }
    }
}
