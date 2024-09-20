using FlintSoft.Inventory.Domain.Common.Models;
using FlintSoft.Inventory.Domain.ItemAggregate;
using FlintSoft.Inventory.Domain.UserAggregate.ValueObjects;
using FlintSoft.Inventory.Domain.YardAggregate.ValueObjects;

namespace FlintSoft.Inventory.Domain.YardAggregate;

public sealed class Yard : AggregateRoot<YardId>
{
    private readonly List<Item> _items = [];

    public string Name { get; }

    public string Description { get; }

    public IReadOnlyList<Item> Items => _items.AsReadOnly();

    public YardTypeId YardTypeId { get; }

    public YardId ParentYardId { get; }

    public UserId CreatedBy { get; }

    public UserId UpdatedBy { get; }

    public DateTime CreatedAt { get; }

    public DateTime ModifiedAt { get; }

    private Yard(YardId yardId,
                 string name,
                 string description,
                 YardTypeId yardTypeId,
                 YardId parentYardId,
                 UserId createdBy,
                 UserId updatedBy,
                 DateTime createdAt,
                 DateTime modifiedAt) : base(yardId)
    {
        Name = name;
        Description = description;
        YardTypeId = yardTypeId;
        ParentYardId = parentYardId;
        CreatedBy = createdBy;
        UpdatedBy = updatedBy;
        CreatedAt = createdAt;
        ModifiedAt = modifiedAt;
    }

    public static Yard Create(string name,
                              string description,
                              YardTypeId yardTypeId,
                              YardId parentYardId,
                              UserId createdBy,
                              UserId modifiedBy)
    {
        return new(YardId.CreateUnique(),
                   name,
                   description,
                   yardTypeId,
                   parentYardId,
                   createdBy,
                   modifiedBy,
                   DateTime.UtcNow,
                   DateTime.UtcNow);
    }
}
