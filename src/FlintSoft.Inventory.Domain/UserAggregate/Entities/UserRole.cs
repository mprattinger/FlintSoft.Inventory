using FlintSoft.Inventory.Domain.Common.Models;
using FlintSoft.Inventory.Domain.UserAggregate.ValueObjects;

namespace FlintSoft.Inventory.Domain.UserAggregate.Entities
{
    public sealed class UserRole : Entity<UserRoleId>
    {
        public string Description { get; }

        private UserRole(UserRoleId userRoleId, string description)
            : base(userRoleId)
        {
            Description = description;
        }

        public static UserRole Create(string description)
        {
            return new(
                UserRoleId.CreateUnique(),
                description
                );
        }
    }
}
