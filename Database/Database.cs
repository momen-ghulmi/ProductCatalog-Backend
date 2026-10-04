using Microsoft.EntityFrameworkCore;
namespace Api.Database
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {
        }
        
        public DbSet<Entity.Category> Categories => Set<Entity.Category>();
        public DbSet<Entity.Product> Products => Set<Entity.Product>();


    }
}
