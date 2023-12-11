using Core.Entities;

namespace Infrastructure.Services.Public;

public interface IPublicService
{
    Task<Bio?> GetBio(string id, CancellationToken token = default);
}