using PSB.MyAirport.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
using System.Linq;

namespace PSB.MyAirport.App
{
    class Program
    {

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyAirportContext>();

            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Airport"].ConnectionString);

            using (var db = new MyAirportContext(optionsBuilder.Options))
//            using (var db = new MyAirportContext())
            {

                // Create
                Console.WriteLine("Création du vol LH1232");
                /*Vol v1 = new Vol
                {
                    Cie = "LH",
                    Des = "BKK",
                    Dhc = Convert.ToDateTime("14/01/2020 16:45"),
                    Imm = "RZ62",
                    Lig = "1232",
                    Pkg = "R52",
                    Pax = 238
                };*/
                Vol v1 = new Vol("LH", "1232", DateTime.Now) { Des = "BKK" };
                db.Add(v1);

                Console.WriteLine("creation du bagage 012387364501");
                /*Bagage b1 = new Bagage
                {
                    Classe = "Y",
                    CodeIata = "012387364501",
                    DateCreation = Convert.ToDateTime("14/01/2020 12:52"),
                    Destination = "BEG"
                }; */
                Bagage b1 = new Bagage("012387364501", DateTime.Now) { Destination = "BKK" };
                db.Add(b1);

                db.SaveChanges();
                Console.ReadLine();

                
                // Read
                Console.WriteLine("Voici la liste des vols disponibles");
                var vol = db.Vols
                    .OrderBy(v => v.Cie);
                foreach (var v in vol)
                {
                    Console.WriteLine($"Le vol {v.Cie}{v.Lig} N° {v.VolId} a destination de {v.Des} part à {v.Dhc} heure");
                }
                Console.ReadLine();

                // Update
                Console.WriteLine($"Le bagage {b1.BagageId} est modifié pour être rattaché au vol {v1.VolId} => {v1.Cie}{v1.Lig}");
                //b1.VolId = v1.VolId;
                db.SaveChanges();
                Console.ReadLine();

                // Delete vol et bagages du vol
                Console.WriteLine($"Suppression du vol {v1.VolId} => {v1.Cie}{v1.Lig}");
                db.Remove(v1);
                db.SaveChanges();
                Console.ReadLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
