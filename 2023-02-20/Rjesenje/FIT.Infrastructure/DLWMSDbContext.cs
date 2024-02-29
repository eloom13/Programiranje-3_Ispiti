using FIT.Data;
using FIT.Data.IspitIBXXXXXX;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<PredmetIBXXXXXX> Predmeti { get; set; }
        public DbSet<StudentPredmetIBXXXXXX> PolozeniPredmeti { get; set; }
        public DbSet<PorukaIBXXXXXX> StudentiPorukeIBXXXXXX { get; set; }

    }
}