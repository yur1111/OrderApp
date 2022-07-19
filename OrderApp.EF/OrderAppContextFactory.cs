using Microsoft.EntityFrameworkCore;
using System;

namespace OrderApp.EF
{
    public class OrderAppContextFactory
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;

        public OrderAppContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }

        public OrderAppDbContext CreateDbContext()
        {
            DbContextOptionsBuilder<OrderAppDbContext> options = new DbContextOptionsBuilder<OrderAppDbContext>();

            _configureDbContext(options);

            return new OrderAppDbContext(options.Options);
        }
    }
}
