using System;

namespace Sendvia.Api.Model
{
    public class QuoteShipment
    {
        public Guid ShipmentId { get; set; }
        public decimal Cost { get; set; }
        public decimal Surcharge { get; set; }
        public DateTime EarliestCollection { get; set; }  
        public Service Service { get; set; }
        public bool Vat { get; set; }
    }
}