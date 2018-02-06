using System;
using Microsoft.EntityFrameworkCore;
using wawa_api.Models;

namespace wawa_api.Resources
{
    public class OrderContext : DbContext
    {
        
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }
        
        public DbSet<Order> order { get; set; }
    }
}