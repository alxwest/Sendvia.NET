using System;

namespace Sendvia.Api.Model
{
    public class Milestone
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public short CountryIso { get; set; }
    }
}