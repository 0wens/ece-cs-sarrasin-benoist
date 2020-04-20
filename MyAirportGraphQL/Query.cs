using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using MyAirport.GraphQL.Type;
using PSB.MyAirport.EF;

namespace MyAirport.GraphQL
{
    public class AirportQuery : ObjectGraphType
    {
        public AirportQuery(MyAirportContext db)
        {

            Field<ListGraphType<BagageType>>(
                "bagages",
                resolve: context => db.Bagages.ToList()
                );
        }
    }
}
