using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Spol Spol { get; set; }
        public int SpolId { get; set; }
        public string KorisnickoIme { get; set; }
        public int Administrator { get; set; }
    }
}
