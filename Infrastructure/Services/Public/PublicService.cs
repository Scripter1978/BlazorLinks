using Core.Entities;
using Core.Repositories;

namespace Infrastructure.Services.Public;

public class PublicService(IPublicRepository repository) : IPublicService
{
    public Task<Bio?> GetBio(string id, CancellationToken token = default)
    {
        return repository.GetBio(id, token);
    }
}