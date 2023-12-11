using Core.Context;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public class PublicRepository(IDbContextFactory<LinksDbContext> _context) : IPublicRepository
{
    public async Task<Bio?> GetBio(string id, CancellationToken token = default)
    {
        await using var db = await _context.CreateDbContextAsync(token);
        return await db.Bios.FirstOrDefaultAsync(x=>x.BioId == id || x.UserName == id, token);
    }
}