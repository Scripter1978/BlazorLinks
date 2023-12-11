using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Core.Generators;

public class UniqueIdGenerator : ValueGenerator<string>
{
    public override string Next(EntityEntry entry)
    {
        throw new NotImplementedException();
    }

    public override bool GeneratesTemporaryValues { get; }
}