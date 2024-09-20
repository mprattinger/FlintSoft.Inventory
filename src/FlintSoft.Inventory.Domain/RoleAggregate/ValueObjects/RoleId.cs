using FlintSoft.Inventory.Domain.Common.Models;

namespace FlintSoft.Inventory.Domain.RoleAggregate.ValueObjects;

public sealed class RoleId : ValueObject
{
    public Guid Value { get; }

    private RoleId(Guid value)
    {
        Value = value;
    }

    public static RoleId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
