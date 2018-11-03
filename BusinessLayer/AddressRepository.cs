using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            return new List<Address>
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
            };
        }
    }
}
