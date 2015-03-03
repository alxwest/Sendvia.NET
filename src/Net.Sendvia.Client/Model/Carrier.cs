using System;

namespace Sendvia.Api.Model
{
    public class Carrier 
    {    
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public bool Private { get; set; }
    }
}