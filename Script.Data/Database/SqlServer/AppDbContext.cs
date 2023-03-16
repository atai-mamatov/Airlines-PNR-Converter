using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Script.Data.Models;
using System.Collections.Generic;
using System.IO;

namespace Script.Data.Database.SqlServer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<AirCompany> AirCompanies { get; set; }

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

        ////public void AddAirportsFromFile(string filePath)
        ////{
        ////    List<Airport> airportsToAdd = new List<Airport>();

        ////    using (StreamReader reader = new StreamReader(filePath))
        ////    {
        ////        while (!reader.EndOfStream)
        ////        {
        ////            string line = reader.ReadLine();
        ////            string[] values = line.Split(',');

        ////            Airport airport = new Airport
        ////            {
        ////                Name = values[0],
        ////                CountryName = values[1],
        ////                IATA = values[2]
        ////            };

        ////            airportsToAdd.Add(airport);
        ////        }
        ////    }

        //    Airports.AddRange(airportsToAdd);
        //    SaveChanges();
        //}

        //public void AddAirCompaniesFromFile(string filePath)
        //{
        //    List<AirCompany> airCompaniesToAdd = new List<AirCompany>();

        //    using (StreamReader reader = new StreamReader("Script / View / aircompanies.txt"))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            string line = reader.ReadLine();
        //            string[] values = line.Split(',');

        //            AirCompany airCompany = new AirCompany
        //            {
        //                Name = values[0],
        //                IATA = values[1]
        //            };

        //            airCompaniesToAdd.Add(airCompany);
        //        }
        //    }

        //    AirCompanies.AddRange(airCompaniesToAdd);
        //    SaveChanges();
        //}

        public void AddDataFromFiles(string airCompaniesFilePath)
        {
            AddAirCompaniesFromFile(airCompaniesFilePath);
        }

        private void AddAirCompaniesFromFile(string filePath)
        {
            var airCompanies = File.ReadAllLines(filePath)
                                    .Select(line => line.Split(","))
                                    .Select(fields => new AirCompany
                                    {
                                        Name = fields[0],
                                        IATA = fields[1]
                                    });

            using var db = new AppDbContext();
            db.AirCompanies.AddRange(airCompanies);
            db.SaveChanges();
        }










    }
}
