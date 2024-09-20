﻿using FlintSoft.Inventory.Domain.Common.Models;

namespace FlintSoft.Inventory.Domain.UserAggregate.ValueObjects;

public sealed class UserRoleId : ValueObject
{
    public Guid Value { get; }

    private UserRoleId(Guid value)
    {
        Value = value;
    }

    public static UserRoleId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
