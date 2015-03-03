using System;

namespace Sendvia.Api.Model
{
    public class Markup 
    {
        public Guid Id { get; set; }
        public decimal? Decimal { get; set; }
        public decimal? Amount { get; set; }        
        public int? Currency { get; set; }
        public Carrier Carrier { get; set; }
        public Service Service { get; set; }
        public Route Route { get; set; }
    }
}