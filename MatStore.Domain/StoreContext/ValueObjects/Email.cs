using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatStore.Domain.StoreContext.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; set; }

        public override string ToString()
        {
            return Address;
        }
    }
}
