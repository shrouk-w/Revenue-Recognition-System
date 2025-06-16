using Microsoft.EntityFrameworkCore;
using Revenue_Recognition_System.Model;

namespace Revenue_Recognition_System.DAL;

public class RRSDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Software> Software { get; set; }
    
    protected RRSDbContext()
    {
    }

    public RRSDbContext(DbContextOptions options) : base(options)
    {
    }
    
}