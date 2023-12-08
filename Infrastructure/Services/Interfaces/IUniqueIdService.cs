using Core.Enums;

namespace Infrastructure.Services.Interfaces;

public interface IUniqueIdService
{
    string Generator(int maxLength = 10);
    string Generator(UniqueIdType type, int maxLength = 10);
}