using Microsoft.EntityFrameworkCore;
using OrderPickupApp.Models;

namespace OrderPickupApp.Data;

public class OrdersContext : DbContext
{
    public OrdersContext(DbContextOptions<OrdersContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }
}