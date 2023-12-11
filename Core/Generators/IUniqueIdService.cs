using Core.Enums;

namespace Core.Generators;

public interface IUniqueIdService
{
    string Generator(int maxLength = 10);
    string Generator(UniqueIdType type, int maxLength = 10);
}