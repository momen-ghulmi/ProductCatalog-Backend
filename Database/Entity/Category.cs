namespace Api.Database.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int? ParentId { get; set; }
        public string Image { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
