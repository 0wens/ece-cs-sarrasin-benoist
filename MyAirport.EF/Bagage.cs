using System;
using System.Collections.Generic;
using System.Text;

namespace PSB.MyAirport.EF
{
    public class Bagage
    {
        public int BagageId { get; set; }
        public bool? Prioritaire { get; set; }
        public DateTime DateCreation { get; set; }
        public virtual Vol? Vol { get; set; }
        public string CodeIata { get; set; }
        public string? Classe { get; set; }
        public string? Sta { get; set; }
        public string? Ssur { get; set; }
        public string? Destination { get; set; }
        public string? Escale { get; set; }

        public Bagage(string codeIata, DateTime dateCreation)
        {
            CodeIata = codeIata;
            DateCreation = dateCreation;            
        }

    }
}
