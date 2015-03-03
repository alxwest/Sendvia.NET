using System;

namespace Sendvia.Api.Model
{
    public class Contact: Postal.Common.Model.Contact
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }  
    }
}