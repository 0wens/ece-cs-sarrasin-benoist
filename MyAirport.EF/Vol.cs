using System;
using System.Collections.Generic;
using System.Text;

namespace PSB.MyAirport.EF
{
    public class Vol
    {
        public int VolId { get; set; }
        public int Pax { get; set; }
        public DateTime Dhc { get; set; }
        public String Cie { get; set; }
        public String Des { get; set; }
        public String Imm { get; set; }
        public String Lig { get; set; }
        public String Pkg { get; set; }
        public ICollection<Bagage> Bagages { get; set; }
    }
}
