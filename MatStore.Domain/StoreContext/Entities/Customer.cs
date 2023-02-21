using FluentValidator;
using MatStore.Domain.StoreContext.ValueObjects;

namespace MatStore.Domain.StoreContext.Entities
{
    public class Customer : Notifiable
    {
        private readonly IList<Address> _addresses;

        public int Id { get; private set; }
        public Name FullName { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Phone Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public Customer(Name fullName, Document document, Email email, Phone phone)
        {
            Id = new Random().Next();
            FullName = fullName;
            Document = document;
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();
        }

        public void AddAddress(Address address)
        {
            // Validar Endereco
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return FullName.ToString();
        }
    }


}