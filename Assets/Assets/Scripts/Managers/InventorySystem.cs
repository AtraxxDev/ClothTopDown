using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<ItemData> ownedItems = new();

    public IReadOnlyList<ItemData> Items => ownedItems;

    public void AddItem(ItemData item)
    {
        if (!ownedItems.Contains(item))
            ownedItems.Add(item);
    }

    public void RemoveItem(ItemData item)
    {
        ownedItems.Remove(item);
    }

    public bool HasItem(ItemData item)
    {
        return ownedItems.Contains(item);
    }
}
