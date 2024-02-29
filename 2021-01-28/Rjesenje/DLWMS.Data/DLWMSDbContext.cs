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
        public DbSet<GodinaStudija> GodineStudija { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<StudentPotvrda> StudentiPotvrde { get; set; }
    }
}
