using MatStore.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatStore.Domain.StoreContext.ValueObjects
{
    public class Address
    {
        public Address(string street, string number, string complement, string city, string state, string postalCode, string country, string zipcode, EAddressType addressType)
        {
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
            ZipCode = zipcode;
            Type = addressType;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public EAddressType Type { get; private set; }

        public override string ToString()
        {
            return $"{Street} {Number} {City}";
        }

    }
}
