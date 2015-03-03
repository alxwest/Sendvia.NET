using System;

namespace Sendvia.Api.Model
{
    public class Address: Postal.Common.Model.Address
    {
        public Guid Id { get; set; }              
    }
}