using FlintSoft.Inventory.Domain.Common.Models;
using FlintSoft.Inventory.Domain.ItemDomain.ValueObjects;
using FlintSoft.Inventory.Domain.UserDomain.ValueObjects;
using FlintSoft.Inventory.Domain.YardDomain.ValueObjects;

namespace FlintSoft.Inventory.Domain.ItemDomain;

public sealed class Item : AggregateRoot<ItemId>
{
    public string ItemNumber { get; }

    public string Description { get; }

    public YardId YardId { get; }

    public DateTime BestBefore { get; }

    public UserId CreatedBy { get; }

    public UserId UpdatedBy { get; }

    public DateTime CreatedAt { get; }

    public DateTime ModifiedAt { get; }

    private Item(ItemId itemId,
                 string itemNumber,
                 string description,
                 YardId yardId,
                 DateTime bestBefore,
                 UserId createdBy,
                 UserId updatedBy,
                 DateTime createdAt,
                 DateTime modifiedAt) : base(itemId)
    {
        ItemNumber = itemNumber;
        Description = description;
        YardId = yardId;
        BestBefore = bestBefore;
        CreatedBy = createdBy;
        UpdatedBy = updatedBy;
        CreatedAt = createdAt;
        ModifiedAt = modifiedAt;
    }

    public static Item Create(string itemNumber,
                              string description,
                              YardId yardId,
                              DateTime bestBefore,
                              UserId createdBy,
                              UserId modifiedBy)
    {
        return new(
            ItemId.CreateUnique(),
            itemNumber,
            description,
            yardId,
            bestBefore,
            createdBy,
            modifiedBy,
            DateTime.UtcNow,
            DateTime.UtcNow
            );
    }
}
