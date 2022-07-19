using OrderApp.D.Entities;
using Microsoft.EntityFrameworkCore;

namespace OrderApp.EF
{
    public class OrderAppDbContext : DbContext
    {
        public OrderAppDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Headphones> Headphones { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Mouse> Mice { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
