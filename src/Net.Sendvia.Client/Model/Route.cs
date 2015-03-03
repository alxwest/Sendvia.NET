using System;

namespace Sendvia.Api.Model
{
    public class Route
    {
        public Guid Id { get; set; }
        public Area Origin { get; set; }
        public Area Destination { get; set; }
        public short MinDays { get; set; }
        public short MaxDays { get; set; }
        public short CollectionTime { get; set; }
    }
}