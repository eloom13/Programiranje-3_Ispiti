using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    public class KorisnikPredmet
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetId { get; set;}
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
