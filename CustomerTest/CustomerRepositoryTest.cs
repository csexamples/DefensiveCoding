using System;
using System.Collections.Generic;
using BusinessLayer;
using Xunit;

namespace BusinessLayerTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveExisting()
        {
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "John",
                LastName = "Smith",
                EmailAddress = "john@email.com"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
        }

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                FirstName = "John",
                LastName = "Smith",
                EmailAddress = "john@email.com",
                AddressList = new List<Address>
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address(2)
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        StreetLine2 = "Bywater",
                        City = "Shire",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < expected.AddressList.Count; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }

        [Fact]
        public void RetrieveOrderDisplay()
        {
            var orderRepository = new OrderRepository();

            var expected = new OrderDisplay
            {
                FirstName = "John",
                LastName = "Smith",
                ShippingAddress = new Address
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>
                {
                    new OrderDisplayItem
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96m,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem
                    {
                        ProductName = "Rake",
                        PurchasePrice = 6m,
                        OrderQuantity = 1
                    }
                }
            };

            var actual = orderRepository.RetrieveOrderDisplay(10);

            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.Equal(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.Equal(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            Assert.Equal(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.Equal(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.Equal(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.Equal(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < expected.OrderDisplayItemList.Count; i++)
            {
                Assert.Equal(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.Equal(expected.OrderDisplayItemList[i].PurchasePrice, actual.OrderDisplayItemList[i].PurchasePrice);
                Assert.Equal(expected.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
            }
        }
    }
}
