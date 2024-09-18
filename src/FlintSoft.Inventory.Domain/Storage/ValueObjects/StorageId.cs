using FlintSoft.Inventory.Domain.Common.Models;

namespace FlintSoft.Inventory.Domain.Storage.ValueObjects;

public sealed class StorageId : ValueObject
{
    public Guid Value { get; }

    private StorageId(Guid value)
    {
        Value = value;
    }

    public static StorageId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
