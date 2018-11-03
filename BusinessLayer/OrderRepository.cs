using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(new DateTime(2018, 11, 1));
            }

            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            var orderDisplay = new OrderDisplay
            {
                OrderId = orderId
            };

            if (orderId == 10)
            {
                orderDisplay.FirstName = "John";
                orderDisplay.LastName = "Smith";
                orderDisplay.ShippingAddress = new Address
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
                orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>
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
                };
            }

            return orderDisplay;
        }

        public bool Save()
        {
            return true;
        }
    }
}
