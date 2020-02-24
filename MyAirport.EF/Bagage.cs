using System;
using System.Collections.Generic;
using System.Text;

namespace PSB.MyAirport.EF
{
    public class Bagage
    {
        public int BagageId { get; set; }
        public bool Prioritaire { get; set; }
        public DateTime DateCreation { get; set; }
        public Vol Vol { get; set; }
        public String CodeIata { get; set; }
        public String Classe { get; set; }
        public String Sta { get; set; }
        public String Ssur { get; set; }
        public String Destination { get; set; }
        public String Escale { get; set; }
    }
}
