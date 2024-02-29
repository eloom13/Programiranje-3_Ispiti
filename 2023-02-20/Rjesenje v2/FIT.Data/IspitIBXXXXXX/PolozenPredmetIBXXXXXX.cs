using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIBXXXXXX
{
    public class PolozenPredmetIBXXXXXX
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public PredmetIBXXXXXX Predmet {  get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena {  get; set; }

        [NotMapped] public string Indeks => Student.Indeks;
        [NotMapped] public string ImePrezime => Student.ImePrezime;
    }
}
