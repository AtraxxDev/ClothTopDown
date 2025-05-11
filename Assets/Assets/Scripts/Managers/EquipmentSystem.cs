using System.Collections.Generic;
using UnityEngine;

public class EquipmentSystem : MonoBehaviour
{
    private Dictionary<ItemType, ItemData> equippedItems = new();

    public delegate void OnItemEquippedDelegate (ItemData item);
    public event OnItemEquippedDelegate OnItemEquipped;

    public ItemData EquipItem(ItemData item)
    {
        if (item == null) return null;

        ItemData previousItem = null;

        if (equippedItems.TryGetValue(item.type, out var existing))
        {
            previousItem = existing;
        }

        equippedItems[item.type] = item;
        OnItemEquipped?.Invoke(item);

        return previousItem;
    }


    public ItemData GetEquippedItem(ItemType type)
    {
        return equippedItems.TryGetValue(type, out var item) ? item : null;
    }

    public void UnequipItem(ItemType type)
    {
        if (equippedItems.ContainsKey(type))
        {
            equippedItems.Remove(type);
            OnItemEquipped?.Invoke(new ItemData { type = type });
        }
    }

}
