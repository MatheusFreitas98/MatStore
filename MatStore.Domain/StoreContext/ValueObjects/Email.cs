using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatStore.Domain.StoreContext.ValueObjects
{
    public class Email : Notifiable
    {
        public string Address { get; set; }

        public Email(string address)
        {
            Address = address;

            AddNotifications(
                new ValidationContract().IsEmail(Address, "Email", "O Email é inválido")
                );
        }

        public override string ToString()
        {
            return Address;
        }
    }
}
