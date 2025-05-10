using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private InventorySystem inventory;
    [SerializeField] private List<InventorySlotUI> slots; 

    public static event Action OnInventoryOpened;
    public static event Action OnInventoryClosed;

    private void OnEnable()
    {
        Refresh();
        OnInventoryOpened.Invoke();
    }

    private void OnDisable()
    {
        OnInventoryClosed.Invoke();
    }

    public void Refresh()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (i < inventory.Items.Count)
            {
                slots[i].Initialize(inventory.Items[i], OnSlotClicked);
                slots[i].gameObject.SetActive(true);
            }
            else
            {
                slots[i].Clear(); 
                //slots[i].gameObject.SetActive(false);
            }
        }
    }

    private void OnSlotClicked(ItemData item)
    {
        Debug.Log($"Clic en: {item.displayName}");
        // EquipItem(item), vender, etc.
    }
}
