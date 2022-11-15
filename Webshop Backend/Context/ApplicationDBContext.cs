using Microsoft.EntityFrameworkCore;
using Webshop_Backend.DTO_s;

namespace Webshop_Backend.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<ItemDTO> items { get; set; }
            public DbSet<UserDTO> users { get; set; }
            public DbSet<OrderDTO> orders { get; set; }

        
    }
}
