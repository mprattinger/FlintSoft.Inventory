using FlintSoft.Inventory.Domain.Common.Models;
using FlintSoft.Inventory.Domain.YardAggregate.ValueObjects;

namespace FlintSoft.Inventory.Domain.YardAggregate.Entities;

public sealed class YardType : Entity<YardTypeId>
{
    public string Description { get; }

    private YardType(YardTypeId yardTypeId, string description)
        : base(yardTypeId)
    {
        Description = description;
    }

    public static YardType Create(string description)
    {
        return new(
            YardTypeId.CreateUnique(),
            description
            );
    }
}
