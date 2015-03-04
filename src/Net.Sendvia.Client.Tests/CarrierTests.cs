using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Net.Sendvia.Tests
{
    [TestClass]
    public class CarrierTests
    {
        [TestMethod]
        public void CreateCarrier()
        {
            var client = Helpers.Client.Create();

            var carrier = new Models.Carrier
            {
                Id = Guid.NewGuid(),
                Name = "Test Carrier",
                Editable = false,
                Private = true
            };

            var r = client.Carrier_Create(carrier);

        }
    }
}
