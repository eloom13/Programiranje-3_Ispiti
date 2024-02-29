using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    [Table("Korisnici")]
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Spol Spol { get; set; }
        public int SpolId { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Admin { get; set; }
    }
}
