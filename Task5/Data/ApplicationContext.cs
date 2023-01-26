using Microsoft.EntityFrameworkCore;
using Task5.Data.Entites;

namespace Task5.Data
{
    public class ApplicationContext : DbContext
    {
        private readonly IConfiguration _config;

        public DbSet<Cities> Cities { get; set; }

        public DbSet<CityTypes> CityTypes { get; set; }

        public DbSet<Identifiers> Identifiers { get; set; }

        public DbSet<Names> Names { get; set; }

        public DbSet<PhoneTypes> PhoneTypes { get; set; }

        public DbSet<Regions> Regions { get; set; }

        public DbSet<Streets> Streets { get; set; }

        public DbSet<StreetTypes> StreetTypes { get; set; }

        public DbSet<Surnames> Surnames { get; set;}

        public ApplicationContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config.GetConnectionString("ConnetctionString"));
        }
    }
}
