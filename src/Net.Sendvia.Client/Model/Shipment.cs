using System;
using System.Collections.Generic;

namespace Sendvia.Api.Model
{
    public class Shipment : Postal.Common.Model.Shipment
    {
        public Guid Id { get; set; }
        public Contact Sender { get; set; }
        public Contact Recipient { get; set; }
        public List<Parcel> Parcels { get; set; }
    }
}