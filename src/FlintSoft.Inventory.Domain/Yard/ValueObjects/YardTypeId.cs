using FlintSoft.Inventory.Domain.Common.Models;

namespace FlintSoft.Inventory.Domain.YardDomain.ValueObjects;

public sealed class YardTypeId : ValueObject
{
    public Guid Value { get; }

    private YardTypeId(Guid value)
    {
        Value = value;
    }

    public static YardTypeId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
