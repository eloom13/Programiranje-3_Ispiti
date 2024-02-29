using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    public class KorisnikPoruka
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
    }
}
