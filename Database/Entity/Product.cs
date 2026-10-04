namespace Api.Database.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; } = "";
        public string Sku { get; set; }
        public string Image { get; set; } = "";
        public decimal Price { get; set; }
        
        public decimal Msrp { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public string LongDescription { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }

    }
}
