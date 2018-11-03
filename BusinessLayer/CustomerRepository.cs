using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class CustomerRepository
    {
        private AddressRepository _addressRepository { get; set; } = new AddressRepository();

        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId)
            {
                AddressList = _addressRepository.RetrieveByCustomerId(customerId).ToList()
            };

            if (customerId == 1)
            {
                customer.FirstName = "John";
                customer.LastName = "Smith";
                customer.EmailAddress = "john@email.com";
            }

            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>
            {
                new Customer(1)
                {
                    FirstName = "John",
                    LastName = "Smith",
                    EmailAddress = "john@email.com"
                },
                new Customer(2)
                {
                    FirstName = "Jay",
                    LastName = "Allen",
                    EmailAddress = "jay@email.com"
                },
                new Customer(3)
                {
                    FirstName = "Rosie",
                    LastName = "Willington",
                    EmailAddress = "rosie@email.com"
                }
            };
        }

        public bool Save()
        {
            return true;
        }
    }
}
