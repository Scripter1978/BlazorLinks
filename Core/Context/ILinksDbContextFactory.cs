namespace Core.Context;

public interface ILinksDbContextFactory
{
    LinksDbContext CreateDbContext();
}