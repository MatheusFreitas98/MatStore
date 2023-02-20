namespace MatStore.Domain.StoreContext.Entities
{
    public class Product
    {
        public Product(int id, string title, string description, decimal price, decimal quantityOnHand, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            QuantityOnHand = quantityOnHand;
            Image = image;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public decimal QuantityOnHand { get; private set; }
        public string Image { get; private set; }

        public override string ToString()
        {
            return $"{Title}: {Description}";
        }
    }
    
}