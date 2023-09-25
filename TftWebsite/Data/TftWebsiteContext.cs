using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System;
using TftWebsite.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TftWebsite.Data
{
    public class TftWebsiteContext : DbContext
    {
        public DbSet<Champion> AllChampions { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<Team> Teams { get; set; }

        private const string LaptopconnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(LaptopconnectionString);
        }

    }
}
