using System;

namespace Sendvia.Api.Model
{
    public class Area
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Boundary { get; set; }
        public string Format { get; set; }   
    }
}