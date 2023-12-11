using Core.Entities;

namespace Core.Repositories;

public interface IPublicRepository
{
    Task<Bio?> GetBio(string id, CancellationToken token = default);
}