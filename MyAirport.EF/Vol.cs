using System;
using System.Collections.Generic;
using System.Text;

namespace PSB.MyAirport.EF
{
    public class Vol
    {
        public int VolId { get; set; }
        public int? Pax { get; set; }
        public DateTime Dhc { get; set; }
        public string Cie { get; set; }
        public string? Des { get; set; }
        public string? Imm { get; set; }
        public string Lig { get; set; }
        public string? Pkg { get; set; }
        public IEnumerable<Bagage> Bagages { get; set; }

        public Vol(string cie, string lig, DateTime dhc)
        {
            Cie = cie;
            Lig = lig;
            Dhc = dhc;
            Bagages = new List<Bagage>();
        }
    }
}
