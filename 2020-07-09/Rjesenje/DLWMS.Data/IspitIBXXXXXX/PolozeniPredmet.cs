using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetId { get; set; }
    }
}
