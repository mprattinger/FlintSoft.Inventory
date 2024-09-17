# Domain Models

## Item

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
    "ItemNumer": "SD-1234",
    "Name": "Steckdose",
    "Description": "Steckdose außen",
    "YardId": "00000000-0000-0000-0000-000000000000",
    "BestBefore": "2020-01-01T00:00:00.00.000000Z",
    "CreatedBy": "00000000-0000-0000-0000-000000000000",
    "ModifiedBy": "00000000-0000-0000-0000-000000000000",
    "CreatedAt": "2020-01-01T00:00:00.00.000000Z",
    "ModifiedAt": "2020-01-01T00:00:00.00.000000Z"
}
```