using FlintSoft.Inventory.Domain.Common.Models;

namespace FlintSoft.Inventory.Domain.YardDomain.ValueObjects;

public sealed class YardId : ValueObject
{
    public Guid Value { get; }

    private YardId(Guid value)
    {
        Value = value;
    }

    public static YardId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
