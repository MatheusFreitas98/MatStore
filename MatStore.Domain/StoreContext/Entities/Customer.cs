using MatStore.Domain.StoreContext.ValueObjects;

namespace MatStore.Domain.StoreContext.Entities
{
    public class Customer
    {
        public Customer(Name fullName, Document document, string email, string phone)
        {
            FullName = fullName;            
            Document = document;
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();
        }

        private readonly IList<Address> _addresses;

        public int Id { get; private set; }
        public Name FullName { get; set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            // Valida Endereco
            // Adiciona Endereco
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return FullName.ToString();
        }
    }


}