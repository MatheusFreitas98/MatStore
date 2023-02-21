using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatStore.Domain.StoreContext.ValueObjects
{
    public class Phone
    {
        public string Number { get; set; }
        public Phone(string number)
        {
            Number = number;
        }
    }
}
