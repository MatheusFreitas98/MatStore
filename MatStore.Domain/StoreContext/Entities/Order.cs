using MatStore.Domain.StoreContext.Enums;

namespace MatStore.Domain.StoreContext.Entities
{
    public class Order
    {
        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;

        public Order(Customer customer) {
            Customer = customer;
            Number = new Guid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            _items = new List<OrderItem>();
            _deliveries = new List<Delivery>();
        }

        public void AddItem(OrderItem item)
        {
            // Validar
            _items.Add(item);
        }

        public void AddDelivery(Delivery delivery)
        {
            // Validar
            _deliveries.Add(delivery);
        }

        public string Number { get; private set; }
        public Customer Customer { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        public void Place()
        {
            
        }
    }
}