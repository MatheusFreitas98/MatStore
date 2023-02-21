using MatStore.Domain.StoreContext.Enums;

namespace MatStore.Domain.StoreContext.Entities
{
    public class Order
    {
        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;

        public string Number { get; private set; }
        public Customer Customer { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        public Order(Customer customer)
        {
            Customer = customer;
            Number = "";
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
            _deliveries.Add(delivery);
        }

        public void Place()
        {
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            Number = new Guid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
        }

        public void Pay()
        {
            Status = EOrderStatus.Paid;
        }

        public void Ship()
        {
            var deliveries = new List<Delivery>();
            deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));

            // A cada 5 produtos é uma entrega
            var count = 1;

            foreach(var item in _items)
            {
                if (count == 5)
                {
                    count = 1;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
                }
                count++;
            }

            // Envia todas as entregas
            deliveries.ForEach(x => x.Ship());

            // Adiciona as entregas ao pedido
            deliveries.ForEach(x => _deliveries.Add(x));
        }

        public void Cancel()
        {
            //Se o status já estiver entregue, não cancelar
            Status = EOrderStatus.Canceled;
            _deliveries.ToList().ForEach(x => x.Cancel());
        }


    }
}