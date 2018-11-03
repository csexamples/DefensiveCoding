using System;
using System.Collections.Generic;
using BusinessLayer;
using Common;
using Xunit;

namespace CommonTest
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>
            {
                new Customer(1)
                {
                    FirstName = "John",
                    LastName = "Smith",
                    EmailAddress = "john@email.com"
                },
                new Product(2)
                {
                    ProductName = "Rake",
                    ProductDescription = "Garden Rake With Steel Head"
                },
                new Order(3)
                {
                    OrderDate = new DateTime(2018, 11, 1)
                }
            };

            var expected = $"1: John, Smith Email: john@email.com Status: Active{Environment.NewLine}2: Rake Detail: Garden Rake With Steel Head Status: Active{Environment.NewLine}3: Date: 11/01/2018 00:00:00 Status: Active";

            var actual = LoggingService.WriteToFile(changedItems);

            Assert.Equal(expected, actual);
        }
    }
}
