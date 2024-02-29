﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIBXXXXXX
{
    public class PolozenPredmet
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId {  get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetId { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }

        //--------------------------------

        [NotMapped] public int Rb {  get; set; }
        [NotMapped] public string ImePrezime => Student.ImePrezime;
    }
}
