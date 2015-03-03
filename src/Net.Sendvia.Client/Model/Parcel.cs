using System;

namespace Sendvia.Api.Model
{
    public class Parcel 
    {
        public Guid Id { get; set; }
        public string Reference { get; set; }
        public int Weight { get; set; }
        public Dimension Size { get; set; }
        public int? CommodityCode { get; set; }
        public string Description { get; set; }
        public decimal? Value { get; set; }
        public short? Currency { get; set; }
    }
}