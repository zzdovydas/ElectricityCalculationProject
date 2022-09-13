using ElectricityCalculationProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityCalculationProject.Contexts
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;

            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("APIDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
             .Entity<ElectricityData>()
             .Property(e => e.P_Diff)
             .UsePropertyAccessMode(PropertyAccessMode.Property);
        }

        public DbSet<ElectricityData> ElectricityData { get; set; }
    }
}
