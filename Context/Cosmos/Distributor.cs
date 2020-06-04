using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Context.Cosmos
{
    public class Distributor
    {
        public int Id { get; set; }
        public ICollection<StreetAddress> ShippingCenters { get; set; }
    }
}
