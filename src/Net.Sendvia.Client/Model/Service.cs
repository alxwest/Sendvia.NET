using System;

namespace Sendvia.Api.Model
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Transport { get; set; }
        public bool Tracked { get; set; }
        public bool Volumetric { get; set; }
        public bool PrintLabels { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
    }
}