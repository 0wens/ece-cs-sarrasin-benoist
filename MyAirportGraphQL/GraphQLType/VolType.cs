﻿using GraphQL.Types;
using PSB.MyAirport.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAirport.GraphQL.Type
{
    public class VolType : ObjectGraphType<Vol>
    {
        public VolType()
        {
            Field(x => x.Cie);
            Field(x => x.Des);
            Field(x => x.Dhc);
            Field(x => x.Imm);
            Field(x => x.Lig);
            Field(x => x.Pax);
            Field(x => x.Pkg);
            Field(x => x.VolId);
        }
    }
}
