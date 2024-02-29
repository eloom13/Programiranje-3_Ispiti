using DLWMS.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.Entiteti
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmeti
    {
        public int Id { get; set; }
        public  Predmet Predmet { get; set; }
        public  Student Student { get; set; }
        public int PredmetId { get; set; }
        public int StudentId { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
