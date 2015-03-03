using System;

namespace Sendvia.Api.Model
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid? QuoteId { get; set; }
        public short PaymentMethod { get; set; }
        public short Currency { get; set; }
        public BookingShipment[] BookingShipments { get; set; }
    }
}