using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Context.Cosmos
{
    public class Order
    {
        public int Id { get; set; }
        public int? TrackingNumber { get; set; }
        public string PartitionKey { get; set; }
        public StreetAddress ShippingAddress { get; set; }
    }
}