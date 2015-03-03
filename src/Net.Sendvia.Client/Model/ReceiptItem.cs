using System;

namespace Sendvia.Api.Model
{
    public class ReceiptItem
    {
        public Guid ShipmentId { get; set; }
        public decimal Cost { get; set; }
        public Service Service { get; set; }   
        public bool Vat { get; set; }
        public bool Paid { get; set; }
    }
}