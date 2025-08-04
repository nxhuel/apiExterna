using Microsoft.EntityFrameworkCore;

namespace ApiExterna.Context;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {
        
    }
}