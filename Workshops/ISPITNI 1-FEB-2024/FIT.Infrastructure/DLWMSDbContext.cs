using FIT.Data;
using FIT.Data.IspitIB0000000;
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
        public DbSet<DrzavaIB000000> DrzaveIB000000 { get; set; }
        public DbSet<GradIB000000> GradoviIB000000 { get; set; }
        public DbSet<PolozeniPredmetiIB0000000> PolozeniPredmeti { get; set; }
        public DbSet<PredmetiIB0000000> Predmeti { get; set; }
        public DbSet<SemestriIB000000> Semestri { get; set; }

    }
}