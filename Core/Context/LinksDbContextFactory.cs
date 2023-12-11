using Microsoft.EntityFrameworkCore;

namespace Core.Context;
// Create a factory to create a new instance of LinksDbContext


public class LinksDbContextFactory : ILinksDbContextFactory
{
    public LinksDbContext CreateDbContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<LinksDbContext>();
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-7Q7J8QV\SQLEXPRESS;Database=db;Trusted_Connection=True;");
        
        return new LinksDbContext(optionsBuilder.Options);
    }
}