using System;

namespace Sendvia.Api.Model
{
    public class Rate
    {
        public Guid Id { get; set; }   
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
        public int MinVolume { get; set; }
        public int MaxVolume { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public int MinWidth { get; set; }
        public int MaxWidth { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        public int MinQuantity { get; set; }
        public int MaxQuantity { get; set; }
        public decimal WeightRate { get; set; }
        public decimal ItemRate { get; set; }
        public short Currency { get; set; }
    }
}