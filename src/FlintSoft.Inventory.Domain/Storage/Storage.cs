using FlintSoft.Inventory.Domain.Common.Models;
using FlintSoft.Inventory.Domain.Storage.ValueObjects;

namespace FlintSoft.Inventory.Domain.Storage;

public sealed class Storage : AggregateRoot<StorageId>
{
    private readonly List<Yard> _yards = [];
    public string Name { get; }

    public string Description { get; }

    public readonly IReadOnlyList<Yard> Yards => _yards.AsReadOnly();
}
