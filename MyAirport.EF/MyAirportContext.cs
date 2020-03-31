using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PSB.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {

//        public MyAirportContext(DbContextOptions<MyAirportContext> options) : base(options){}

        public DbSet<Bagage> Bagages { get; set; }
        public DbSet<Vol> Vols { get; set; }


        // public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Airport;Integrated Security=True");
        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Airport;Integrated Security=True");
            
        optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Airport"].ConnectionString);
        }*/
    }
}
