﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIBXXXXXX
{
    public class GodinaStudija
    {
        public int Id { get; set; }
        public int Oznaka { get; set; }

        public override string ToString()
        {
            return Oznaka.ToString();
        }
    }
}
