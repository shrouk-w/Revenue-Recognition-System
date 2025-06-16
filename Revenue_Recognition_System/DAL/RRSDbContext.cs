using Microsoft.EntityFrameworkCore;
using Revenue_Recognition_System.Model;

namespace Revenue_Recognition_System.DAL;

public class RRSDbContext : DbContext
{
    DbSet<Customer> Customers { get; set; }
    
    protected RRSDbContext()
    {
    }

    public RRSDbContext(DbContextOptions options) : base(options)
    {
    }
    
}