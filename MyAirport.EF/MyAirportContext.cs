using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PSB.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
        public DbSet<Bagage> Bagage { get; set; }
        public DbSet<Vol> Vol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Airport;Integrated Security=True");
        }
    }
}
