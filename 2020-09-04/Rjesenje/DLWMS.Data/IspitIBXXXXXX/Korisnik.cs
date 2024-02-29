using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    public class Korisnik
    {
        public int Id {  get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public byte[] Slika { get; set; }
        public int Admin {  get; set; }
        public Spol Spol { get; set; }
        public int SpolId { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}"; 
        }
    }
}
