namespace MatStore.Domain.StoreContext.Entities
{
    public class OrderItem
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = Product.Price;

            if (product.QuantityOnHand < quantity)
                throw new Exception("Quantidade inválida");
        }

        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }

        public override string ToString()
        {
            return $"Product: {Product}. Quantity: {Quantity}. Total Price: {Price} ";
        }

    }
}