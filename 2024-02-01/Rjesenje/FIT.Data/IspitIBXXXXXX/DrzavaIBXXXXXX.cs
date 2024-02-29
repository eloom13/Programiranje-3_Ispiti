using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIT.Data.IspitIBXXXXXX
{
    public class DrzavaIBXXXXXX
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public byte[] Zastava { get; set; }

        [NotMapped] public int BrojGradova { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
