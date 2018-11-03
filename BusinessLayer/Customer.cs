using System;
using System.Collections.Generic;
using Common;

namespace BusinessLayer
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }

        public int CustomerId { get; private set; }

        public int CustomerType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = FirstName;

                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(FirstName))
                    {
                        fullName += ", ";
                    }

                    fullName += LastName;
                }

                return fullName;
            }
        }

        public string EmailAddress { get; set; }

        public List<Address> AddressList { get; set; } = new List<Address>();

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            return $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
