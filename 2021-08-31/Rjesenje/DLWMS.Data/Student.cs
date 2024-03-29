﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string BrojIndeksa { get; set; }
        public string Ime {  get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
