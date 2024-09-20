using FlintSoft.Inventory.Domain.Common.Models;
using FlintSoft.Inventory.Domain.RoleAggregate.ValueObjects;

namespace FlintSoft.Inventory.Domain.RoleAggregate;

public sealed class Role : AggregateRoot<RoleId>
{
    public string Description { get; }

    private Role(RoleId roleId, string description)
        : base(roleId)
    {
        Description = description;
    }

    public static Role Create(string description)
    {
        return new(
            RoleId.CreateUnique(),
            description
            );
    }
}
