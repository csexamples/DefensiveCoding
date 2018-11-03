using System;
using BusinessLayer;
using Xunit;

namespace BusinessLayerTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "John",
                LastName = "Smith"
            };

            string expected = "John, Smith";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Smith"
            };

            string expected = "Smith";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "John",
            };

            string expected = "John";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            var c1 = new Customer
            {
                FirstName = "Bilbo"
            };
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                FirstName = "Frodo"
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Rosie"
            };
            Customer.InstanceCount += 1;

            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                FirstName = "John",
                EmailAddress = "john@email.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingFirstName()
        {
            var customer = new Customer();

            var expected = false;

            var actual = customer.Validate();

            Assert.Equal(expected, actual);
        }
    }
}
