# Domain Models

## User

```csharp
class User {
    User Create();
    User ChangePassword(User user);
    User Modify(User user);
    void RemoveUser(User user);
    void SetRole(Role role);
}
```

```json
{
    "Id": "00000000-0000-0000-0000-000000000000",
    "FirstName": "Michael",
    "LastName": "Prattinger",
    "EMail": "test@test.com",
    "Password": "abcd1234",
    "Token": "efgh...45hu",
    "Role": {
        "Id": "00000000-0000-0000-0000-000000000000",
        "Description": "Admin"
    },
    "CreatedBy": "00000000-0000-0000-0000-000000000000",
    "ModifiedBy": "00000000-0000-0000-0000-000000000000",
    "CreatedAt": "2020-01-01T00:00:00.00.000000Z",
    "ModifiedAt": "2020-01-01T00:00:00.00.000000Z"
}
```