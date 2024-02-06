using FIT.Data;
using FIT.Data.IspitIB180079;
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
        public DbSet<PredmetiIB180079> Predmeti { get; set; }
        public DbSet<SemestriIB180079> Semestri { get; set; }
        public DbSet<PolozeniPredmetiIB180079> PolozeniPredmeti { get; set; }
        public DbSet<DrzaveIB180079> DrzaveIB180079 { get; set; }
        public DbSet<GradoviIB180079> GradoviIB180079 { get; set; }

    }
}