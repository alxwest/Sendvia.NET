using System;

namespace Sendvia.Api.Model
{
    public class BookingShipment
    {
        public Shipment Shipment { get; set; }
        public Guid ServiceId { get; set; }
    }
}