using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Script.Data.Models;

namespace Script.Data.Database.SqlServer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string? connectionString = config
                .GetConnectionString("ConnectionString");

            optionsBuilder
                .UseSqlServer(connectionString);
        }

    }
}