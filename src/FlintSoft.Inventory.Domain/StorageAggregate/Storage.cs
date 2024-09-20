using FlintSoft.Inventory.Domain.Common.Models;
using FlintSoft.Inventory.Domain.StorageAggregate.ValueObjects;
using FlintSoft.Inventory.Domain.UserAggregate.ValueObjects;
using FlintSoft.Inventory.Domain.YardAggregate;

namespace FlintSoft.Inventory.Domain.StorageAggregate;

public sealed class Storage : AggregateRoot<StorageId>
{
    private readonly List<Yard> _yards = [];
    public string Name { get; }

    public string Description { get; }

    public IReadOnlyList<Yard> Yards => _yards.AsReadOnly();

    public UserId CreatedBy { get; }

    public UserId UpdatedBy { get; }

    public DateTime CreatedAt { get; }

    public DateTime ModifiedAt { get; }

    private Storage(StorageId storageId,
                    string name,
                    string description,
                    UserId createdBy,
                 UserId updatedBy,
                    DateTime createdAt,
                    DateTime modifiedAt)
        : base(storageId)
    {
        Name = name;
        Description = description;
        CreatedBy = createdBy;
        UpdatedBy = updatedBy;
        CreatedAt = createdAt;
        ModifiedAt = modifiedAt;
    }

    public static Storage Create(string name,
                                 string description,
                                 UserId createdBy,
                                 UserId modifiedBy)
    {
        return new(
            StorageId.CreateUnique(),
            name,
            description,
            createdBy,
                   modifiedBy,
            DateTime.UtcNow,
            DateTime.UtcNow
            );
    }
}
