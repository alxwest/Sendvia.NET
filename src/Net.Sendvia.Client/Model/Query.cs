using System;

namespace Sendvia.Api.Model
{
    public class Query
    {
        public Guid Id { get; set; }
        public short Currency { get; set; }
        public Shipment[] Shipments { get; set; }
    }
}