using Microsoft.EntityFrameworkCore;

namespace Revenue_Recognition_System.DAL;

public class RRSDbContext : DbContext
{
    protected RRSDbContext()
    {
    }

    public RRSDbContext(DbContextOptions options) : base(options)
    {
    }
    
}