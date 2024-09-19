using FlintSoft.Inventory.Domain.Common.Models;
using FlintSoft.Inventory.Domain.UserDomain.ValueObjects;

namespace FlintSoft.Inventory.Domain.UserDomain
{
    public sealed class User : AggregateRoot<UserId>
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }

        public string Password { get; }

        public UserRoleId UserRoleId { get; }

        public DateTime CreatedAt { get; }

        public DateTime ModifiedAt { get; }

        private User(UserId userId,
                     string firstName,
                     string lastName,
                     string email,
                     string password,
                     UserRoleId userRoleId,
                     DateTime createdAt,
                     DateTime modifiedAt)
            : base(userId)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            UserRoleId = userRoleId;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }

        public static User Create(string firstName,
                     string lastName,
                     string email,
                     string password,
                     UserRoleId userRoleId)
        {
            return new(
                UserId.CreateUnique(),
                firstName,
                lastName,
                email,
                password,
                userRoleId,
                DateTime.UtcNow,
                DateTime.UtcNow);
        }
    }
}
