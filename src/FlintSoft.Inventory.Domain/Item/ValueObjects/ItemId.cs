using FlintSoft.Inventory.Domain.Common.Models;

namespace FlintSoft.Inventory.Domain.ItemDomain.ValueObjects
{
    public sealed class ItemId : ValueObject
    {
        public Guid Value { get; }

        private ItemId(Guid value)
        {
            Value = value;
        }

        public static ItemId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
