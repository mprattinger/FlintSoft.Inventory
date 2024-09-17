# Domain Models

## Storage

The Storage is the location or a place which holds multiple [Yards](Aggregates.Yard.md).

```csharp
class Storage {
    Storage Create();
    void AddYard(Yard yard);
    void RemoveYard(Yard yard);
    Storage ModifyStorage(Storage storeag);
    void DeleteStorage(Storage storage);
}
```

```json
{
    "Id": "00000000-0000-0000-0000-000000000000",
    "Name": "Keller",
    "Description": "Kleines Kellerabteil",
    "YardIds": [
        "00000000-0000-0000-0000-000000000000"
    ],
    "CreatedBy": "00000000-0000-0000-0000-000000000000",
    "ModifiedBy": "00000000-0000-0000-0000-000000000000",
    "CreatedAt": "2020-01-01T00:00:00.00.000000Z",
    "ModifiedAt": "2020-01-01T00:00:00.00.000000Z"
}
```