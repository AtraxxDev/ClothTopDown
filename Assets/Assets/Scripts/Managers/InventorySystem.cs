using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private int maxSlots = 20;
    [SerializeField] private List<ItemData> ownedItems = new();

    public IReadOnlyList<ItemData> Items => ownedItems;

    public bool AddItem(ItemData item)
    {
        if (ownedItems.Count >= maxSlots)
        {
            Debug.Log("Inventario lleno");
            return false;
        }

        ownedItems.Add(item);
        return true;
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
