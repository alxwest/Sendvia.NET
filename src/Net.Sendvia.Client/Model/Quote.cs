using System;

namespace Sendvia.Api.Model
{
    public class Quote
    {
        public Guid Id { get; set; }
        public Guid QueryId { get; set; }
        public short Currency { get; set; }
        public QuoteShipment[] QuoteShipments { get; set; }
    }
}