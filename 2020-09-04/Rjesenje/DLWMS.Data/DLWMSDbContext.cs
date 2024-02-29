using DLWMS.Data.IspitIBXXXXXX;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class DLWMSDbContext : DbContext
    {
        private string dbPutanja;

	   public DLWMSDbContext()
	   {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSPutanja"].ConnectionString;
	   }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<KorisnikPredmet> KorisniciPredmeti { get; set; }
        public DbSet<KorisnikPoruka> KorisniciPoruke { get; set; }
    }
}
