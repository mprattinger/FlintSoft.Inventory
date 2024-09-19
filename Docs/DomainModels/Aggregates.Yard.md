# Domain Models

## Yard

A yard is a place where [items](Aggregates.Item.md) are stored. A yard is part of a [storage](Aggregates.Storage.md) and can also have "sub" yards.
> Example:
    -> Keller -> Regal -> 3. Fach -> Grüne Box

```csharp
class Yard {
    Yard Create();
    void AddItem(Item item);
    void RemoveItem(Item item);
    Yard ModifyYard(Yard yard);
    void DeleteYard(Yard storage);
}
```

```json
{
    "Id": "00000000-0000-0000-0000-000000000000",
    "Name": "Regal",
    "Description": "Regal rechts",
    "ItemIds": [
        "00000000-0000-0000-0000-000000000000"
    ],
    "YardType": {
        "id": "00000000-0000-0000-0000-000000000000",
        "Description": "Regal"
    },
    "ParentYardId": "00000000-0000-0000-0000-000000000000",
    "CreatedBy": "00000000-0000-0000-0000-000000000000",
    "ModifiedBy": "00000000-0000-0000-0000-000000000000",
    "CreatedAt": "2020-01-01T00:00:00.00.000000Z",
    "ModifiedAt": "2020-01-01T00:00:00.00.000000Z"
}
```