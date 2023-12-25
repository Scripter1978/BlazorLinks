 
using Core.Entities; 

namespace Infrastructure.Services.Public;

public class PublicService(Supabase.Client client) : IPublicService
{
    public async Task<Bio?> GetBio(string id, CancellationToken token = default)
    {

        var bios = await client.From<Bio>().Where(m => m.UserId == id).Get();
        return bios.Models.FirstOrDefault();
    }
}