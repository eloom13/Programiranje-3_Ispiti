using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    [Table("PolozeniPredmeti")]
    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public int KorisnikId { get; set; }
        public GodinaStudija GodinaStudija { get; set; }
        public int GodinaStudijaId { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetId { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public int Ocjena { get; set; }
    }
}
