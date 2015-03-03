using System;
using System.Collections.Generic;

namespace Sendvia.Api.Model
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public Guid BookingId { get; set; }  
        public short Currency { get; set; }
        public string PaymentUrl { get; set; } 
        public List<ReceiptItem> ReceiptItems { get; set; }
    }
}