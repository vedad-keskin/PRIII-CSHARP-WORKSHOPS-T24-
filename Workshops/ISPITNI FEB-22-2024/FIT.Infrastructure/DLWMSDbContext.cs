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
    


















        public DbSet<Student> Studenti { get; set; } // ctrl + d
        public DbSet<PredmetiIB180079> Predmeti { get; set; }
        public DbSet<PolozeniPredmetiIB180079> PolozeniPredmeti { get; set; }
        public DbSet<ProstorijeIB180079> ProstorijeIB180079 { get; set; }
        public DbSet<NastavaIB180079> NastavaIB180079 { get; set; }
        public DbSet<PrisustvoIB180079> PrisustvoIB180079 { get; set; }

    }
}