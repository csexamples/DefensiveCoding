using System;
using System.Collections.Generic;
using Common;

namespace BusinessLayer
{
    public class Order : EntityBase, ILoggable
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }

        public int CustomerId { get; set; }

        public int ShippingAddressId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public string Log()
        {
            return $"{OrderId}: Date: {OrderDate.Value.Date} Status: {EntityState.ToString()}";
        }

        public override string ToString()
        {
            return $"{OrderDate} ({OrderId})";
        }
    }
}
