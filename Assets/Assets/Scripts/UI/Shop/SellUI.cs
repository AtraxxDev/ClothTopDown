using UnityEngine;
using System.Collections.Generic;

public class SellUI : MonoBehaviour
{
    [SerializeField] private InventorySystem inventory;
    [SerializeField] private CoinManager coinManager;
    [SerializeField] private List<SellSlotUI> sellSlots;

    public void OpenSell()
    {
        Refresh();
    }

    private void Refresh()
    {
        for (int i = 0; i < sellSlots.Count; i++)
        {
            if (i < inventory.Items.Count)
            {
                var item = inventory.Items[i];
                sellSlots[i].Initialize(item, OnSellClicked);
                sellSlots[i].gameObject.SetActive(true);
            }
            else
            {
                sellSlots[i].Clear();
            }
        }
    }

    private void OnSellClicked(ItemData item)
    {
        inventory.RemoveItem(item);
        coinManager.Add(item.sellPrice);
        Refresh();
    }
}
